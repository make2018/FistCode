using System;
using System.Collections.Generic;
using System.Text;

namespace DLAPSS.Entity
{
    /// <summary>
    /// 订单总表
    /// </summary>
    public class Orders
    {
        #region

        private string userName;

        /// <summary>
        /// 操作员名称
        /// </summary>
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        #endregion

        private int order_id;

        /// <summary>
        /// 订单总表ID
        /// </summary>
        public int Order_id
        {
            get { return order_id; }
            set { order_id = value; }
        }
        private DateTime order_time;

        /// <summary>
        /// 订单时间
        /// </summary>
        public DateTime Order_time
        {
            get { return order_time; }
            set { order_time = value; }
        }
        private int userId;

        /// <summary>
        /// 操作员ID
        /// </summary>
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        private float order_sum_money;

        /// <summary>
        /// 该订单商品总价
        /// </summary>
        public float Order_sum_money
        {
            get { return order_sum_money; }
            set { order_sum_money = value; }
        }
        private int order_sum_total;

        /// <summary>
        /// 该订单商品总数量
        /// </summary>
        public int Order_sum_total
        {
            get { return order_sum_total; }
            set { order_sum_total = value; }
        }
        private int order_type;

        /// <summary>
        /// 该订单类型 0进货 1退货 2 销售 3销售退货
        /// </summary>
        public int Order_type
        {
            get { return order_type; }
            set { order_type = value; }
        }
    }
}
