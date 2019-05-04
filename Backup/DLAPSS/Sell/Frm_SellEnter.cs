using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DLAPSS.Store;
using System.Data.SqlClient;

namespace DLAPSS.Sell
{
    public partial class Frm_SellEnter : Form
    {
        public Frm_SellEnter()
        {
            InitializeComponent();
        }
        int num = 0;

        int sum = 0;

        float money = 0;

        //连接数据库字符串
        private static readonly string conStr = DBHelper.conStr;
        List<StoreRoom> ls = new List<StoreRoom>();
        /// <summary>
        /// 清空空间
        /// </summary>
        public void Clear()
        {
            txt_Enter_Num.Text = "";
            txt_Prot_Bigunit.Text = "";
            txt_Prot_Name.Text = "";
            txt_Prot_Rate.Text = "";
            txt_Prot_Retailprice.Text = "";
            txt_Prot_Smallunit.Text = "";
            txt_Prot_Tradeprice.Text = "";
            lb_Prot_id.Text = "0";
        }
        //窗体加载
        private void Frm_SellEnter_Load(object sender, EventArgs e)
        {
            dgv_Store.AutoGenerateColumns = false;
            cbb_Cards_Name.DisplayMember = "Cardsname";
            cbb_Cards_Name.ValueMember = "Cardsid";
            cbb_Cards_Name.DataSource = LoginInfo.GetCardsByCards_name("");
            cbb_Priv_Name.DisplayMember = "Priv_name";
            cbb_Priv_Name.ValueMember = "Priv_id";
            cbb_Priv_Name.DataSource = LoginInfo.GetProvidersByPriv_name("");
        }
        //保存
        private void tsb_Btn_Save_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (dgv_Store.DataSource != null)
                {
                    int i = GetOrersChangeBySql(DateTime.Now,LoginInfo.LoginUserInfo.UserId, money, sum, 3);
                    if (i > 0)
                    {
                        foreach (StoreRoom sr in ls)
                        {
                            GetOrerDetailsChangeBySql(i, sr.Prot_id, sr.In_Out_StoreRoom);
                            string sql = "update storeRoom set storesum=@store_sum where Protid=@Prot_id";
                            int store_sum = sr.Store_sum + sr.In_Out_StoreRoom;
                            if (GetStoreRoomChangeBySql(sql, sr.Prot_id, store_sum, sr.Store_lastNum) > 0)
                                MessageBox.Show("商品“" + sr.Prot_name + "”数量“" + sr.In_Out_StoreRoom + "”销售退货成功");
                            else
                                MessageBox.Show("商品“" + sr.Prot_name + "”数量“" + sr.In_Out_StoreRoom + "”销售退货失败");
                        }
                        ls.Clear();
                        Clear();
                        dgv_Store.DataSource = null;
                        num = 0;
                        sum = 0;
                        money = 0;
                    }
                    else
                    {
                        MessageBox.Show("订单总表添加失败，请重新再试");
                    }
                }
                else
                    MessageBox.Show("请添加商品信息");
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("失败");
            //}
        }
        //删除
        private void tsb_Btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否确定删除该商品", "删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (dr == DialogResult.Cancel)
                return;
            else
            {
                if (dgv_Store.SelectedRows.Count <= 0)
                {
                    return;
                }
                int i = Convert.ToInt32(dgv_Store.CurrentRow.Cells["cl_Prot_id"].Value);
                foreach (StoreRoom var in ls)
                {
                    if (var.Prot_id == i)
                    {
                        common.s = var;
                        break;
                    }
                }
                ls.Remove(common.s);
                common.s = null;
                dgv_Store.DataSource = null;
                dgv_Store.DataSource = ls;
            }
        }
        //退出
        private void tsb_Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //按键事件
        private void txt_Prot_Name_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    common.Prot_name = txt_Prot_Name.Text;
                    common.Prot_EnterAndOut = true;
                    Frm_StoreQuery fs = new Frm_StoreQuery();
                    fs.ShowDialog();
                    StoreRoom s = common.s;
                    txt_Prot_Bigunit.Text = s.Prot_Bigunit;
                    txt_Prot_Name.Text = s.Prot_name;
                    txt_Prot_Rate.Text = s.Prot_rate.ToString();
                    txt_Prot_Retailprice.Text = s.Prot_retailprice.ToString();
                    txt_Prot_Smallunit.Text = s.Prot_smallunit;
                    txt_Prot_Tradeprice.Text = s.Prot_tradeprice.ToString();
                    cbb_Cards_Name.Text = s.Cards_name;
                    cbb_Priv_Name.Text = s.Priv_name;
                    dtp_Prot_Date.Value = s.Prot_date;
                    lb_Prot_id.Text = s.Prot_id.ToString();
                    txt_Enter_Num.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("请选择一项");
            }
        }
        //添加到集合按键事件
        private void txt_Enter_Num_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (Convert.ToInt32(txt_Enter_Num.Text) <= 0)
                    {
                        MessageBox.Show("销售退货不能为负值和0");
                        txt_Enter_Num.SelectAll();
                        return;
                    }
                    bool b = true;
                    foreach (StoreRoom var in ls)
                    {
                        if (var.Prot_id.ToString() == lb_Prot_id.Text)
                        {
                            var.In_Out_StoreRoom += Convert.ToInt32(txt_Enter_Num.Text);
                            sum += Convert.ToInt32(txt_Enter_Num.Text);
                            money += Convert.ToInt32(txt_Enter_Num.Text) * var.Prot_tradeprice;
                            b = false;
                            break;
                        }
                    }
                    StoreRoom s = common.s;
                    if (b)
                    {
                        s.In_Out_StoreRoom = Convert.ToInt32(txt_Enter_Num.Text);
                        num++;
                        sum += s.In_Out_StoreRoom;
                        money+= s.In_Out_StoreRoom * s.Prot_tradeprice;
                        ls.Add(s);
                    }
                    common.s = null;
                    dgv_Store.DataSource = null;
                    dgv_Store.DataSource = ls;
                    Clear();
                    txt_Prot_Name.Focus();
                    lb_money.Text = money.ToString();
                    lb_num.Text = num.ToString();
                    lb_sum.Text = sum.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("请输入正确的数字格式");
                    txt_Enter_Num.SelectAll();
                }
            }
        }
        /// <summary>
        /// 对底单总表进行添加
        /// </summary>
        /// <param name="order_time">订单时间</param>
        /// <param name="userId">操作员ID</param>
        /// <param name="order_sum_money">该订单商品总价</param>
        /// <param name="order_sum_total">该订单商品总数量</param>
        /// <param name="order_type">该订单类型 0进货 1退货 2 销售 3销售退货</param>
        /// <returns>点单总表编号</returns>
        public int GetOrersChangeBySql(DateTime order_time, int userId, float order_sum_money, int order_sum_total, int order_type)
        {
            SqlConnection con = new SqlConnection(conStr);
            int i = 0;
            try
            {
                con.Open();
                string sql = "insert orders values(@Order_time, @UserId, @Order_sum_money, @Order_sum_total, @Order_type)";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.Add("@order_time", SqlDbType.DateTime).Value = order_time;
                com.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
                com.Parameters.Add("@order_sum_money", SqlDbType.Money).Value = order_sum_money;
                com.Parameters.Add("@order_sum_total", SqlDbType.Int).Value = order_sum_total;
                com.Parameters.Add("@order_type", SqlDbType.Int).Value = order_type;
                i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    com.CommandText = "select @@identity";
                    i = Convert.ToInt32(com.ExecuteScalar());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("系统出现异常，请您稍后再试！");
            }
            finally
            {
                con.Close();
            }
            return i;
        }
        /// <summary>
        /// 添加新的订单明细表
        /// </summary>
        /// <param name="order_id">订单总表ID</param>
        /// <param name="prot_id">商品编号ID</param>
        /// <param name="order_det_sum">商品数量</param>
        /// <returns></returns>
        public int GetOrerDetailsChangeBySql(int order_id, int prot_id, int order_det_sum)
        {
            SqlConnection con = new SqlConnection(conStr);
            int i = 0;
            try
            {
                con.Open();
                string sql = "insert orderDetails values(@Order_id, @Prot_id, @order_det_sum)";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.Add("@order_id", SqlDbType.Int).Value = order_id;
                com.Parameters.Add("@prot_id", SqlDbType.Int).Value = prot_id;
                com.Parameters.Add("@order_det_sum", SqlDbType.Int).Value = order_det_sum;
                i = com.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("系统出现异常，请您稍后再试！");
            }
            finally
            {
                con.Close();
            }
            return i;
        }
        /// <summary>
        /// 用sql语句对库存进行添加修改
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="Prot_id">商品ID 外键</param>
        /// <param name="store_sum">商品库存</param>
        /// <param name="store_lastNum">库存下限</param>
        /// <returns>sql语句影响的行数</returns>
        public int GetStoreRoomChangeBySql(string sql, int Prot_id, int store_sum, int store_lastNum)
        {
            SqlConnection con = new SqlConnection(conStr);
            int i = 0;
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.Add("@Prot_id", SqlDbType.Int).Value = Prot_id;
                com.Parameters.Add("@store_sum", SqlDbType.Int).Value = store_sum;
                com.Parameters.Add("@store_lastNum", SqlDbType.Int).Value = store_lastNum;
                i = com.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("系统出现异常，请您稍后再试！");
            }
            finally
            {
                con.Close();
            }
            return i;
        }
    }
}