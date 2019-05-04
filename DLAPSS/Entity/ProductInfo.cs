using System;
using System.Collections.Generic;
using System.Text;
using DLAPSS.Entity;
namespace DLAPSS
{
    /// <summary>
    /// ��Ʒ��
    /// </summary>
    public class ProductInfo
    {
        #region

        private string cards_name;

        /// <summary>
        /// ��ƷƷ������
        /// </summary>
        public string Cards_name
        {
            get { return cards_name; }
            set { cards_name = value; }
        }

        private string priv_name;

        /// <summary>
        /// ��Ʒ����������
        /// </summary>
        public string Priv_name
        {
            get { return priv_name; }
            set { priv_name = value; }
        }

        #endregion
        private int prot_id;

        /// <summary>
        /// ��ƷID
        /// </summary>
        public int Prot_id
        {
            get { return prot_id; }
            set { prot_id = value; }
        }
        private string prot_name;

        /// <summary>
        /// ��Ʒ����
        /// </summary>
        public string Prot_name
        {
            get { return prot_name; }
            set { prot_name = value; }
        }
        private float prot_retailprice;

        /// <summary>
        /// ���ۼ۸�
        /// </summary>
        public float Prot_retailprice
        {
            get { return prot_retailprice; }
            set { prot_retailprice = value; }
        }
        private float prot_tradeprice;

        /// <summary>
        /// �����۸�
        /// </summary>
        public float Prot_tradeprice
        {
            get { return prot_tradeprice; }
            set { prot_tradeprice = value; }
        }
        private string prot_Bigunit;

        /// <summary>
        /// ����
        /// </summary>
        public string Prot_Bigunit
        {
            get { return prot_Bigunit; }
            set { prot_Bigunit = value; }
        }
        private string prot_smallunit;

        /// <summary>
        /// С���
        /// </summary>
        public string Prot_smallunit
        {
            get { return prot_smallunit; }
            set { prot_smallunit = value; }
        }
        private int prot_rate;

        /// <summary>
        /// ����
        /// </summary>
        public int Prot_rate
        {
            get { return prot_rate; }
            set { prot_rate = value; }
        }
        /// <summary>
        /// Ʒ��
        /// </summary>
        private CardsInfo cardsInfo;
        public CardsInfo CardsInfo
        {
            get { return cardsInfo; }
            set { cardsInfo = value; }
        }      
        /// <summary>
        /// ����
        /// </summary>
        private Providers providers;

        public Providers Providers
        {
            get { return providers; }
            set { providers = value; }
        } 
        private DateTime prot_date;  
        /// <summary>
        /// ����ID ���
        /// </summary>
        private int prot_providerId;

        public int Prot_providerId
        {
            get { return prot_providerId; }
            set { prot_providerId = value; }
        }

        /// <summary>
        /// ��������
        /// </summary>
        public DateTime Prot_date
        {
            get { return prot_date; }
            set { prot_date = value; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        private string provName;

        public string ProvName
        {
            get { return provName; }
            set { provName = value; }
        }
        /// <summary>
        /// Ʒ������
        /// </summary>
        private string cardsName;

        public string CardsName
        {
            get { return cardsName; }
            set { cardsName = value; }
        }
    }
}