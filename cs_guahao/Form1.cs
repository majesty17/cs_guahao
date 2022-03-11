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
            comboBox_level.SelectedIndex = 0;
            comboBox_area.SelectedIndex = 0;
            guahao = new GuahaoAPI();
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
                foreach (JsonData dept in depts["data"]["list"])
                {
                    TreeNode anode = new TreeNode(dept["name"].ToString());

                    foreach(JsonData dept_sub in dept["subList"])
                    {
                        TreeNode anode_sub = new TreeNode(dept_sub["name"].ToString());
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
            }
            else
            {
                Console.Out.WriteLine("请选中医院！");
                return;
            }

        }
        /// <summary>
        /// 获取就诊人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_get_patient_Click(object sender, EventArgs e)
        {
            textBox_patient_list.Clear();
            JsonData data = guahao.patient_list();
            int ct = int.Parse(data["data"]["count"].ToString());
            foreach(JsonData person in data["data"]["list"])
            {
                textBox_patient_list.AppendText(person["patientName"].ToString());
                textBox_patient_list.AppendText(Environment.NewLine);
            }
            set_status(ct + "就诊人找到!");
        }
    }
}
