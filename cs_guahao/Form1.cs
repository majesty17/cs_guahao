using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LitJson;
namespace cs_guahao
{
    public partial class Form1 : Form
    {

        private GuahaoAPI guahao;
        private JsonData config;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 启动，初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {


            //尝试获取本地配置
            config = Utils.loadConfig();
            //初始化挂号对象
            guahao = new GuahaoAPI(textBox_conf_cookie.Text.Trim());

            //应用配置到主体
            config_apply();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            rewrite_config(); //重写配置
            Utils.saveConfig(config); //保存配置
        }

        /// <summary>
        /// 设置查询状态
        /// </summary>
        /// <param name="msg"></param>
        private void set_status(string msg)
        {
            toolStripStatusLabel1.Text = "[" + DateTime.Now.ToString() + "] " + msg;
        }


        /// <summary>
        /// 搜索医院
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_search_Click(object sender, EventArgs e)
        {

            int level = Convert.ToInt32(comboBox_level.Text.Split(new char[] { '-' })[1]);
            int area = Convert.ToInt32(comboBox_area.Text.Split(new char[] { '-' })[1]);

            JsonData data = guahao.hospital_list(textBox_kw.Text.Trim(), level, area, 1, 100000);
            listView_hos_list.Items.Clear();
            foreach(JsonData item in data["data"]["list"])
            {
                try
                {
                    ListViewItem lvi = new ListViewItem(item["levelText"].ToString());

                    JsonData maintain = item["openTimeText"];
                    if (maintain is null)
                    {
                        lvi.SubItems.Add("每天改号");
                    }
                    else
                    {
                        lvi.SubItems.Add(maintain.ToString());
                    }
                    lvi.SubItems.Add(item["name"].ToString());
                    lvi.SubItems.Add(item["code"].ToString());

                    listView_hos_list.Items.Add(lvi);
                }catch(Exception ex)
                {
                    Console.Out.WriteLine(ex.Message);
                    Console.Out.WriteLine(item.ToString());
                    foreach (string key in item.Keys)
                    {
                        Console.Out.WriteLine(key);
                        Console.Out.WriteLine(item[key]);
                    }

                }
            }


            set_status(string.Format("已找到{0}个医院", listView_hos_list.Items.Count));
        }



        /// <summary>
        /// 选中医院，显示科室
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_hos_list_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView_hos_list.SelectedItems.Count > 0)
            {
                ListViewItem lvi_old = listView_hos_list.SelectedItems[0];
                string hoscode = lvi_old.SubItems[3].Text;
                JsonData detail = guahao.hospital_detail(hoscode);
                JsonData depts = guahao.hospital_department(hoscode);
                //1,展示科室树
                treeView_dept.Nodes.Clear();
                treeView_dept.Tag = hoscode; 
                foreach (JsonData dept in depts["data"]["list"])
                {
                    TreeNode anode = new TreeNode(dept["name"].ToString());
                    //二级节点
                    foreach(JsonData dept_sub in dept["subList"])
                    {
                        TreeNode anode_sub = new TreeNode(dept_sub["name"].ToString());
                        anode_sub.Tag = dept_sub; //把对象放到tag里
                        anode.Nodes.Add(anode_sub);
                    }
                    treeView_dept.Nodes.Add(anode);
                }
                //2,展示通知
                JsonData notice = guahao.hospital_notice(hoscode);
                textBox_hos_detail.Clear();
                try {
                    textBox_hos_detail.Text = notice["data"]["content"].ToString().Replace("\n", Environment.NewLine);
                }
                catch(Exception ex)
                {
                    Console.Out.WriteLine(ex.Message);
                    Console.Out.WriteLine(notice.ToString());

                }
                set_status("展示详情成功!");
            }
            else
            {
                Console.Out.WriteLine("请选中医院！");
                set_status("请选中医院!");
                return;
            }

        }
        /// <summary>
        /// 获取就诊人列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_get_patient_Click(object sender, EventArgs e)
        {

            JsonData data = guahao.patient_list();
            listView_patient_list.Items.Clear();
            try
            {
                int ct = int.Parse(data["data"]["count"].ToString());
                foreach (JsonData person in data["data"]["list"])
                {

                    ListViewItem lvi=new ListViewItem(person["patientName"].ToString());
                    lvi.SubItems.Add(person["idCardTypeView"].ToString());
                    lvi.SubItems.Add(person["idCardNoView"].ToString());
                    lvi.Tag = person["idCardNo"].ToString();
                    listView_patient_list.Items.Add(lvi);

                }
                set_status(ct + "就诊人找到!");
            }
            catch(Exception ex)
            {
                Login login = new Login();
                login.ShowDialog(this);
                set_status("获取就诊人失败:" + ex.Message);
            }

        }



        /// <summary>
        /// 自动更新cookie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_conf_cookie_TextChanged(object sender, EventArgs e)
        {
            config["cookie"] = textBox_conf_cookie.Text.Trim();
            guahao.set_cookie(config["cookie"].ToString());
        }

        /// <summary>
        /// 双击门诊node
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_dept_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = treeView_dept.SelectedNode;

            if (node != null && node.Tag != null && node.Tag!=null)
            {
                JsonData tag = (JsonData)node.Tag;
                string hoscode = treeView_dept.Tag.ToString();
                string code1 = tag["dept1Code"].ToString();
                string code2 = tag["code"].ToString();
                JsonData data = guahao.product_list(hoscode, code1, code2);
            }
        }

        /// <summary>
        /// 退出前重写配置对象
        /// </summary>
        private void rewrite_config()
        {
            config["cookie"] = textBox_conf_cookie.Text.Trim();
            config["hos_area"] = comboBox_area.SelectedIndex;
            config["hos_level"] = comboBox_level.SelectedIndex;
            config["hos_kw"] = textBox_kw.Text.Trim();
            set_status("配置已保存!");
        }
        /// <summary>
        /// 应用当前配置到界面
        /// </summary>
        private void config_apply()
        {
            if (config.Keys.Contains("cookie"))
                textBox_conf_cookie.Text = config["cookie"].ToString();
            if (config.Keys.Contains("hos_area"))
                comboBox_area.SelectedIndex = int.Parse(config["hos_area"].ToString()) % comboBox_area.Items.Count;
            if (config.Keys.Contains("hos_level"))
                comboBox_level.SelectedIndex = int.Parse(config["hos_level"].ToString()) % comboBox_level.Items.Count;
            if (config.Keys.Contains("hos_kw"))
                textBox_kw.Text = config["hos_kw"].ToString();
            set_status("加载配置成功!");
        }


        /// <summary>
        /// 选中候选人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_patient_list_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            if (listView_patient_list.SelectedItems.Count > 0)
            {
                ListViewItem lvi_old = listView_patient_list.SelectedItems[0];
                string id = (string)lvi_old.Tag;
                listView_order_list.Items.Clear();
                JsonData data = guahao.order_list(id);
                foreach( JsonData row in data["data"]["list"])
                {
                    ListViewItem lvi = new ListViewItem(row["visitTime"].ToString());
                    lvi.SubItems.Add(row["hosName"].ToString());
                    lvi.SubItems.Add(row["deptName"].ToString());
                    lvi.SubItems.Add(row["doctorTitle"].ToString());
                    lvi.SubItems.Add(row["serviceFee"].ToString());
                    lvi.SubItems.Add(row["orderStatusView"].ToString());
 

                    listView_order_list.Items.Add(lvi);
                }
            }
        }
    }
}
