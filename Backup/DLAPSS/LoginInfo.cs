using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DLAPSS.Entity;
using System.Data;

namespace DLAPSS
{
    public class LoginInfo
    {
       public static UserInfo LoginUserInfo;
       //连接数据库字符串
       private static readonly string conStr = DBHelper.conStr;
       /// <summary>
       /// 使用品牌名称查询商品信息
       /// </summary>
       /// <param name="Cards_name">品牌名称</param>
       /// <returns>品牌表集合</returns>
       public static List<CardsInfo> GetCardsByCards_name(string Cards_name)
       {
           List<CardsInfo> lc = new List<CardsInfo>();
           SqlConnection con = new SqlConnection(conStr);
           con.Open();
           string sql = "select * from Cards where Cardsname like '%'+@Cardsname+'%'";
           SqlCommand com = new SqlCommand(sql, con);
           com.Parameters.Add("@Cardsname", SqlDbType.VarChar, 50).Value = Cards_name;
           SqlDataReader dr = com.ExecuteReader();
           while (dr.Read())
           {
               CardsInfo cardsInfo = new CardsInfo();
               cardsInfo.CardsId = Convert.ToInt32(dr["Cardsid"]);
               cardsInfo.CardsName = dr["Cardsname"].ToString();
               lc.Add(cardsInfo);
           }
           dr.Close();
           con.Close();
           return lc;
       }
       /// <summary>
       /// 使用供货商名称查找供货商信息
       /// </summary>
       /// <param name="Priv_name">供货商名称</param>
       /// <returns>供货商表集合</returns>
       public static List<Providers> GetProvidersByPriv_name(string Privname)
       {
           List<Providers> lp = new List<Providers>();
           SqlConnection con = new SqlConnection(conStr);
           con.Open();
           string sql = "select * from providers where Privname like '%'+Privname+'%'";
           SqlCommand com = new SqlCommand(sql, con);
           SqlDataReader dr = com.ExecuteReader();
           while (dr.Read())
           {
               Providers p = new Providers();
               p.Priv_id = Convert.ToInt32(dr["Privid"]);
               p.Priv_name = dr["Privname"].ToString();
               p.Priv_linkMan = dr["PrivlinkMan"].ToString();
               p.Priv_tel = dr["Privtel"].ToString();
               p.Priv_adr = dr["Privadr"].ToString();
               lp.Add(p);
           }
           dr.Close();
           con.Close();
           return lp;
       }
    }
}
