using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_guahao
{
    public partial class Login_Form : Form
    {
        private GuahaoLogin guahaoLogin = null;
        private string key, phone;
        public Login_Form(string key,string phone)
        {
            InitializeComponent();
            guahaoLogin = new GuahaoLogin();
            guahaoLogin.aes_key = key;
            this.key = key;
            this.phone = phone;
        }

        /// <summary>
        /// 显示验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Load(object sender, EventArgs e)
        {
            showImageCode();
            textBox_phone.Text = phone;
        }

        /// <summary>
        /// 获取验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_get_code_Click(object sender, EventArgs e)
        {
            string code = textBox_img_code.Text.Trim();
            if (guahaoLogin.checkCode(code))
            {
                MessageBox.Show("验证码正确");
                if (phone.Length != 11 || phone.StartsWith("1") == false)
                {
                    MessageBox.Show("请输入正确的手机号!");
                    return;
                }
                else
                {
                    string encode_phone = Utils.AESEncrypt(phone, key).Replace("=", "%3D").Replace("+", "-");
                    guahaoLogin.sendSMS(encode_phone, code);
                }
            }
            else
            {
                MessageBox.Show("验证码不对");
                return;
            }


        }

        /// <summary>
        /// 点击刷新图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_login_img_Click(object sender, EventArgs e)
        {
            showImageCode();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_login_Click(object sender, EventArgs e)
        {
            string code = textBox_sms_code.Text.Trim();  //textBox_img_code.Text.Trim(); sms code ! not pic code!

            string encode_phone = Utils.AESEncrypt(phone, key).Replace("+", "-");
            string encode_code= Utils.AESEncrypt(code, key).Replace("+", "-");
            Console.Out.WriteLine(encode_phone + "\n" + encode_code);
            string cookie = guahaoLogin.login(encode_phone, encode_code);
            if (cookie == string.Empty)
            {
                MessageBox.Show("登录失败!");
            }
            else
            {
                MessageBox.Show("登录成功.");
                ((Form_Main)this.Owner).config["cookie"] = cookie;
                this.Close();
            }

        }



        /// <summary>
        /// 重新获取验证码图案
        /// </summary>
        private void showImageCode()
        {
            Image img = guahaoLogin.getImgCode();
            if (img != null)
            {
                pictureBox_login_img.Image = img;
            }
            else
            {
                MessageBox.Show("获取验证码错误！");
            }
        }
    }
}
