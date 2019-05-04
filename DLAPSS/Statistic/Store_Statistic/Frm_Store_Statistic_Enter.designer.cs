namespace DLAPSS.Statistic.Store_Statistic
{
    partial class Frm_Store_Statistic_Enter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Store_Statistic_Enter));
            this.cl_order_det_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cl_Order_sum_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Order_sum_money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btt_Detailed = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cl_order_det_sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Prot_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtp_End = new System.Windows.Forms.DateTimePicker();
            this.gb_Statistic = new System.Windows.Forms.GroupBox();
            this.dgv_Orders_Details = new System.Windows.Forms.DataGridView();
            this.cl_Order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Order_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_Begin = new System.Windows.Forms.DateTimePicker();
            this.gb_Statistic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orders_Details)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cl_order_det_id
            // 
            this.cl_order_det_id.DataPropertyName = "order_det_id";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_order_det_id.DefaultCellStyle = dataGridViewCellStyle1;
            this.cl_order_det_id.HeaderText = "订单明细ID";
            this.cl_order_det_id.Name = "cl_order_det_id";
            this.cl_order_det_id.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "开始时间：";
            // 
            // cl_Order_sum_total
            // 
            this.cl_Order_sum_total.DataPropertyName = "Order_sum_total";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_Order_sum_total.DefaultCellStyle = dataGridViewCellStyle2;
            this.cl_Order_sum_total.HeaderText = "订单总数量";
            this.cl_Order_sum_total.Name = "cl_Order_sum_total";
            // 
            // cl_UserName
            // 
            this.cl_UserName.DataPropertyName = "UserName";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_UserName.DefaultCellStyle = dataGridViewCellStyle3;
            this.cl_UserName.HeaderText = "操作员";
            this.cl_UserName.Name = "cl_UserName";
            // 
            // cl_Order_sum_money
            // 
            this.cl_Order_sum_money.DataPropertyName = "Order_sum_money";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_Order_sum_money.DefaultCellStyle = dataGridViewCellStyle4;
            this.cl_Order_sum_money.HeaderText = "订单总金额";
            this.cl_Order_sum_money.Name = "cl_Order_sum_money";
            // 
            // btt_Detailed
            // 
            this.btt_Detailed.Location = new System.Drawing.Point(483, 21);
            this.btt_Detailed.Name = "btt_Detailed";
            this.btt_Detailed.Size = new System.Drawing.Size(97, 23);
            this.btt_Detailed.TabIndex = 2;
            this.btt_Detailed.Text = "显示订单表明细";
            this.btt_Detailed.UseVisualStyleBackColor = true;
            this.btt_Detailed.Click += new System.EventHandler(this.btt_Detailed_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "结束时间：";
            // 
            // cl_order_det_sum
            // 
            this.cl_order_det_sum.DataPropertyName = "order_det_sum";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_order_det_sum.DefaultCellStyle = dataGridViewCellStyle5;
            this.cl_order_det_sum.HeaderText = "销售数量";
            this.cl_order_det_sum.Name = "cl_order_det_sum";
            this.cl_order_det_sum.Visible = false;
            // 
            // cl_Prot_name
            // 
            this.cl_Prot_name.DataPropertyName = "Prot_name";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_Prot_name.DefaultCellStyle = dataGridViewCellStyle6;
            this.cl_Prot_name.HeaderText = "商品名称";
            this.cl_Prot_name.Name = "cl_Prot_name";
            this.cl_Prot_name.Visible = false;
            // 
            // dtp_End
            // 
            this.dtp_End.Location = new System.Drawing.Point(321, 22);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.Size = new System.Drawing.Size(150, 21);
            this.dtp_End.TabIndex = 1;
            this.dtp_End.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_End_KeyDown);
            // 
            // gb_Statistic
            // 
            this.gb_Statistic.Controls.Add(this.dgv_Orders_Details);
            this.gb_Statistic.Location = new System.Drawing.Point(3, 68);
            this.gb_Statistic.Name = "gb_Statistic";
            this.gb_Statistic.Size = new System.Drawing.Size(586, 322);
            this.gb_Statistic.TabIndex = 4;
            this.gb_Statistic.TabStop = false;
            this.gb_Statistic.Text = "采购入库订单总表统计数据：";
            // 
            // dgv_Orders_Details
            // 
            this.dgv_Orders_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Orders_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_Order_id,
            this.cl_Order_time,
            this.cl_UserName,
            this.cl_Order_sum_money,
            this.cl_Order_sum_total,
            this.cl_order_det_id,
            this.cl_Prot_name,
            this.cl_order_det_sum});
            this.dgv_Orders_Details.Location = new System.Drawing.Point(6, 20);
            this.dgv_Orders_Details.Name = "dgv_Orders_Details";
            this.dgv_Orders_Details.RowTemplate.Height = 23;
            this.dgv_Orders_Details.Size = new System.Drawing.Size(574, 296);
            this.dgv_Orders_Details.TabIndex = 0;
            // 
            // cl_Order_id
            // 
            this.cl_Order_id.DataPropertyName = "Order_id";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_Order_id.DefaultCellStyle = dataGridViewCellStyle7;
            this.cl_Order_id.HeaderText = "订单总表ID";
            this.cl_Order_id.Name = "cl_Order_id";
            // 
            // cl_Order_time
            // 
            this.cl_Order_time.DataPropertyName = "Order_time";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_Order_time.DefaultCellStyle = dataGridViewCellStyle8;
            this.cl_Order_time.HeaderText = "订单时间";
            this.cl_Order_time.Name = "cl_Order_time";
            this.cl_Order_time.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btt_Detailed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_End);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp_Begin);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 60);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置时间";
            // 
            // dtp_Begin
            // 
            this.dtp_Begin.Location = new System.Drawing.Point(81, 22);
            this.dtp_Begin.Name = "dtp_Begin";
            this.dtp_Begin.Size = new System.Drawing.Size(150, 21);
            this.dtp_Begin.TabIndex = 0;
            this.dtp_Begin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_Begin_KeyDown);
            // 
            // Frm_Store_Statistic_Enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(592, 393);
            this.Controls.Add(this.gb_Statistic);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Store_Statistic_Enter";
            this.Text = "采购入库统计";
            this.Load += new System.EventHandler(this.Frm_Store_Statistic_Enter_Load);
            this.gb_Statistic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orders_Details)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn cl_order_det_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Order_sum_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Order_sum_money;
        private System.Windows.Forms.Button btt_Detailed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_order_det_sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Prot_name;
        private System.Windows.Forms.DateTimePicker dtp_End;
        private System.Windows.Forms.GroupBox gb_Statistic;
        private System.Windows.Forms.DataGridView dgv_Orders_Details;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Order_time;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_Begin;
    }
}