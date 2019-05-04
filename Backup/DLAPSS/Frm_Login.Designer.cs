namespace DLAPSS
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UserloginId = new System.Windows.Forms.TextBox();
            this.txt_UserPass = new System.Windows.Forms.TextBox();
            this.btt_Login = new System.Windows.Forms.Button();
            this.btt_Reset = new System.Windows.Forms.Button();
            this.cbo_loginType = new System.Windows.Forms.ComboBox();
            this.lbl_loginType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文中宋", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(51, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文中宋", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(65, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "密码：";
            // 
            // txt_UserloginId
            // 
            this.txt_UserloginId.Location = new System.Drawing.Point(121, 61);
            this.txt_UserloginId.Name = "txt_UserloginId";
            this.txt_UserloginId.Size = new System.Drawing.Size(140, 21);
            this.txt_UserloginId.TabIndex = 1;
            this.txt_UserloginId.Text = "admin";
            //this.txt_UserloginId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Enter_KeyDown);
            // 
            // txt_UserPass
            // 
            this.txt_UserPass.Location = new System.Drawing.Point(121, 88);
            this.txt_UserPass.Name = "txt_UserPass";
            this.txt_UserPass.Size = new System.Drawing.Size(140, 21);
            this.txt_UserPass.TabIndex = 2;
            this.txt_UserPass.Text = "12345";
            this.txt_UserPass.UseSystemPasswordChar = true;
            //this.txt_UserPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Enter_KeyDown);
            // 
            // btt_Login
            // 
            this.btt_Login.BackColor = System.Drawing.Color.Transparent;
            this.btt_Login.BackgroundImage = global::DLAPSS.Properties.Resources.bg_Navigate;
            this.btt_Login.Location = new System.Drawing.Point(109, 160);
            this.btt_Login.Name = "btt_Login";
            this.btt_Login.Size = new System.Drawing.Size(50, 20);
            this.btt_Login.TabIndex = 3;
            this.btt_Login.Text = "登录";
            this.btt_Login.UseVisualStyleBackColor = false;
            this.btt_Login.Click += new System.EventHandler(this.btt_Login_Click);
            // 
            // btt_Reset
            // 
            this.btt_Reset.BackColor = System.Drawing.Color.Transparent;
            this.btt_Reset.BackgroundImage = global::DLAPSS.Properties.Resources.bg_Navigate;
            this.btt_Reset.Location = new System.Drawing.Point(185, 160);
            this.btt_Reset.Name = "btt_Reset";
            this.btt_Reset.Size = new System.Drawing.Size(50, 20);
            this.btt_Reset.TabIndex = 4;
            this.btt_Reset.Text = "重置";
            this.btt_Reset.UseVisualStyleBackColor = false;
            this.btt_Reset.Click += new System.EventHandler(this.btt_Reset_Click);
            // 
            // cbo_loginType
            // 
            this.cbo_loginType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_loginType.FormattingEnabled = true;
            this.cbo_loginType.Items.AddRange(new object[] {
            "管理员",
            "销售员",
            "采购员"});
            this.cbo_loginType.Location = new System.Drawing.Point(121, 122);
            this.cbo_loginType.Name = "cbo_loginType";
            this.cbo_loginType.Size = new System.Drawing.Size(140, 20);
            this.cbo_loginType.TabIndex = 6;
            this.cbo_loginType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbo_loginType_KeyDown);
            // 
            // lbl_loginType
            // 
            this.lbl_loginType.AutoSize = true;
            this.lbl_loginType.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loginType.Font = new System.Drawing.Font("华文中宋", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_loginType.ForeColor = System.Drawing.Color.Blue;
            this.lbl_loginType.Location = new System.Drawing.Point(36, 122);
            this.lbl_loginType.Name = "lbl_loginType";
            this.lbl_loginType.Size = new System.Drawing.Size(78, 16);
            this.lbl_loginType.TabIndex = 7;
            this.lbl_loginType.Text = "登录类型：";
            // 
            // Frm_Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::DLAPSS.Properties.Resources.login_bg;
            this.ClientSize = new System.Drawing.Size(319, 219);
            this.Controls.Add(this.lbl_loginType);
            this.Controls.Add(this.cbo_loginType);
            this.Controls.Add(this.btt_Reset);
            this.Controls.Add(this.btt_Login);
            this.Controls.Add(this.txt_UserPass);
            this.Controls.Add(this.txt_UserloginId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎使用进销存管理系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_UserloginId;
        private System.Windows.Forms.TextBox txt_UserPass;
        private System.Windows.Forms.Button btt_Login;
        private System.Windows.Forms.Button btt_Reset;
        private System.Windows.Forms.ComboBox cbo_loginType;
        private System.Windows.Forms.Label lbl_loginType;
    }
}