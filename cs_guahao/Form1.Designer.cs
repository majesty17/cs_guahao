namespace cs_guahao
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox_hos_detail = new System.Windows.Forms.TextBox();
            this.treeView_dept = new System.Windows.Forms.TreeView();
            this.listView_hos_list = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox_area = new System.Windows.Forms.ComboBox();
            this.comboBox_level = new System.Windows.Forms.ComboBox();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_kw = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listView_patient_list = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_get_patient = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_conf_cookie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_order_list = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1618, 824);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox_hos_detail);
            this.tabPage1.Controls.Add(this.treeView_dept);
            this.tabPage1.Controls.Add(this.listView_hos_list);
            this.tabPage1.Controls.Add(this.comboBox_area);
            this.tabPage1.Controls.Add(this.comboBox_level);
            this.tabPage1.Controls.Add(this.button_search);
            this.tabPage1.Controls.Add(this.textBox_kw);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1610, 795);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "检索";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox_hos_detail
            // 
            this.textBox_hos_detail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_hos_detail.Location = new System.Drawing.Point(839, 37);
            this.textBox_hos_detail.Multiline = true;
            this.textBox_hos_detail.Name = "textBox_hos_detail";
            this.textBox_hos_detail.Size = new System.Drawing.Size(765, 233);
            this.textBox_hos_detail.TabIndex = 11;
            // 
            // treeView_dept
            // 
            this.treeView_dept.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView_dept.Location = new System.Drawing.Point(512, 37);
            this.treeView_dept.Name = "treeView_dept";
            this.treeView_dept.Size = new System.Drawing.Size(321, 752);
            this.treeView_dept.TabIndex = 10;
            this.treeView_dept.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_dept_NodeMouseDoubleClick);
            // 
            // listView_hos_list
            // 
            this.listView_hos_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView_hos_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_hos_list.FullRowSelect = true;
            this.listView_hos_list.GridLines = true;
            this.listView_hos_list.HideSelection = false;
            this.listView_hos_list.Location = new System.Drawing.Point(8, 37);
            this.listView_hos_list.MultiSelect = false;
            this.listView_hos_list.Name = "listView_hos_list";
            this.listView_hos_list.Size = new System.Drawing.Size(498, 752);
            this.listView_hos_list.TabIndex = 9;
            this.listView_hos_list.UseCompatibleStateImageBehavior = false;
            this.listView_hos_list.View = System.Windows.Forms.View.Details;
            this.listView_hos_list.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_hos_list_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "等级";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "放号时间";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "名称";
            this.columnHeader3.Width = 220;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "code";
            this.columnHeader4.Width = 80;
            // 
            // comboBox_area
            // 
            this.comboBox_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_area.FormattingEnabled = true;
            this.comboBox_area.Items.AddRange(new object[] {
            "全部-0",
            "东城区-110101",
            "西城区-110102",
            "朝阳区-110105",
            "丰台区-110106",
            "石景山区-110107",
            "海淀区-110108",
            "门头沟区-110109",
            "房山区-110111",
            "通州区-110112",
            "顺义区-110113",
            "昌平区-110114",
            "大兴区-110115",
            "怀柔区-110116",
            "平谷区-110117",
            "密云区-110118",
            "延庆区-110119"});
            this.comboBox_area.Location = new System.Drawing.Point(278, 6);
            this.comboBox_area.Name = "comboBox_area";
            this.comboBox_area.Size = new System.Drawing.Size(121, 23);
            this.comboBox_area.TabIndex = 8;
            // 
            // comboBox_level
            // 
            this.comboBox_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_level.FormattingEnabled = true;
            this.comboBox_level.Items.AddRange(new object[] {
            "全部-0",
            "三级医院-3",
            "二级医院-2",
            "一级医院-1"});
            this.comboBox_level.Location = new System.Drawing.Point(151, 6);
            this.comboBox_level.Name = "comboBox_level";
            this.comboBox_level.Size = new System.Drawing.Size(121, 23);
            this.comboBox_level.TabIndex = 7;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(405, 6);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(101, 25);
            this.button_search.TabIndex = 6;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_kw
            // 
            this.textBox_kw.Location = new System.Drawing.Point(8, 6);
            this.textBox_kw.Name = "textBox_kw";
            this.textBox_kw.Size = new System.Drawing.Size(137, 25);
            this.textBox_kw.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1610, 795);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "挂号";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listView_order_list);
            this.tabPage3.Controls.Add(this.listView_patient_list);
            this.tabPage3.Controls.Add(this.button_get_patient);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1610, 795);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "就诊人信息";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listView_patient_list
            // 
            this.listView_patient_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView_patient_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView_patient_list.FullRowSelect = true;
            this.listView_patient_list.GridLines = true;
            this.listView_patient_list.HideSelection = false;
            this.listView_patient_list.Location = new System.Drawing.Point(8, 47);
            this.listView_patient_list.MultiSelect = false;
            this.listView_patient_list.Name = "listView_patient_list";
            this.listView_patient_list.Size = new System.Drawing.Size(407, 745);
            this.listView_patient_list.TabIndex = 2;
            this.listView_patient_list.UseCompatibleStateImageBehavior = false;
            this.listView_patient_list.View = System.Windows.Forms.View.Details;
            this.listView_patient_list.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_patient_list_ItemSelectionChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "姓名";
            this.columnHeader5.Width = 65;
            // 
            // button_get_patient
            // 
            this.button_get_patient.Location = new System.Drawing.Point(8, 3);
            this.button_get_patient.Name = "button_get_patient";
            this.button_get_patient.Size = new System.Drawing.Size(91, 38);
            this.button_get_patient.TabIndex = 0;
            this.button_get_patient.Text = "刷新";
            this.button_get_patient.UseVisualStyleBackColor = true;
            this.button_get_patient.Click += new System.EventHandler(this.button_get_patient_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel2);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1610, 795);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "设置";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox_conf_cookie, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1610, 795);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(720, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "网页版找cmi-user-ticket=的值";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(185, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(528, 25);
            this.textBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cookie";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_conf_cookie
            // 
            this.textBox_conf_cookie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_conf_cookie.Location = new System.Drawing.Point(185, 4);
            this.textBox_conf_cookie.Name = "textBox_conf_cookie";
            this.textBox_conf_cookie.Size = new System.Drawing.Size(528, 25);
            this.textBox_conf_cookie.TabIndex = 2;
            this.textBox_conf_cookie.TextChanged += new System.EventHandler(this.textBox_conf_cookie_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cookie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 827);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1618, 25);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(167, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "证件类型";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "证件id";
            this.columnHeader7.Width = 150;
            // 
            // listView_order_list
            // 
            this.listView_order_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_order_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.listView_order_list.FullRowSelect = true;
            this.listView_order_list.GridLines = true;
            this.listView_order_list.HideSelection = false;
            this.listView_order_list.Location = new System.Drawing.Point(421, 47);
            this.listView_order_list.Name = "listView_order_list";
            this.listView_order_list.Size = new System.Drawing.Size(1181, 745);
            this.listView_order_list.TabIndex = 3;
            this.listView_order_list.UseCompatibleStateImageBehavior = false;
            this.listView_order_list.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "就诊时间";
            this.columnHeader11.Width = 220;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "医院";
            this.columnHeader12.Width = 260;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "科室";
            this.columnHeader13.Width = 120;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "医生";
            this.columnHeader14.Width = 100;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "服务费";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "订单状态";
            this.columnHeader16.Width = 90;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 852);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBox_area;
        private System.Windows.Forms.ComboBox comboBox_level;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_kw;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TreeView treeView_dept;
        private System.Windows.Forms.TextBox textBox_hos_detail;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button_get_patient;
        private System.Windows.Forms.ListView listView_hos_list;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox_conf_cookie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView_patient_list;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView listView_order_list;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
    }
}

