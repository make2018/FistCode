namespace DLAPSS.BasicDataInfo
{
    partial class Frm_ProvidersInfo
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ProvidersInfo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_Btn_Add = new System.Windows.Forms.ToolStripButton();
            this.tsb_Btn_Amend = new System.Windows.Forms.ToolStripButton();
            this.tsb_Btn_Save = new System.Windows.Forms.ToolStripButton();
            this.tsb_Btn_Delete = new System.Windows.Forms.ToolStripButton();
            this.tsb_Btn_Cancel = new System.Windows.Forms.ToolStripButton();
            this.tsb_Txt_Lookup = new System.Windows.Forms.ToolStripTextBox();
            this.tsb_Btn_Lookup = new System.Windows.Forms.ToolStripButton();
            this.tsb_Btn_Exit = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Providers = new System.Windows.Forms.DataGridView();
            this.cl_Priv_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Priv_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Priv_linkMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Priv_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Priv_adr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_Priv_id = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Priv_tel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Priv_linkMan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Priv_adr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Priv_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Providers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = global::DLAPSS.Properties.Resources.bg_Navigate;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Btn_Add,
            this.tsb_Btn_Amend,
            this.tsb_Btn_Save,
            this.tsb_Btn_Delete,
            this.tsb_Btn_Cancel,
            this.tsb_Txt_Lookup,
            this.tsb_Btn_Lookup,
            this.tsb_Btn_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(592, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_Btn_Add
            // 
            this.tsb_Btn_Add.Image = global::DLAPSS.Properties.Resources.add;
            this.tsb_Btn_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Btn_Add.Name = "tsb_Btn_Add";
            this.tsb_Btn_Add.Size = new System.Drawing.Size(67, 22);
            this.tsb_Btn_Add.Text = "添加(&A)";
            this.tsb_Btn_Add.Click += new System.EventHandler(this.tsb_Btn_Add_Click);
            // 
            // tsb_Btn_Amend
            // 
            this.tsb_Btn_Amend.Image = global::DLAPSS.Properties.Resources.change;
            this.tsb_Btn_Amend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Btn_Amend.Name = "tsb_Btn_Amend";
            this.tsb_Btn_Amend.Size = new System.Drawing.Size(67, 22);
            this.tsb_Btn_Amend.Text = "修改(&C)";
            this.tsb_Btn_Amend.Click += new System.EventHandler(this.tsb_Btn_Amend_Click);
            // 
            // tsb_Btn_Save
            // 
            this.tsb_Btn_Save.Image = global::DLAPSS.Properties.Resources.save;
            this.tsb_Btn_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Btn_Save.Name = "tsb_Btn_Save";
            this.tsb_Btn_Save.Size = new System.Drawing.Size(67, 22);
            this.tsb_Btn_Save.Text = "保存(&S)";
            this.tsb_Btn_Save.Click += new System.EventHandler(this.tsb_Btn_Save_Click);
            // 
            // tsb_Btn_Delete
            // 
            this.tsb_Btn_Delete.Image = global::DLAPSS.Properties.Resources.delete;
            this.tsb_Btn_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Btn_Delete.Name = "tsb_Btn_Delete";
            this.tsb_Btn_Delete.Size = new System.Drawing.Size(67, 22);
            this.tsb_Btn_Delete.Text = "删除(&D)";
            this.tsb_Btn_Delete.Click += new System.EventHandler(this.tsb_Btn_Delete_Click);
            // 
            // tsb_Btn_Cancel
            // 
            this.tsb_Btn_Cancel.Image = global::DLAPSS.Properties.Resources.cancel;
            this.tsb_Btn_Cancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Btn_Cancel.Name = "tsb_Btn_Cancel";
            this.tsb_Btn_Cancel.Size = new System.Drawing.Size(67, 22);
            this.tsb_Btn_Cancel.Text = "取消(&Q)";
            this.tsb_Btn_Cancel.Click += new System.EventHandler(this.tsb_Btn_Cancel_Click);
            // 
            // tsb_Txt_Lookup
            // 
            this.tsb_Txt_Lookup.Name = "tsb_Txt_Lookup";
            this.tsb_Txt_Lookup.Size = new System.Drawing.Size(110, 25);
            this.tsb_Txt_Lookup.ToolTipText = "请使用登陆ID或者姓名模糊查询";
            // 
            // tsb_Btn_Lookup
            // 
            this.tsb_Btn_Lookup.Image = global::DLAPSS.Properties.Resources.btnfind;
            this.tsb_Btn_Lookup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Btn_Lookup.Name = "tsb_Btn_Lookup";
            this.tsb_Btn_Lookup.Size = new System.Drawing.Size(49, 22);
            this.tsb_Btn_Lookup.Text = "查询";
            this.tsb_Btn_Lookup.ToolTipText = "请使用登陆ID或是真实姓名进行查找";
            this.tsb_Btn_Lookup.Click += new System.EventHandler(this.tsb_Btn_Lookup_Click);
            // 
            // tsb_Btn_Exit
            // 
            this.tsb_Btn_Exit.Image = global::DLAPSS.Properties.Resources.stop;
            this.tsb_Btn_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Btn_Exit.Name = "tsb_Btn_Exit";
            this.tsb_Btn_Exit.Size = new System.Drawing.Size(67, 22);
            this.tsb_Btn_Exit.Text = "退出(&E)";
            this.tsb_Btn_Exit.Click += new System.EventHandler(this.tsb_Btn_Exit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Providers);
            this.groupBox2.Location = new System.Drawing.Point(0, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(592, 222);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "供应商资料详细列表";
            // 
            // dgv_Providers
            // 
            this.dgv_Providers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Providers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Providers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_Priv_id,
            this.cl_Priv_name,
            this.cl_Priv_linkMan,
            this.cl_Priv_tel,
            this.cl_Priv_adr});
            this.dgv_Providers.Location = new System.Drawing.Point(6, 20);
            this.dgv_Providers.MultiSelect = false;
            this.dgv_Providers.Name = "dgv_Providers";
            this.dgv_Providers.ReadOnly = true;
            this.dgv_Providers.RowTemplate.Height = 23;
            this.dgv_Providers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Providers.Size = new System.Drawing.Size(580, 196);
            this.dgv_Providers.TabIndex = 0;
            // 
            // cl_Priv_id
            // 
            this.cl_Priv_id.DataPropertyName = "Priv_id";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_Priv_id.DefaultCellStyle = dataGridViewCellStyle1;
            this.cl_Priv_id.HeaderText = "供应商ID";
            this.cl_Priv_id.Name = "cl_Priv_id";
            this.cl_Priv_id.ReadOnly = true;
            // 
            // cl_Priv_name
            // 
            this.cl_Priv_name.DataPropertyName = "Priv_name";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_Priv_name.DefaultCellStyle = dataGridViewCellStyle2;
            this.cl_Priv_name.HeaderText = "厂家名称";
            this.cl_Priv_name.Name = "cl_Priv_name";
            this.cl_Priv_name.ReadOnly = true;
            // 
            // cl_Priv_linkMan
            // 
            this.cl_Priv_linkMan.DataPropertyName = "Priv_linkMan";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_Priv_linkMan.DefaultCellStyle = dataGridViewCellStyle3;
            this.cl_Priv_linkMan.HeaderText = "联系人";
            this.cl_Priv_linkMan.Name = "cl_Priv_linkMan";
            this.cl_Priv_linkMan.ReadOnly = true;
            // 
            // cl_Priv_tel
            // 
            this.cl_Priv_tel.DataPropertyName = "Priv_tel";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_Priv_tel.DefaultCellStyle = dataGridViewCellStyle4;
            this.cl_Priv_tel.HeaderText = "电话";
            this.cl_Priv_tel.Name = "cl_Priv_tel";
            this.cl_Priv_tel.ReadOnly = true;
            // 
            // cl_Priv_adr
            // 
            this.cl_Priv_adr.DataPropertyName = "Priv_adr";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_Priv_adr.DefaultCellStyle = dataGridViewCellStyle5;
            this.cl_Priv_adr.HeaderText = "地址";
            this.cl_Priv_adr.Name = "cl_Priv_adr";
            this.cl_Priv_adr.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_Priv_id);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Priv_tel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Priv_linkMan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Priv_adr);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Priv_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 136);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "供应商基本信息";
            // 
            // lb_Priv_id
            // 
            this.lb_Priv_id.AutoSize = true;
            this.lb_Priv_id.Location = new System.Drawing.Point(450, 91);
            this.lb_Priv_id.Name = "lb_Priv_id";
            this.lb_Priv_id.Size = new System.Drawing.Size(11, 12);
            this.lb_Priv_id.TabIndex = 12;
            this.lb_Priv_id.Text = "0";
            this.lb_Priv_id.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "2.供应商ID自动生成";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "1.厂家名称，地址必填，厂家名称不能重复";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "注意事项：";
            // 
            // txt_Priv_tel
            // 
            this.txt_Priv_tel.Location = new System.Drawing.Point(438, 18);
            this.txt_Priv_tel.Name = "txt_Priv_tel";
            this.txt_Priv_tel.Size = new System.Drawing.Size(100, 21);
            this.txt_Priv_tel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "电话";
            // 
            // txt_Priv_linkMan
            // 
            this.txt_Priv_linkMan.Location = new System.Drawing.Point(267, 18);
            this.txt_Priv_linkMan.Name = "txt_Priv_linkMan";
            this.txt_Priv_linkMan.Size = new System.Drawing.Size(100, 21);
            this.txt_Priv_linkMan.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "联系人";
            // 
            // txt_Priv_adr
            // 
            this.txt_Priv_adr.Location = new System.Drawing.Point(92, 52);
            this.txt_Priv_adr.Name = "txt_Priv_adr";
            this.txt_Priv_adr.Size = new System.Drawing.Size(446, 21);
            this.txt_Priv_adr.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "地址";
            // 
            // txt_Priv_name
            // 
            this.txt_Priv_name.Location = new System.Drawing.Point(92, 18);
            this.txt_Priv_name.Name = "txt_Priv_name";
            this.txt_Priv_name.Size = new System.Drawing.Size(100, 21);
            this.txt_Priv_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "厂家名称";
            // 
            // Frm_ProvidersInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(592, 393);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_ProvidersInfo";
            this.Text = "供应商资料维护";
            this.Load += new System.EventHandler(this.Frm_ProvidersInfo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Providers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_Btn_Add;
        private System.Windows.Forms.ToolStripButton tsb_Btn_Amend;
        private System.Windows.Forms.ToolStripButton tsb_Btn_Save;
        private System.Windows.Forms.ToolStripButton tsb_Btn_Delete;
        private System.Windows.Forms.ToolStripButton tsb_Btn_Cancel;
        private System.Windows.Forms.ToolStripTextBox tsb_Txt_Lookup;
        private System.Windows.Forms.ToolStripButton tsb_Btn_Lookup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_Providers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_Priv_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Priv_tel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Priv_linkMan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Priv_adr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Priv_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Priv_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Priv_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Priv_linkMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Priv_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Priv_adr;
        private System.Windows.Forms.ToolStripButton tsb_Btn_Exit;
    }
}