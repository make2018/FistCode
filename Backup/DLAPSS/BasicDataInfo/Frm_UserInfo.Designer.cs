namespace DLAPSS.BasicDataInfo
{
    partial class Frm_UserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_UserInfo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_Btn_Add = new System.Windows.Forms.ToolStripButton();
            this.tsb_Btn_Amend = new System.Windows.Forms.ToolStripButton();
            this.tsb_Btn_Save = new System.Windows.Forms.ToolStripButton();
            this.tsb_Btn_Delete = new System.Windows.Forms.ToolStripButton();
            this.tsb_Btn_Cancel = new System.Windows.Forms.ToolStripButton();
            this.tsb_Txt_Lookup = new System.Windows.Forms.ToolStripTextBox();
            this.tsb_Btn_Lookup = new System.Windows.Forms.ToolStripButton();
            this.tsb_Btn_Exit = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_UserPass1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_UserPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UserloginId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_UserInfo = new System.Windows.Forms.DataGridView();
            this.cl_UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_UserloginId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_UserPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_UserRole_Nmae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_baseInfo = new System.Windows.Forms.Panel();
            this.rdo_buyUser = new System.Windows.Forms.RadioButton();
            this.rdo_sellUser = new System.Windows.Forms.RadioButton();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserInfo)).BeginInit();
            this.pnl_baseInfo.SuspendLayout();
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
            this.toolStrip1.TabIndex = 1;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(0, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 147);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作员基本资料";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(40, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "1.登录ID注册后无法修改";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "注意事项：";
            // 
            // txt_UserPass1
            // 
            this.txt_UserPass1.Location = new System.Drawing.Point(285, 43);
            this.txt_UserPass1.MaxLength = 16;
            this.txt_UserPass1.Name = "txt_UserPass1";
            this.txt_UserPass1.PasswordChar = '*';
            this.txt_UserPass1.Size = new System.Drawing.Size(103, 21);
            this.txt_UserPass1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "确认密码";
            // 
            // txt_UserPass
            // 
            this.txt_UserPass.Location = new System.Drawing.Point(79, 39);
            this.txt_UserPass.MaxLength = 16;
            this.txt_UserPass.Name = "txt_UserPass";
            this.txt_UserPass.PasswordChar = '*';
            this.txt_UserPass.Size = new System.Drawing.Size(114, 21);
            this.txt_UserPass.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "密  码";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(285, 14);
            this.txt_UserName.MaxLength = 14;
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(103, 21);
            this.txt_UserName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "真实姓名";
            // 
            // txt_UserloginId
            // 
            this.txt_UserloginId.Location = new System.Drawing.Point(79, 11);
            this.txt_UserloginId.MaxLength = 16;
            this.txt_UserloginId.Name = "txt_UserloginId";
            this.txt_UserloginId.Size = new System.Drawing.Size(114, 21);
            this.txt_UserloginId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "登陆ID";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgv_UserInfo);
            this.groupBox2.Location = new System.Drawing.Point(0, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(592, 209);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "管理员资料详细列表";
            // 
            // dgv_UserInfo
            // 
            this.dgv_UserInfo.AllowUserToAddRows = false;
            this.dgv_UserInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_UserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UserInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_UserId,
            this.cl_UserloginId,
            this.cl_UserName,
            this.cl_UserPass,
            this.cl_UserRole_Nmae,
            this.userRole});
            this.dgv_UserInfo.Location = new System.Drawing.Point(6, 20);
            this.dgv_UserInfo.MultiSelect = false;
            this.dgv_UserInfo.Name = "dgv_UserInfo";
            this.dgv_UserInfo.ReadOnly = true;
            this.dgv_UserInfo.RowTemplate.Height = 23;
            this.dgv_UserInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_UserInfo.Size = new System.Drawing.Size(580, 180);
            this.dgv_UserInfo.TabIndex = 0;
            // 
            // cl_UserId
            // 
            this.cl_UserId.DataPropertyName = "UserId";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_UserId.DefaultCellStyle = dataGridViewCellStyle1;
            this.cl_UserId.HeaderText = "ID";
            this.cl_UserId.Name = "cl_UserId";
            this.cl_UserId.ReadOnly = true;
            // 
            // cl_UserloginId
            // 
            this.cl_UserloginId.DataPropertyName = "UserloginId";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_UserloginId.DefaultCellStyle = dataGridViewCellStyle2;
            this.cl_UserloginId.HeaderText = "登陆ID";
            this.cl_UserloginId.Name = "cl_UserloginId";
            this.cl_UserloginId.ReadOnly = true;
            // 
            // cl_UserName
            // 
            this.cl_UserName.DataPropertyName = "UserName";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_UserName.DefaultCellStyle = dataGridViewCellStyle3;
            this.cl_UserName.HeaderText = "真实姓名";
            this.cl_UserName.Name = "cl_UserName";
            this.cl_UserName.ReadOnly = true;
            // 
            // cl_UserPass
            // 
            this.cl_UserPass.DataPropertyName = "UserPass";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_UserPass.DefaultCellStyle = dataGridViewCellStyle4;
            this.cl_UserPass.HeaderText = "密码";
            this.cl_UserPass.Name = "cl_UserPass";
            this.cl_UserPass.ReadOnly = true;
            // 
            // cl_UserRole_Nmae
            // 
            this.cl_UserRole_Nmae.DataPropertyName = "UserType";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cl_UserRole_Nmae.DefaultCellStyle = dataGridViewCellStyle5;
            this.cl_UserRole_Nmae.HeaderText = "权限";
            this.cl_UserRole_Nmae.Name = "cl_UserRole_Nmae";
            this.cl_UserRole_Nmae.ReadOnly = true;
            // 
            // userRole
            // 
            this.userRole.DataPropertyName = "UserRole";
            this.userRole.HeaderText = "Column1";
            this.userRole.Name = "userRole";
            this.userRole.ReadOnly = true;
            this.userRole.Visible = false;
            // 
            // pnl_baseInfo
            // 
            this.pnl_baseInfo.Controls.Add(this.rdo_buyUser);
            this.pnl_baseInfo.Controls.Add(this.rdo_sellUser);
            this.pnl_baseInfo.Controls.Add(this.txt_UserloginId);
            this.pnl_baseInfo.Controls.Add(this.label1);
            this.pnl_baseInfo.Controls.Add(this.txt_UserPass);
            this.pnl_baseInfo.Controls.Add(this.label3);
            this.pnl_baseInfo.Controls.Add(this.label2);
            this.pnl_baseInfo.Controls.Add(this.txt_UserPass1);
            this.pnl_baseInfo.Controls.Add(this.txt_UserName);
            this.pnl_baseInfo.Controls.Add(this.label5);
            this.pnl_baseInfo.Enabled = false;
            this.pnl_baseInfo.Location = new System.Drawing.Point(37, 259);
            this.pnl_baseInfo.Name = "pnl_baseInfo";
            this.pnl_baseInfo.Size = new System.Drawing.Size(526, 70);
            this.pnl_baseInfo.TabIndex = 12;
            // 
            // rdo_buyUser
            // 
            this.rdo_buyUser.AutoSize = true;
            this.rdo_buyUser.Location = new System.Drawing.Point(441, 48);
            this.rdo_buyUser.Name = "rdo_buyUser";
            this.rdo_buyUser.Size = new System.Drawing.Size(59, 16);
            this.rdo_buyUser.TabIndex = 10;
            this.rdo_buyUser.Text = "采购员";
            this.rdo_buyUser.UseVisualStyleBackColor = true;
            // 
            // rdo_sellUser
            // 
            this.rdo_sellUser.AutoSize = true;
            this.rdo_sellUser.Checked = true;
            this.rdo_sellUser.Location = new System.Drawing.Point(441, 19);
            this.rdo_sellUser.Name = "rdo_sellUser";
            this.rdo_sellUser.Size = new System.Drawing.Size(59, 16);
            this.rdo_sellUser.TabIndex = 9;
            this.rdo_sellUser.TabStop = true;
            this.rdo_sellUser.Text = "销售员";
            this.rdo_sellUser.UseVisualStyleBackColor = true;
            // 
            // Frm_UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(592, 393);
            this.Controls.Add(this.pnl_baseInfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_UserInfo";
            this.Text = "操作员资料维护";
            this.Load += new System.EventHandler(this.Frm_UserInfo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserInfo)).EndInit();
            this.pnl_baseInfo.ResumeLayout(false);
            this.pnl_baseInfo.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_UserPass1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_UserPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_UserloginId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_UserInfo;
        private System.Windows.Forms.ToolStripButton tsb_Btn_Exit;
        private System.Windows.Forms.Panel pnl_baseInfo;
        private System.Windows.Forms.RadioButton rdo_buyUser;
        private System.Windows.Forms.RadioButton rdo_sellUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_UserloginId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_UserPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_UserRole_Nmae;
        private System.Windows.Forms.DataGridViewTextBoxColumn userRole;
    }
}