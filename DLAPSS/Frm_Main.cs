using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DLAPSS.BasicDataInfo;
using DLAPSS.Store;
using DLAPSS.Store_Room;
using DLAPSS.Sell;
using DLAPSS.Statistic.Sell_Statistic;
using DLAPSS.Statistic.Store_Statistic;

namespace DLAPSS
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tslb_time.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH时:mm分:ss秒");
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            if (LoginInfo.LoginUserInfo.UserRole == "1")//当前登录用户是销售员
            {
                tsmi_BasicDataInfo.Enabled = false;
                tsmi_Store_Room.Enabled = false;
                tsmi_Store_Statistic.Enabled = false;
            }
            else if (LoginInfo.LoginUserInfo.UserRole == "2")//当前登录用户是采购员
            {
                tsmi_UserInfo.Enabled = false;
                tsmi_Sell.Enabled = false;
                tsmi_Sell_Statistic.Enabled = false;
            }
            tslb_name.Text = "登录信息：欢迎您" + LoginInfo.LoginUserInfo.UserName + "！当前时间：";
            tslb_time.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH时:mm分:ss秒");
        }

        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否确认关闭系统", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();//退出应用程序
            }
            else
                e.Cancel = true;
        }

        Frm_UserInfo fu = new Frm_UserInfo();
        private void tsmi_UserInfo_Click(object sender, EventArgs e)
        {
            fu.MdiParent = this;
            if (fu.Visible)
            {
                fu.Focus();
                return;
            }
            else
            {
                fu = new Frm_UserInfo();
                fu.MdiParent = this;
                fu.Show();
            }
        }

        Frm_ProductInfo fpd = new Frm_ProductInfo();
        private void tsmi_ProductInfo_Click(object sender, EventArgs e)
        {
            fpd.MdiParent = this;
            if (fpd.Visible)
            {
                fpd.Focus();
                return;
            }
            else
            {
                fpd = new Frm_ProductInfo();
                fpd.MdiParent = this;
                fpd.Show();
            }
        }

        Frm_ProvidersInfo fpv = new Frm_ProvidersInfo();
        private void tsmi_ProvidersInfo_Click(object sender, EventArgs e)
        {
            fpv.MdiParent = this;
            if (fpv.Visible)
            {
                fpd.Focus();
                return;
            }
            else
            {
                fpv = new Frm_ProvidersInfo();
                fpv.MdiParent = this;
                fpv.Show();
            }
        }

        Frm_CardsInfo fcd = new Frm_CardsInfo();
        private void tsmi_CardsInfo_Click(object sender, EventArgs e)
        {
            fcd.MdiParent = this;
            if (fcd.Visible)
            {
                fcd.Focus();
                return;
            }
            else
            {
                fcd = new Frm_CardsInfo();
                fcd.MdiParent = this;
                fcd.Show();
            }
        }

        Frm_StoreQuery fsq = new Frm_StoreQuery();
        private void tsmi_StoreQuery_Click(object sender, EventArgs e)
        {
            fsq.MdiParent = this;
            if (fsq.Visible)
            {
                fsq.Focus();
                return;
            }
            else
            {
                fsq = new Frm_StoreQuery();
                fsq.MdiParent = this;
                fsq.Show();
            }
        }

        Frm_StoreRoomEnter fsre = new Frm_StoreRoomEnter();
        private void tsmi_StoreRoomEnter_Click(object sender, EventArgs e)
        {
            fsre.MdiParent = this;
            if (fsre.Visible)
            {
                fsre.Focus();
                return;
            }
            else
            {
                fsre = new Frm_StoreRoomEnter();
                fsre.MdiParent = this;
                fsre.Show();
            }
        }

        Frm_StoreRoomOut fsro = new Frm_StoreRoomOut();
        private void tsmi_StoreRoomOut_Click(object sender, EventArgs e)
        {
            fsro.MdiParent = this;
            if (fsro.Visible)
            {
                fsro.Focus();
                return;
            }
            else
            {
                fsro = new Frm_StoreRoomOut();
                fsro.MdiParent = this;
                fsro.Show();
            }
        }

        Frm_SellOut fso = new Frm_SellOut();
        private void tsmi_SellOut_Click(object sender, EventArgs e)
        {
            fso.MdiParent = this;
            if (fso.Visible)
            {
                fso.Focus();
                return;
            }
            else
            {
                fso = new Frm_SellOut();
                fso.MdiParent = this;
                fso.Show();
            }
        }

        Frm_SellEnter fse = new Frm_SellEnter();
        private void tsmi_SellEnter_Click(object sender, EventArgs e)
        {
            fse.MdiParent = this;
            if (fse.Visible)
            {
                fse.Focus();
                return;
            }
            else
            {
                fse = new Frm_SellEnter();
                fse.MdiParent = this;
                fse.Show();
            }
        }

        Frm_Sell_Statistic_Out fseo = new Frm_Sell_Statistic_Out();
        private void tsmi_Sell_Statistic_Out_Click(object sender, EventArgs e)
        {
            fseo.MdiParent = this;
            if (fseo.Visible)
            {
                fseo.Focus();
                return;
            }
            else
            {
                fseo = new Frm_Sell_Statistic_Out();
                fseo.MdiParent = this;
                fseo.Show();
            }
        }

        Frm_Sell_Statistic_Enter fsee = new Frm_Sell_Statistic_Enter();
        private void tsmi_Sell_Statistic_Enter_Click(object sender, EventArgs e)
        {
            fsee.MdiParent = this;
            if (fsee.Visible)
            {
                fsee.Focus();
                return;
            }
            else
            {
                fsee = new Frm_Sell_Statistic_Enter();
                fsee.MdiParent = this;
                fsee.Show();
            }
        }
        Frm_Store_Statistic_Enter fsse = new Frm_Store_Statistic_Enter();
        private void tsmi_Store_Statistic_Enter_Click(object sender, EventArgs e)
        {
            fsse.MdiParent = this;
            if (fsse.Visible)
            {
                fsse.Focus();
                return;
            }
            else
            {
                fsse = new Frm_Store_Statistic_Enter();
                fsse.MdiParent = this;
                fsse.Show();
            }
        }

        Frm_Store_Statistic_Out fsso = new Frm_Store_Statistic_Out();
        private void tsmi_Store_Statistic_Out_Click(object sender, EventArgs e)
        {
            fsso.MdiParent = this;
            if (fsso.Visible)
            {
                fsso.Focus();
                return;
            }
            else
            {
                fsso = new Frm_Store_Statistic_Out();
                fsso.MdiParent = this;
                fsso.Show();
            }
        }
    }
}