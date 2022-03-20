namespace cs_guahao
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_login_img = new System.Windows.Forms.PictureBox();
            this.textBox_img_code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.button_get_code = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_login_img)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_login_img
            // 
            this.pictureBox_login_img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_login_img.Location = new System.Drawing.Point(110, 42);
            this.pictureBox_login_img.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_login_img.Name = "pictureBox_login_img";
            this.pictureBox_login_img.Size = new System.Drawing.Size(94, 28);
            this.pictureBox_login_img.TabIndex = 0;
            this.pictureBox_login_img.TabStop = false;
            // 
            // textBox_img_code
            // 
            this.textBox_img_code.Location = new System.Drawing.Point(52, 49);
            this.textBox_img_code.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_img_code.Name = "textBox_img_code";
            this.textBox_img_code.Size = new System.Drawing.Size(54, 21);
            this.textBox_img_code.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "手机号";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(52, 10);
            this.textBox_phone.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(112, 21);
            this.textBox_phone.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "验证码";
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(52, 86);
            this.button_login.Margin = new System.Windows.Forms.Padding(2);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(161, 46);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "登录";
            this.button_login.UseVisualStyleBackColor = true;
            // 
            // button_get_code
            // 
            this.button_get_code.Location = new System.Drawing.Point(208, 44);
            this.button_get_code.Margin = new System.Windows.Forms.Padding(2);
            this.button_get_code.Name = "button_get_code";
            this.button_get_code.Size = new System.Drawing.Size(75, 26);
            this.button_get_code.TabIndex = 6;
            this.button_get_code.Text = "获取验证码";
            this.button_get_code.UseVisualStyleBackColor = true;
            this.button_get_code.Click += new System.EventHandler(this.button_get_code_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 143);
            this.Controls.Add(this.button_get_code);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_img_code);
            this.Controls.Add(this.pictureBox_login_img);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_login_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_login_img;
        private System.Windows.Forms.TextBox textBox_img_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_get_code;
    }
}