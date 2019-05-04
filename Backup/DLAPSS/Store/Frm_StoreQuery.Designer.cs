namespace DLAPSS.Store
{
    partial class Frm_StoreQuery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_StoreQuery));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Store = new System.Windows.Forms.DataGridView();
            this.cl_Prot_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Prot_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_store_sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_store_lastNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Prot_retailprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Prot_tradeprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Prot_Bigunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Prot_smallunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_prot_rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Cards_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Priv_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Prot_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_Btn_Amend = new System.Windows.Forms.ToolStripButton();
            this.tsb_Btn_Delete = new System.Windows.Forms.ToolStripButton();
            this.tsb_Btn_Cancel = new System.Windows.Forms.ToolStripButton();
            this.tsb_Txt_Lookup = new System.Windows.Forms.ToolStripTextBox();
            this.tsb_Btn_Lookup = new System.Windows.Forms.ToolStripButton();
            this.tsb_Btn_Exit = new System.Windows.Forms.ToolStripButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Store)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Store);
            this.groupBox2.Location = new System.Drawing.Point(0, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(677, 363);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "商品库存资料详细列表";
            // 
            // dgv_Store
            // 
            this.dgv_Store.AllowUserToAddRows = false;
            this.dgv_Store.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Store.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_Prot_id,
            this.cl_Prot_name,
            this.cl_store_sum,
            this.cl_store_lastNum,
            this.cl_Prot_retailprice,
            this.cl_Prot_tradeprice,
            this.cl_Prot_Bigunit,
            this.cl_Prot_smallunit,
            this.cl_prot_rate,
            this.cl_Cards_name,
            this.cl_Priv_name,
            this.cl_Prot_date});
            this.dgv_Store.Location = new System.Drawing.Point(6, 20);
            this.dgv_Store.MultiSelect = false;
            this.dgv_Store.Name = "dgv_Store";
            this.dgv_Store.ReadOnly = true;
            this.dgv_Store.RowTemplate.Height = 23;
            this.dgv_Store.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Store.Size = new System.Drawing.Size(665, 337);
            this.dgv_Store.TabIndex = 0;
            this.dgv_Store.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_Store_KeyDown);
            // 
            // cl_Prot_id
            // 
            this.cl_Prot_id.DataPropertyName = "Prot_id";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_Prot_id.DefaultCellStyle = dataGridViewCellStyle1;
            this.cl_Prot_id.HeaderText = "商品ID";
            this.cl_Prot_id.Name = "cl_Prot_id";
            this.cl_Prot_id.ReadOnly = true;
            // 
            // cl_Prot_name
            // 
            this.cl_Prot_name.DataPropertyName = "Prot_name";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_Prot_name.DefaultCellStyle = dataGridViewCellStyle2;
            this.cl_Prot_name.HeaderText = "商品名称";
            this.cl_Prot_name.Name = "cl_Prot_name";
            this.cl_Prot_name.ReadOnly = true;
            // 
            // cl_store_sum
            // 
            this.cl_store_sum.DataPropertyName = "store_sum";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_store_sum.DefaultCellStyle = dataGridViewCellStyle3;
            this.cl_store_sum.HeaderText = "库存数量";
            this.cl_store_sum.Name = "cl_store_sum";
            this.cl_store_sum.ReadOnly = true;
            // 
            // cl_store_lastNum
            // 
            this.cl_store_lastNum.DataPropertyName = "store_lastNum";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_store_lastNum.DefaultCellStyle = dataGridViewCellStyle4;
            this.cl_store_lastNum.HeaderText = "商品库存下限";
            this.cl_store_lastNum.Name = "cl_store_lastNum";
            this.cl_store_lastNum.ReadOnly = true;
            this.cl_store_lastNum.Width = 110;
            // 
            // cl_Prot_retailprice
            // 
            this.cl_Prot_retailprice.DataPropertyName = "Prot_retailprice";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_Prot_retailprice.DefaultCellStyle = dataGridViewCellStyle5;
            this.cl_Prot_retailprice.HeaderText = "零售价格";
            this.cl_Prot_retailprice.Name = "cl_Prot_retailprice";
            this.cl_Prot_retailprice.ReadOnly = true;
            // 
            // cl_Prot_tradeprice
            // 
            this.cl_Prot_tradeprice.DataPropertyName = "Prot_tradeprice";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_Prot_tradeprice.DefaultCellStyle = dataGridViewCellStyle6;
            this.cl_Prot_tradeprice.HeaderText = "批发价";
            this.cl_Prot_tradeprice.Name = "cl_Prot_tradeprice";
            this.cl_Prot_tradeprice.ReadOnly = true;
            // 
            // cl_Prot_Bigunit
            // 
            this.cl_Prot_Bigunit.DataPropertyName = "Prot_Bigunit";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_Prot_Bigunit.DefaultCellStyle = dataGridViewCellStyle7;
            this.cl_Prot_Bigunit.HeaderText = "大包装";
            this.cl_Prot_Bigunit.Name = "cl_Prot_Bigunit";
            this.cl_Prot_Bigunit.ReadOnly = true;
            // 
            // cl_Prot_smallunit
            // 
            this.cl_Prot_smallunit.DataPropertyName = "Prot_smallunit";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_Prot_smallunit.DefaultCellStyle = dataGridViewCellStyle8;
            this.cl_Prot_smallunit.HeaderText = "小包装";
            this.cl_Prot_smallunit.Name = "cl_Prot_smallunit";
            this.cl_Prot_smallunit.ReadOnly = true;
            // 
            // cl_prot_rate
            // 
            this.cl_prot_rate.DataPropertyName = "prot_rate";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_prot_rate.DefaultCellStyle = dataGridViewCellStyle9;
            this.cl_prot_rate.HeaderText = "倍率";
            this.cl_prot_rate.Name = "cl_prot_rate";
            this.cl_prot_rate.ReadOnly = true;
            // 
            // cl_Cards_name
            // 
            this.cl_Cards_name.DataPropertyName = "Cards_name";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_Cards_name.DefaultCellStyle = dataGridViewCellStyle10;
            this.cl_Cards_name.HeaderText = "品牌";
            this.cl_Cards_name.Name = "cl_Cards_name";
            this.cl_Cards_name.ReadOnly = true;
            // 
            // cl_Priv_name
            // 
            this.cl_Priv_name.DataPropertyName = "Priv_name";
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_Priv_name.DefaultCellStyle = dataGridViewCellStyle11;
            this.cl_Priv_name.HeaderText = "供应商";
            this.cl_Priv_name.Name = "cl_Priv_name";
            this.cl_Priv_name.ReadOnly = true;
            // 
            // cl_Prot_date
            // 
            this.cl_Prot_date.DataPropertyName = "Prot_date";
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_Prot_date.DefaultCellStyle = dataGridViewCellStyle12;
            this.cl_Prot_date.HeaderText = "生产日期";
            this.cl_Prot_date.Name = "cl_Prot_date";
            this.cl_Prot_date.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = global::DLAPSS.Properties.Resources.bg_Navigate;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Btn_Amend,
            this.tsb_Btn_Delete,
            this.tsb_Btn_Cancel,
            this.tsb_Txt_Lookup,
            this.tsb_Btn_Lookup,
            this.tsb_Btn_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(677, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
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
            // 
            // tsb_Txt_Lookup
            // 
            this.tsb_Txt_Lookup.Name = "tsb_Txt_Lookup";
            this.tsb_Txt_Lookup.Size = new System.Drawing.Size(150, 25);
            this.tsb_Txt_Lookup.ToolTipText = "请使用商品名称模糊查询";
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
            // Frm_StoreQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(677, 393);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_StoreQuery";
            this.Text = "库存查询";
            this.Load += new System.EventHandler(this.Frm_StoreQuery_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Store)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_Store;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Prot_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Prot_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_store_sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_store_lastNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Prot_retailprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Prot_tradeprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Prot_Bigunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Prot_smallunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_prot_rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Cards_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Priv_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Prot_date;
        private System.Windows.Forms.ToolStripButton tsb_Btn_Amend;
        private System.Windows.Forms.ToolStripButton tsb_Btn_Delete;
        private System.Windows.Forms.ToolStripTextBox tsb_Txt_Lookup;
        private System.Windows.Forms.ToolStripButton tsb_Btn_Lookup;
        private System.Windows.Forms.ToolStripButton tsb_Btn_Cancel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_Btn_Exit;
    }
}