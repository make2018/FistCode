namespace DLAPSS.Store_Room
{
    partial class Frm_ReturnProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ReturnProduct));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Returnprod_Reason = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "退货原因";
            // 
            // txt_Returnprod_Reason
            // 
            this.txt_Returnprod_Reason.Location = new System.Drawing.Point(14, 24);
            this.txt_Returnprod_Reason.Multiline = true;
            this.txt_Returnprod_Reason.Name = "txt_Returnprod_Reason";
            this.txt_Returnprod_Reason.Size = new System.Drawing.Size(266, 237);
            this.txt_Returnprod_Reason.TabIndex = 1;
            this.txt_Returnprod_Reason.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Returnprod_Reason_KeyDown);
            // 
            // Frm_ReturnProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.txt_Returnprod_Reason);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_ReturnProduct";
            this.Text = "退货原因";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Returnprod_Reason;
    }
}