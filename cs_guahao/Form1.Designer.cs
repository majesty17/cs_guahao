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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.treeView_dept = new System.Windows.Forms.TreeView();
            this.textBox_hos_detail = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1252, 663);
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
            this.tabPage1.Size = new System.Drawing.Size(1244, 634);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "检索";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView_hos_list
            // 
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
            this.listView_hos_list.Size = new System.Drawing.Size(498, 591);
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
            this.tabPage2.Size = new System.Drawing.Size(1020, 543);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 666);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1252, 25);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(167, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // treeView_dept
            // 
            this.treeView_dept.Location = new System.Drawing.Point(848, 37);
            this.treeView_dept.Name = "treeView_dept";
            this.treeView_dept.Size = new System.Drawing.Size(388, 591);
            this.treeView_dept.TabIndex = 10;
            // 
            // textBox_hos_detail
            // 
            this.textBox_hos_detail.Location = new System.Drawing.Point(512, 37);
            this.textBox_hos_detail.Multiline = true;
            this.textBox_hos_detail.Name = "textBox_hos_detail";
            this.textBox_hos_detail.Size = new System.Drawing.Size(330, 591);
            this.textBox_hos_detail.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 691);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.ListView listView_hos_list;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TreeView treeView_dept;
        private System.Windows.Forms.TextBox textBox_hos_detail;
    }
}

