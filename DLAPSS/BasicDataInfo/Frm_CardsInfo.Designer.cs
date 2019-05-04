namespace DLAPSS.BasicDataInfo
{
    partial class Frm_CardsInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CardsInfo));
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
            this.dgv_Cards = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Cards_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Cards_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cl_Cards_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Cards_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cards)).BeginInit();
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
            this.toolStrip1.TabIndex = 3;
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
            this.groupBox2.Controls.Add(this.dgv_Cards);
            this.groupBox2.Location = new System.Drawing.Point(0, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(592, 244);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "商品详细信息列表";
            // 
            // dgv_Cards
            // 
            this.dgv_Cards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_Cards_id,
            this.cl_Cards_name});
            this.dgv_Cards.Location = new System.Drawing.Point(6, 20);
            this.dgv_Cards.MultiSelect = false;
            this.dgv_Cards.Name = "dgv_Cards";
            this.dgv_Cards.ReadOnly = true;
            this.dgv_Cards.RowTemplate.Height = 23;
            this.dgv_Cards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Cards.Size = new System.Drawing.Size(580, 218);
            this.dgv_Cards.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Cards_Name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Cards_Id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 114);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "品牌信息";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "2.商品名使用全称";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "1.商品ID自动生成，无法修改";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "注意事项：";
            // 
            // txt_Cards_Name
            // 
            this.txt_Cards_Name.Location = new System.Drawing.Point(254, 21);
            this.txt_Cards_Name.Name = "txt_Cards_Name";
            this.txt_Cards_Name.Size = new System.Drawing.Size(100, 21);
            this.txt_Cards_Name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "品牌名：";
            // 
            // txt_Cards_Id
            // 
            this.txt_Cards_Id.Enabled = false;
            this.txt_Cards_Id.Location = new System.Drawing.Point(83, 21);
            this.txt_Cards_Id.Name = "txt_Cards_Id";
            this.txt_Cards_Id.Size = new System.Drawing.Size(100, 21);
            this.txt_Cards_Id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "品牌编号：";
            // 
            // cl_Cards_id
            // 
            this.cl_Cards_id.DataPropertyName = "Cardsid";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_Cards_id.DefaultCellStyle = dataGridViewCellStyle1;
            this.cl_Cards_id.HeaderText = "商品ID";
            this.cl_Cards_id.Name = "cl_Cards_id";
            this.cl_Cards_id.ReadOnly = true;
            // 
            // cl_Cards_name
            // 
            this.cl_Cards_name.DataPropertyName = "Cardsname";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_Cards_name.DefaultCellStyle = dataGridViewCellStyle2;
            this.cl_Cards_name.HeaderText = "品牌名";
            this.cl_Cards_name.Name = "cl_Cards_name";
            this.cl_Cards_name.ReadOnly = true;
            // 
            // Frm_CardsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(592, 393);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_CardsInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "品牌资料维护";
            this.Load += new System.EventHandler(this.Frm_CardsInfo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cards)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_Cards;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Cards_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Cards_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tsb_Btn_Exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Cards_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Cards_name;
    }
}