using System;
using System.Collections.Generic;
using System.Text;
using DLAPSS.Entity;

namespace DLAPSS
{
    /// <summary>
    /// ������ϸ��
    /// </summary>
    public class OrderDetails:Orders
    {
        #region

        private string prot_name;

        /// <summary>
        /// ��Ʒ����
        /// </summary>
        public string Prot_name
        {
            get { return prot_name; }
            set { prot_name = value; }
        }

        #endregion

        private int order_det_id;
        /// <summary>
        /// ������ϸ��ID
        /// </summary>
        public int Order_det_id
        {
            get { return order_det_id; }
            set { order_det_id = value; }
        }
        private int prot_id;

        /// <summary>
        /// ��Ʒ���ID ���
        /// </summary>
        public int Prot_id
        {
            get { return prot_id; }
            set { prot_id = value; }
        }
        private int order_det_sum;

        /// <summary>
        /// ��Ʒ����
        /// </summary>
        public int Order_det_sum
        {
            get { return order_det_sum; }
            set { order_det_sum = value; }
        }
    }
}