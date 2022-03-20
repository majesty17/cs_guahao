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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Image img = GuahaoAPI.getImgCode();
            if (img != null)
            {
                pictureBox_login_img.Image = img;
            }
        }

        /// <summary>
        /// 获取验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_get_code_Click(object sender, EventArgs e)
        {
            string phone = textBox_phone.Text.Trim();
            if(phone.Length!= 11 || phone.StartsWith("1") == false)
            {
                MessageBox.Show("请输入正确的手机号!");
                return;
            }

        }
    }
}
