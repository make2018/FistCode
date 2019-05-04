using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DLAPSS.Entity;


namespace DLAPSS.BasicDataInfo
{
    public partial class Frm_CardsInfo : Form
    {
        public Frm_CardsInfo()
        {
            InitializeComponent();
        }
        //连接数据库字符串
        private static readonly string conStr = DBHelper.conStr;
        List<CardsInfo> lc = new List<CardsInfo>();
        int type = 0;//添加操作还是修改操作
        /// <summary>
        /// 清空控件
        /// </summary>
        public void Clear()
        {
            txt_Cards_Id.Text = "";
            txt_Cards_Name.Text = "";
        }

        /// <summary>
        /// 显示控件
        /// </summary>
        public void Display()
        {
            txt_Cards_Name.Enabled = true;
            tsb_Btn_Save.Enabled = true;
        }

        /// <summary>
        /// 隐藏控件
        /// </summary>
        public void Conceal()
        {
            txt_Cards_Name.Enabled = false;
            tsb_Btn_Save.Enabled = false;
        }

        /// <summary>
        /// 取消
        /// </summary>
        public void Cancel()
        {
            tsb_Btn_Add.Enabled = true;
            tsb_Btn_Amend.Enabled = true;
            tsb_Btn_Save.Enabled = true;
            tsb_Btn_Delete.Enabled = true;
            tsb_Txt_Lookup.Enabled = true;
            tsb_Btn_Lookup.Enabled = true;
            Clear();
            Conceal();
        }
        //窗体加载
        private void Frm_CardsInfo_Load(object sender, EventArgs e)
        {
            lc = GetCardsByCards_name("");
            dgv_Cards.DataSource = lc;
            Conceal();
        }
        /// <summary>
        /// 使用品牌名称查询商品信息
        /// </summary>
        /// <param name="Cards_name">品牌名称</param>
        /// <returns>品牌表集合</returns>
        public List<CardsInfo> GetCardsByCards_name(string Cards_name)
        {
            List<CardsInfo> lc = new List<CardsInfo>();
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                con.Open();
                string sql = string.Format("select * from Cards where Cardsname like '%{0}%'", Cards_name);
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    CardsInfo u = new CardsInfo();
                    u.CardsId = Convert.ToInt32(dr["Cardsid"]);
                    u.CardsName = dr["Cardsname"].ToString();
                    lc.Add(u);
                }
                dr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("系统出现异常，请您稍后再试！");
            }
            finally 
            {
                con.Close();
            }
            return lc;
        }
        //退出
        private void tsb_Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //添加
        private void tsb_Btn_Add_Click(object sender, EventArgs e)
        {
            type = 1;
            Display();
            tsb_Btn_Amend.Enabled = false;
            tsb_Txt_Lookup.Enabled = false;
            tsb_Btn_Delete.Enabled = false;
            tsb_Btn_Lookup.Enabled = false;
            txt_Cards_Name.Focus();
        }
        //修改
        private void tsb_Btn_Amend_Click(object sender, EventArgs e)
        {
            type = 0;
            Display();
            tsb_Btn_Add.Enabled = false;
            tsb_Btn_Delete.Enabled = false;
            tsb_Txt_Lookup.Enabled = false;
            tsb_Btn_Lookup.Enabled = false;
            txt_Cards_Id.Text = dgv_Cards.CurrentRow.Cells[0].Value.ToString();
            txt_Cards_Name.Text = dgv_Cards.CurrentRow.Cells[1].Value.ToString();
            txt_Cards_Name.Focus();
        }
        //保存
        private void tsb_Btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_Cards_Name.Text.Trim() == "" || string.IsNullOrEmpty(txt_Cards_Name.Text.Trim()))
            {
                MessageBox.Show("商品名称不能为空！");
                return;
            }
            if (type == 0)//修改
            {
                string sql = string.Format("update cards set cardsname='{0}' where CardsId={1}", txt_Cards_Name.Text, Convert.ToInt32(txt_Cards_Id.Text));
                int result = executeQuery(sql);
                if (result > 0)
                {
                    MessageBox.Show("修改成功！");
                }
                else
                {
                    MessageBox.Show("修改失败！");
                }
            }
            else if (type == 1)
            {
                //添加
                foreach (CardsInfo item in lc)
                {
                    if (item.CardsName == txt_Cards_Name.Text)
                    {
                        MessageBox.Show("该商品品牌已存在","提示");
                        return;
                    }
                }
                string sql = string.Format("insert into dbo.cards(cardsName)values('{0}');",txt_Cards_Name.Text);
                int result = executeQuery(sql);
                if (result > 0)
                {
                    MessageBox.Show("添加成功！");
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
            }
            lc = GetCardsByCards_name("");
            dgv_Cards.DataSource = lc;
            Cancel();
        }
        //删除
        private void tsb_Btn_Delete_Click(object sender, EventArgs e)
        {
            //判断当有选择的项的时候
            if (dgv_Cards.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("确定删除该条信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string sql = string.Format("delete from cards where CardsId={0}", Convert.ToInt32(dgv_Cards.SelectedRows[0].Cells[0].Value));
                    int result = executeQuery(sql);
                    if (result > 0)
                    {
                        MessageBox.Show("删除成功！", "提示");
                        lc = GetCardsByCards_name("");
                        dgv_Cards.DataSource = lc;
                    }
                }
            }
        }

        // 执行增删改操作的方法
        private int executeQuery(string sql)
        {
            SqlConnection con = new SqlConnection(conStr);
            int resule = 0;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                resule = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("此信息与商品信息有关联请先删除商品信息！", "提示");
            }
            finally
            {
                con.Close();
            }
            return resule;
        }
        //查询
        private void tsb_Btn_Lookup_Click(object sender, EventArgs e)
        {
            lc = GetCardsByCards_name(tsb_Txt_Lookup.Text);
            dgv_Cards.DataSource = lc;
        }
        //取消
        private void tsb_Btn_Cancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }
    }
}