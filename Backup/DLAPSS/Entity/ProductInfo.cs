using System;
using System.Collections.Generic;
using System.Text;
using DLAPSS.Entity;
namespace DLAPSS
{
    /// <summary>
    /// 商品表
    /// </summary>
    public class ProductInfo
    {
        #region

        private string cards_name;

        /// <summary>
        /// 商品品牌名称
        /// </summary>
        public string Cards_name
        {
            get { return cards_name; }
            set { cards_name = value; }
        }

        private string priv_name;

        /// <summary>
        /// 商品供货商名称
        /// </summary>
        public string Priv_name
        {
            get { return priv_name; }
            set { priv_name = value; }
        }

        #endregion
        private int prot_id;

        /// <summary>
        /// 商品ID
        /// </summary>
        public int Prot_id
        {
            get { return prot_id; }
            set { prot_id = value; }
        }
        private string prot_name;

        /// <summary>
        /// 商品名称
        /// </summary>
        public string Prot_name
        {
            get { return prot_name; }
            set { prot_name = value; }
        }
        private float prot_retailprice;

        /// <summary>
        /// 零售价格
        /// </summary>
        public float Prot_retailprice
        {
            get { return prot_retailprice; }
            set { prot_retailprice = value; }
        }
        private float prot_tradeprice;

        /// <summary>
        /// 批发价格
        /// </summary>
        public float Prot_tradeprice
        {
            get { return prot_tradeprice; }
            set { prot_tradeprice = value; }
        }
        private string prot_Bigunit;

        /// <summary>
        /// 大规格
        /// </summary>
        public string Prot_Bigunit
        {
            get { return prot_Bigunit; }
            set { prot_Bigunit = value; }
        }
        private string prot_smallunit;

        /// <summary>
        /// 小规格
        /// </summary>
        public string Prot_smallunit
        {
            get { return prot_smallunit; }
            set { prot_smallunit = value; }
        }
        private int prot_rate;

        /// <summary>
        /// 倍率
        /// </summary>
        public int Prot_rate
        {
            get { return prot_rate; }
            set { prot_rate = value; }
        }
        /// <summary>
        /// 品牌
        /// </summary>
        private CardsInfo cardsInfo;
        public CardsInfo CardsInfo
        {
            get { return cardsInfo; }
            set { cardsInfo = value; }
        }      
        /// <summary>
        /// 厂商
        /// </summary>
        private Providers providers;

        public Providers Providers
        {
            get { return providers; }
            set { providers = value; }
        } 
        private DateTime prot_date;  
        /// <summary>
        /// 厂商ID 外键
        /// </summary>
        private int prot_providerId;

        public int Prot_providerId
        {
            get { return prot_providerId; }
            set { prot_providerId = value; }
        }

        /// <summary>
        /// 出产日期
        /// </summary>
        public DateTime Prot_date
        {
            get { return prot_date; }
            set { prot_date = value; }
        }
        /// <summary>
        /// 厂商名称
        /// </summary>
        private string provName;

        public string ProvName
        {
            get { return provName; }
            set { provName = value; }
        }
        /// <summary>
        /// 品牌名称
        /// </summary>
        private string cardsName;

        public string CardsName
        {
            get { return cardsName; }
            set { cardsName = value; }
        }
    }
}