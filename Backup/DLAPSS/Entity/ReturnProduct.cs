using System;
using System.Collections.Generic;
using System.Text;

namespace DLAPSS
{
    /// <summary>
    /// �˻���
    /// </summary>
    public class ReturnProduct
    {
        private int returnprod_id;

        /// <summary>
        /// �˻�ID
        /// </summary>
        public int Returnprod_id
        {
            get { return returnprod_id; }
            set { returnprod_id = value; }
        }
        private int prot_id;

        /// <summary>
        /// �˻���ƷID ���
        /// </summary>
        public int Prot_id
        {
            get { return prot_id; }
            set { prot_id = value; }
        }
        private int returnprod_sum;

        /// <summary>
        /// �˻�����
        /// </summary>
        public int Returnprod_sum
        {
            get { return returnprod_sum; }
            set { returnprod_sum = value; }
        }
        private string returnprod_reason;

        /// <summary>
        /// �˻�ԭ��
        /// </summary>
        public string Returnprod_reason
        {
            get { return returnprod_reason; }
            set { returnprod_reason = value; }
        }
        private int userId;

        /// <summary>
        /// ����ԱID ���
        /// </summary>
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        private DateTime returnprod_time;

        /// <summary>
        /// �˻�ʱ��
        /// </summary>
        public DateTime Returnprod_time
        {
            get { return returnprod_time; }
            set { returnprod_time = value; }
        }
        private int prot_providerId;

        /// <summary>
        /// �˻��̼�ID 
        /// </summary>
        public int Prot_providerId
        {
            get { return prot_providerId; }
            set { prot_providerId = value; }
        }
    }
}
