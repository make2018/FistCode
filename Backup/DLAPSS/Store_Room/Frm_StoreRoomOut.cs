using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DLAPSS.Store;
using System.Data.SqlClient;
using DLAPSS.Entity;
namespace DLAPSS.Store_Room
{
    public partial class Frm_StoreRoomOut : Form
    {
        public Frm_StoreRoomOut()
        {
            InitializeComponent();
        }
        //连接数据库字符串
        private static readonly string conStr = DBHelper.conStr;
        int num = 0;
        int sum = 0;
        float money = 0;
        //库存信息
        List<StoreRoom> ls = new List<StoreRoom>();
        //商品信息集合
        List<ProductInfo> lp = new List<ProductInfo>();
        /// <summary>
        /// 清空空间
        /// </summary>
        public void Clear()
        {
            txt_Out_Num.Text = "";
            txt_Prot_Bigunit.Text = "";
            txt_Prot_Name.Text = "";
            txt_Prot_Rate.Text = "";
            txt_Prot_Retailprice.Text = "";
            txt_Prot_Smallunit.Text = "";
            txt_Prot_Tradeprice.Text = "";
        }
        //窗体加载
        private void Frm_StoreRoomOut_Load(object sender, EventArgs e)
        {
            dgv_Store.AutoGenerateColumns = false;
            cbb_Cards_Name.DisplayMember = "Cardsname";
            cbb_Cards_Name.ValueMember = "Cardsid";
            cbb_Cards_Name.DataSource = LoginInfo.GetCardsByCards_name("");
            cbb_Priv_Name.DisplayMember = "Priv_name";
            cbb_Priv_Name.ValueMember = "Priv_id";
            cbb_Priv_Name.DataSource = LoginInfo.GetProvidersByPriv_name("");
        }
        // 按键事件
        private void txt_Prot_Name_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    common.Prot_name = txt_Prot_Name.Text;
                    Frm_StoreQuery fs = new Frm_StoreQuery();
                    common.Prot_EnterAndOut = true;
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
                    txt_Out_Num.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("请选择一项");
            }
        }
        //按键事件
        private void txt_Out_Num_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    StoreRoom s = common.s;
                    if (Convert.ToInt32(txt_Out_Num.Text) > s.Store_sum)
                    {
                        MessageBox.Show("库存不够，请进货，或减少销售");
                        txt_Out_Num.SelectAll();
                        return;
                    }
                    if (Convert.ToInt32(txt_Out_Num.Text) <= 0)
                    {
                        MessageBox.Show("销售退货不能为负值和0");
                        txt_Out_Num.SelectAll();
                        return;
                    }
                    else
                    {
                        bool b = true;
                        foreach (StoreRoom var in ls)
                        {
                            if (var.Prot_id==common.s.Prot_id)
                            {
                                if (var.In_Out_StoreRoom + Convert.ToInt32(txt_Out_Num.Text) > var.Store_sum)
                                {
                                    MessageBox.Show("库存不够，请进货，或减少销售");
                                    txt_Out_Num.SelectAll();
                                    return;
                                }
                                var.In_Out_StoreRoom += Convert.ToInt32(txt_Out_Num.Text);
                                sum += Convert.ToInt32(txt_Out_Num.Text);
                                money += Convert.ToInt32(txt_Out_Num.Text) * var.Prot_tradeprice;
                                if (var.Store_sum - var.In_Out_StoreRoom < var.Store_lastNum)
                                {
                                    MessageBox.Show("请注意，该商品销售后，该商品库存小于库存下线，请尽快进货", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                                b = false;
                                break;
                            }
                        }
                        if (b)
                        {
                            Frm_ReturnProduct fr = new Frm_ReturnProduct();
                            fr.ShowDialog();
                            s.Returnprod_reason = common.returnprod_reason;
                            s.In_Out_StoreRoom = Convert.ToInt32(txt_Out_Num.Text);
                            num++;
                            sum += s.In_Out_StoreRoom;
                            money+= s.In_Out_StoreRoom * s.Prot_tradeprice;
                            if (s.Store_sum - s.In_Out_StoreRoom < s.Store_lastNum)
                            {
                                MessageBox.Show("请注意，该商品销售后，该商品库存小于库存下线，请尽快进货", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
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
                }
                catch (Exception)
                {
                    MessageBox.Show("请输入正确的数字格式");
                    txt_Out_Num.SelectAll();
                }
            }
        }
        //保存
        private void tsb_Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Store.DataSource != null)
                {
                    int i = GetOrersChangeBySql();
                    if (i > 0)
                    {
                        foreach (StoreRoom sr in ls)
                        {
                            SqlConnection con = new SqlConnection(conStr);
                            con.Open();
                            string sql1 = "select ProtProviderId from productInfo where ProtId="+sr.Prot_id;
                            SqlCommand cmd = new SqlCommand(sql1,con);
                            int providerId =Convert.ToInt32(cmd.ExecuteScalar());     
                            con.Close();
                            GetOrerDetailsChangeBySql(i, sr.Prot_id, sr.In_Out_StoreRoom);
                            GetReturnProductChangeBySql(sr.Prot_id, sr.In_Out_StoreRoom, common.returnprod_reason, LoginInfo.LoginUserInfo.UserId, DateTime.Now, providerId);
                            string sql = "update storeRoom set storesum=@store_sum where Protid=@Prot_id";
                            int store_sum = sr.Store_sum - sr.In_Out_StoreRoom;
                            if (GetStoreRoomChangeBySql(sql, sr.Prot_id, store_sum, sr.Store_lastNum) > 0)
                                MessageBox.Show("商品“" + sr.Prot_name + "”数量“" + sr.In_Out_StoreRoom + "”库存退货成功");
                            else
                                MessageBox.Show("商品“" + sr.Prot_name + "”数量“" + sr.In_Out_StoreRoom + "”库存退货失败");
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
            }
            catch (Exception)
            {
                MessageBox.Show("失败");
            }
        }
        //退出
        private void tsb_Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //删除
        private void tsb_Btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Store.SelectedRows.Count > 0) 
            {
                ls.RemoveAt(Convert.ToInt32(dgv_Store.SelectedRows[0].Index));
                dgv_Store.DataSource = null;
                dgv_Store.DataSource = ls;
            }
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
        /// 对底单总表进行添加
        /// </summary>
        /// <param name="order_time">订单时间</param>
        /// <param name="userId">操作员ID</param>
        /// <param name="order_sum_money">该订单商品总价</param>
        /// <param name="order_sum_total">该订单商品总数量</param>
        /// <param name="order_type">该订单类型 0进货 1退货 2 销售 3销售退货</param>
        /// <returns>点单总表编号</returns>
        public int GetOrersChangeBySql()
        {
            SqlConnection con = new SqlConnection(conStr);
            int i = 0;
            try
            {
                con.Open();
                string sql = string.Format("insert into orders(OrderTime,UserId,OrderSumMoney,OrderSumTotal,OrderType)" +
                    "values('{0}',{1},'{2}',{3},{4})", DateTime.Now, LoginInfo.LoginUserInfo.UserId, money, sum, 1);
                SqlCommand com = new SqlCommand(sql, con);
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
        /// 对退货表进行添加
        /// </summary>
        /// <param name="Prot_id">退货商品ID 外键</param>
        /// <param name="returnprod_sum">退货数量</param>
        /// <param name="returnprod_reason">退货原因</param>
        /// <param name="UserId">操作员ID 外键</param>
        /// <param name="returnprod_time">退货时间</param>
        /// <param name="Prot_providerId">退货商家ID</param>
        /// <returns></returns>
        public int GetReturnProductChangeBySql(int Prot_id, int returnprod_sum, string returnprod_reason, int UserId, DateTime returnprod_time, int Prot_providerId)
        {
            SqlConnection con = new SqlConnection(conStr);
            int i = 0;
            try
            {
                con.Open();
                string sql = "insert returnProduct values(@Prot_id, @returnprod_sum, @returnprod_reason, @UserId, @returnprod_time, @Prot_providerId)";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.Add("@Prot_id", SqlDbType.Int).Value = Prot_id;
                com.Parameters.Add("@returnprod_sum", SqlDbType.Int).Value = returnprod_sum;
                com.Parameters.Add("@returnprod_reason", SqlDbType.VarChar, 50).Value = returnprod_reason;
                com.Parameters.Add("@UserId", SqlDbType.Int).Value = UserId;
                com.Parameters.Add("@returnprod_time", SqlDbType.DateTime).Value = returnprod_time;
                com.Parameters.Add("@Prot_providerId", SqlDbType.Int).Value = Prot_providerId;
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