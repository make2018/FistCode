using System;
using System.Collections.Generic;
using System.Text;

namespace DLAPSS
{
    /// <summary>
    /// ����
    /// </summary>
    public class StoreRoom:ProductInfo
    {
        #region

        private int in_Out_StoreRoom;

        /// <summary>
        /// ����������
        /// </summary>
        public int In_Out_StoreRoom
        {
            get { return in_Out_StoreRoom; }
            set { in_Out_StoreRoom = value; }
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


        #endregion


        private int store_id;

        /// <summary>
        /// ���ID
        /// </summary>
        public int Store_id
        {
            get { return store_id; }
            set { store_id = value; }
        }
        private int prot_id;

        /// <summary>
        /// ��ƷID ���
        /// </summary>
        public new int Prot_id
        {
            get { return prot_id; }
            set { prot_id = value; }
        }
        private int store_sum;

        /// <summary>
        /// ��Ʒ�������
        /// </summary>
        public int Store_sum
        {
            get { return store_sum; }
            set { store_sum = value; }
        }
        private int store_lastNum;

        /// <summary>
        /// ��Ʒ���Ԥ������
        /// </summary>
        public int Store_lastNum
        {
            get { return store_lastNum; }
            set { store_lastNum = value; }
        }
    }
}
