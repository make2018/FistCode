using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DLAPSS.Entity;
using System.Data.SqlClient;

namespace DLAPSS.Statistic.Store_Statistic
{
    public partial class Frm_Store_Statistic_Enter : Form
    {
        public Frm_Store_Statistic_Enter()
        {
            InitializeComponent();
        }
        private void Frm_Store_Statistic_Enter_Load(object sender, EventArgs e)
        {
            dgv_Orders_Details.AutoGenerateColumns = false;
            dgv_Orders_Details.DataSource =GetOrders(0, dtp_Begin.Value, dtp_End.Value);
        }


        private void btt_Detailed_Click(object sender, EventArgs e)
        {
            if (dgv_Orders_Details.Columns["cl_Order_sum_money"].Visible)
            {
                dgv_Orders_Details.Columns["cl_Order_sum_money"].Visible = false;
                dgv_Orders_Details.Columns["cl_Order_sum_total"].Visible = false;

                dgv_Orders_Details.Columns["cl_order_det_id"].Visible = true;
                dgv_Orders_Details.Columns["cl_Prot_name"].Visible = true;
                dgv_Orders_Details.Columns["cl_order_det_sum"].Visible = true;
                btt_Detailed.Text = "显示订单总表";
                gb_Statistic.Text = "采购入库订单明细表统计数据：";
                dgv_Orders_Details.DataSource = null;
                dgv_Orders_Details.DataSource = GetOrderDetails(0, dtp_Begin.Value, dtp_End.Value);

            }
            else
            {
                dgv_Orders_Details.Columns["cl_Order_sum_money"].Visible = true;
                dgv_Orders_Details.Columns["cl_Order_sum_total"].Visible = true;

                dgv_Orders_Details.Columns["cl_order_det_id"].Visible = false;
                dgv_Orders_Details.Columns["cl_Prot_name"].Visible = false;
                dgv_Orders_Details.Columns["cl_order_det_sum"].Visible = false;
                btt_Detailed.Text = "显示订单表明细";
                gb_Statistic.Text = "采购入库订单总表统计数据：";
                dgv_Orders_Details.DataSource = null;
                dgv_Orders_Details.DataSource = GetOrders(0, dtp_Begin.Value, dtp_End.Value);
            }
        }

        private void dtp_Begin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void dtp_End_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (gb_Statistic.Text == "采购入库订单明细表统计数据：")
                {
                    dgv_Orders_Details.DataSource = null;
                    dgv_Orders_Details.DataSource = GetOrderDetails(0, dtp_Begin.Value, dtp_End.Value);
                }
                else
                {
                    dgv_Orders_Details.DataSource = null;
                    dgv_Orders_Details.DataSource = GetOrders(0, dtp_Begin.Value, dtp_End.Value);
                }
            }
        }
        /// <summary>
        /// 查询订单总表
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="Order_type">该订单类型 0进货 1退货 2 销售 3销售退货</param>
        /// <param name="Begin">开始时间</param>
        /// <param name="End">结束时间</param>
        /// <returns></returns>
        public List<Orders> GetOrders(int Order_type, DateTime Begin, DateTime End)
        {
            string sql = string.Format("select orders.*,userInfo.UserName from orders,userInfo where orders.UserId=userInfo.UserId  and Ordertype={0}", Order_type);
            List<Orders> lo = new List<Orders>();
            SqlConnection con = new SqlConnection(DBHelper.conStr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    Orders o = new Orders();
                    o.Order_id = Convert.ToInt32(dr["Orderid"]);
                    o.Order_sum_money = Convert.ToSingle(dr["Ordersummoney"]);
                    o.Order_sum_total = Convert.ToInt32(dr["Ordersumtotal"]);
                    o.Order_time = Convert.ToDateTime(dr["Ordertime"]);
                    o.Order_type = Convert.ToInt32(dr["Ordertype"]);
                    o.UserId = Convert.ToInt32(dr["UserId"]);
                    o.UserName = dr["UserName"].ToString();
                    lo.Add(o);
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
            return lo;
        }
        /// <summary>
        /// 查询订单总表或者明细表
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="Order_type">该订单类型 0进货 1退货 2 销售 3销售退货</param>
        /// <param name="Begin">开始时间</param>
        /// <param name="End">结束时间</param>
        /// <returns></returns>
        public List<OrderDetails> GetOrderDetails(int Order_type, DateTime Begin, DateTime End)
        {
            string sql = "select orders.*,orderDetails.*,userInfo.UserName,productInfo.Protname from orderDetails,orders,productInfo,userInfo where orderDetails.Orderid=orders.Orderid and orderDetails.Protid=productInfo.Protid and orders.UserId=userInfo.UserId and orders.Ordertype=@Order_type";
            List<OrderDetails> lo = new List<OrderDetails>();
            SqlConnection con = new SqlConnection(DBHelper.conStr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.Add("@Order_type", SqlDbType.Int).Value = Order_type;
                //com.Parameters.Add("@Begin", SqlDbType.DateTime).Value = Begin;
                //com.Parameters.Add("@End", SqlDbType.DateTime).Value = End;
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    OrderDetails o = new OrderDetails();
                    o.Order_det_id = Convert.ToInt32(dr["orderdetid"]);
                    o.Order_det_sum = Convert.ToInt32(dr["orderdetsum"]);
                    o.Order_id = Convert.ToInt32(dr["Orderid"]);
                    o.Order_sum_money = Convert.ToSingle(dr["Ordersummoney"]);
                    o.Order_sum_total = Convert.ToInt32(dr["Ordersumtotal"]);
                    o.Order_time = Convert.ToDateTime(dr["Ordertime"]);
                    o.Order_type = Convert.ToInt32(dr["Ordertype"]);
                    o.Prot_id = Convert.ToInt32(dr["Protid"]);
                    o.Prot_name = dr["Protname"].ToString();
                    o.UserId = Convert.ToInt32(dr["UserId"]);
                    o.UserName = dr["UserName"].ToString();
                    lo.Add(o);
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
            return lo;
        }
    }
}