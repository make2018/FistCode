using System;
using System.Collections.Generic;
using System.Text;

namespace DLAPSS
{
    /// <summary>
    /// 厂家表
    /// </summary>
    public class Providers
    {
        private int priv_id;

        /// <summary>
        /// 厂家ID
        /// </summary>
        public int Priv_id
        {
            get { return priv_id; }
            set { priv_id = value; }
        }
        private string priv_name;

        /// <summary>
        /// 厂家名称
        /// </summary>
        public string Priv_name
        {
            get { return priv_name; }
            set { priv_name = value; }
        }
        private string priv_linkMan;

        /// <summary>
        /// 厂家联系人
        /// </summary>
        public string Priv_linkMan
        {
            get { return priv_linkMan; }
            set { priv_linkMan = value; }
        }
        private string priv_tel;

        /// <summary>
        /// 电话
        /// </summary>
        public string Priv_tel
        {
            get { return priv_tel; }
            set { priv_tel = value; }
        }
        private string priv_adr;

        /// <summary>
        /// 厂家地址
        /// </summary>
        public string Priv_adr
        {
            get { return priv_adr; }
            set { priv_adr = value; }
        }
    }
}
