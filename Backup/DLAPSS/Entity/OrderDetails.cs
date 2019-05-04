using System;
using System.Collections.Generic;
using System.Text;
using DLAPSS.Entity;

namespace DLAPSS
{
    /// <summary>
    /// 订单明细表
    /// </summary>
    public class OrderDetails:Orders
    {
        #region

        private string prot_name;

        /// <summary>
        /// 商品名称
        /// </summary>
        public string Prot_name
        {
            get { return prot_name; }
            set { prot_name = value; }
        }

        #endregion

        private int order_det_id;
        /// <summary>
        /// 订单明细表ID
        /// </summary>
        public int Order_det_id
        {
            get { return order_det_id; }
            set { order_det_id = value; }
        }
        private int prot_id;

        /// <summary>
        /// 商品编号ID 外键
        /// </summary>
        public int Prot_id
        {
            get { return prot_id; }
            set { prot_id = value; }
        }
        private int order_det_sum;

        /// <summary>
        /// 商品数量
        /// </summary>
        public int Order_det_sum
        {
            get { return order_det_sum; }
            set { order_det_sum = value; }
        }
    }
}