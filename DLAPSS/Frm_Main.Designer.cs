namespace DLAPSS
{
    partial class Frm_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_BasicDataInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_UserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ProductInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ProvidersInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_CardsInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Store_Room = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_StoreRoomEnter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_StoreRoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Sell = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_SellOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_SellEnter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Store = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_StoreQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Statistic = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Sell_Statistic = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Sell_Statistic_Out = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Sell_Statistic_Enter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_Store_Statistic = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Store_Statistic_Enter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Store_Statistic_Out = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Content = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_Anent = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslb_name = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslb_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::DLAPSS.Properties.Resources.bg_Navigate;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_BasicDataInfo,
            this.tsmi_Store_Room,
            this.tsmi_Sell,
            this.tsmi_Store,
            this.tsmi_Statistic,
            this.tsmi_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmi_BasicDataInfo
            // 
            this.tsmi_BasicDataInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_UserInfo,
            this.tsmi_ProductInfo,
            this.tsmi_ProvidersInfo,
            this.tsmi_CardsInfo});
            this.tsmi_BasicDataInfo.Name = "tsmi_BasicDataInfo";
            this.tsmi_BasicDataInfo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.tsmi_BasicDataInfo.Size = new System.Drawing.Size(107, 20);
            this.tsmi_BasicDataInfo.Text = "基本资料维护(&W)";
            // 
            // tsmi_UserInfo
            // 
            this.tsmi_UserInfo.Name = "tsmi_UserInfo";
            this.tsmi_UserInfo.Size = new System.Drawing.Size(172, 22);
            this.tsmi_UserInfo.Text = "操作员资料(&U)";
            this.tsmi_UserInfo.Click += new System.EventHandler(this.tsmi_UserInfo_Click);
            // 
            // tsmi_ProductInfo
            // 
            this.tsmi_ProductInfo.Name = "tsmi_ProductInfo";
            this.tsmi_ProductInfo.Size = new System.Drawing.Size(172, 22);
            this.tsmi_ProductInfo.Text = "商品资料维护(&P)";
            this.tsmi_ProductInfo.Click += new System.EventHandler(this.tsmi_ProductInfo_Click);
            // 
            // tsmi_ProvidersInfo
            // 
            this.tsmi_ProvidersInfo.Name = "tsmi_ProvidersInfo";
            this.tsmi_ProvidersInfo.Size = new System.Drawing.Size(172, 22);
            this.tsmi_ProvidersInfo.Text = "供应商资料维护(&G)";
            this.tsmi_ProvidersInfo.Click += new System.EventHandler(this.tsmi_ProvidersInfo_Click);
            // 
            // tsmi_CardsInfo
            // 
            this.tsmi_CardsInfo.Name = "tsmi_CardsInfo";
            this.tsmi_CardsInfo.Size = new System.Drawing.Size(172, 22);
            this.tsmi_CardsInfo.Text = "品牌资料维护(&C)";
            this.tsmi_CardsInfo.Click += new System.EventHandler(this.tsmi_CardsInfo_Click);
            // 
            // tsmi_Store_Room
            // 
            this.tsmi_Store_Room.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_StoreRoomEnter,
            this.tsmi_StoreRoomOut});
            this.tsmi_Store_Room.Name = "tsmi_Store_Room";
            this.tsmi_Store_Room.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmi_Store_Room.Size = new System.Drawing.Size(59, 20);
            this.tsmi_Store_Room.Text = "采购(&S)";
            // 
            // tsmi_StoreRoomEnter
            // 
            this.tsmi_StoreRoomEnter.Name = "tsmi_StoreRoomEnter";
            this.tsmi_StoreRoomEnter.Size = new System.Drawing.Size(136, 22);
            this.tsmi_StoreRoomEnter.Text = "采购入库(&E)";
            this.tsmi_StoreRoomEnter.Click += new System.EventHandler(this.tsmi_StoreRoomEnter_Click);
            // 
            // tsmi_StoreRoomOut
            // 
            this.tsmi_StoreRoomOut.Name = "tsmi_StoreRoomOut";
            this.tsmi_StoreRoomOut.Size = new System.Drawing.Size(136, 22);
            this.tsmi_StoreRoomOut.Text = "采购退货(&O)";
            this.tsmi_StoreRoomOut.Click += new System.EventHandler(this.tsmi_StoreRoomOut_Click);
            // 
            // tsmi_Sell
            // 
            this.tsmi_Sell.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_SellOut,
            this.tsmi_SellEnter});
            this.tsmi_Sell.Name = "tsmi_Sell";
            this.tsmi_Sell.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmi_Sell.Size = new System.Drawing.Size(59, 20);
            this.tsmi_Sell.Text = "销售(&E)";
            // 
            // tsmi_SellOut
            // 
            this.tsmi_SellOut.Name = "tsmi_SellOut";
            this.tsmi_SellOut.Size = new System.Drawing.Size(136, 22);
            this.tsmi_SellOut.Text = "销售出库(&O)";
            this.tsmi_SellOut.Click += new System.EventHandler(this.tsmi_SellOut_Click);
            // 
            // tsmi_SellEnter
            // 
            this.tsmi_SellEnter.Name = "tsmi_SellEnter";
            this.tsmi_SellEnter.Size = new System.Drawing.Size(136, 22);
            this.tsmi_SellEnter.Text = "销售退货(&E)";
            this.tsmi_SellEnter.Click += new System.EventHandler(this.tsmi_SellEnter_Click);
            // 
            // tsmi_Store
            // 
            this.tsmi_Store.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_StoreQuery});
            this.tsmi_Store.Name = "tsmi_Store";
            this.tsmi_Store.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.tsmi_Store.Size = new System.Drawing.Size(59, 20);
            this.tsmi_Store.Text = "库存(&Q)";
            // 
            // tsmi_StoreQuery
            // 
            this.tsmi_StoreQuery.Name = "tsmi_StoreQuery";
            this.tsmi_StoreQuery.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.tsmi_StoreQuery.Size = new System.Drawing.Size(177, 22);
            this.tsmi_StoreQuery.Text = "库存查询(&Q)";
            this.tsmi_StoreQuery.Click += new System.EventHandler(this.tsmi_StoreQuery_Click);
            // 
            // tsmi_Statistic
            // 
            this.tsmi_Statistic.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Sell_Statistic,
            this.toolStripMenuItem2,
            this.tsmi_Store_Statistic});
            this.tsmi_Statistic.Name = "tsmi_Statistic";
            this.tsmi_Statistic.Size = new System.Drawing.Size(83, 20);
            this.tsmi_Statistic.Text = "统计查询(&T)";
            // 
            // tsmi_Sell_Statistic
            // 
            this.tsmi_Sell_Statistic.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Sell_Statistic_Out,
            this.tsmi_Sell_Statistic_Enter});
            this.tsmi_Sell_Statistic.Name = "tsmi_Sell_Statistic";
            this.tsmi_Sell_Statistic.Size = new System.Drawing.Size(136, 22);
            this.tsmi_Sell_Statistic.Text = "销售统计(&E)";
            // 
            // tsmi_Sell_Statistic_Out
            // 
            this.tsmi_Sell_Statistic_Out.Name = "tsmi_Sell_Statistic_Out";
            this.tsmi_Sell_Statistic_Out.Size = new System.Drawing.Size(160, 22);
            this.tsmi_Sell_Statistic_Out.Text = "销售出库统计(&O)";
            this.tsmi_Sell_Statistic_Out.Click += new System.EventHandler(this.tsmi_Sell_Statistic_Out_Click);
            // 
            // tsmi_Sell_Statistic_Enter
            // 
            this.tsmi_Sell_Statistic_Enter.Name = "tsmi_Sell_Statistic_Enter";
            this.tsmi_Sell_Statistic_Enter.Size = new System.Drawing.Size(160, 22);
            this.tsmi_Sell_Statistic_Enter.Text = "销售退货统计(&E)";
            this.tsmi_Sell_Statistic_Enter.Click += new System.EventHandler(this.tsmi_Sell_Statistic_Enter_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(133, 6);
            // 
            // tsmi_Store_Statistic
            // 
            this.tsmi_Store_Statistic.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Store_Statistic_Enter,
            this.tsmi_Store_Statistic_Out});
            this.tsmi_Store_Statistic.Name = "tsmi_Store_Statistic";
            this.tsmi_Store_Statistic.Size = new System.Drawing.Size(136, 22);
            this.tsmi_Store_Statistic.Text = "采购统计(&S)";
            // 
            // tsmi_Store_Statistic_Enter
            // 
            this.tsmi_Store_Statistic_Enter.Name = "tsmi_Store_Statistic_Enter";
            this.tsmi_Store_Statistic_Enter.Size = new System.Drawing.Size(160, 22);
            this.tsmi_Store_Statistic_Enter.Text = "采购入库统计(&E)";
            this.tsmi_Store_Statistic_Enter.Click += new System.EventHandler(this.tsmi_Store_Statistic_Enter_Click);
            // 
            // tsmi_Store_Statistic_Out
            // 
            this.tsmi_Store_Statistic_Out.Name = "tsmi_Store_Statistic_Out";
            this.tsmi_Store_Statistic_Out.Size = new System.Drawing.Size(160, 22);
            this.tsmi_Store_Statistic_Out.Text = "采购退货统计(&O)";
            this.tsmi_Store_Statistic_Out.Click += new System.EventHandler(this.tsmi_Store_Statistic_Out_Click);
            // 
            // tsmi_Help
            // 
            this.tsmi_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Content,
            this.toolStripSeparator5,
            this.tsmi_Anent});
            this.tsmi_Help.Name = "tsmi_Help";
            this.tsmi_Help.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.tsmi_Help.Size = new System.Drawing.Size(59, 20);
            this.tsmi_Help.Text = "帮助(&H)";
            // 
            // tsmi_Content
            // 
            this.tsmi_Content.Name = "tsmi_Content";
            this.tsmi_Content.Size = new System.Drawing.Size(130, 22);
            this.tsmi_Content.Text = "内容(&C)";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(127, 6);
            // 
            // tsmi_Anent
            // 
            this.tsmi_Anent.Name = "tsmi_Anent";
            this.tsmi_Anent.Size = new System.Drawing.Size(130, 22);
            this.tsmi_Anent.Text = "关于(&A)...";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImage = global::DLAPSS.Properties.Resources.bg_Navigate;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslb_name,
            this.tslb_time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 511);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(882, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslb_name
            // 
            this.tslb_name.BackColor = System.Drawing.Color.Transparent;
            this.tslb_name.Name = "tslb_name";
            this.tslb_name.Size = new System.Drawing.Size(65, 17);
            this.tslb_name.Text = "登录信息：";
            // 
            // tslb_time
            // 
            this.tslb_time.BackColor = System.Drawing.Color.Transparent;
            this.tslb_time.Name = "tslb_time";
            this.tslb_time.Size = new System.Drawing.Size(65, 17);
            this.tslb_time.Text = "当前时间：";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::DLAPSS.Properties.Resources.商品进销存报表系统;
            this.ClientSize = new System.Drawing.Size(882, 533);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "进销存系统主界面";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Main_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_BasicDataInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmi_UserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ProductInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ProvidersInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmi_CardsInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Store_Room;
        private System.Windows.Forms.ToolStripMenuItem tsmi_StoreRoomEnter;
        private System.Windows.Forms.ToolStripMenuItem tsmi_StoreRoomOut;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Sell;
        private System.Windows.Forms.ToolStripMenuItem tsmi_SellOut;
        private System.Windows.Forms.ToolStripMenuItem tsmi_SellEnter;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Store;
        private System.Windows.Forms.ToolStripMenuItem tsmi_StoreQuery;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Help;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Content;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Anent;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslb_name;
        private System.Windows.Forms.ToolStripStatusLabel tslb_time;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Statistic;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Store_Statistic;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Store_Statistic_Enter;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Store_Statistic_Out;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Sell_Statistic;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Sell_Statistic_Out;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Sell_Statistic_Enter;
    }
}