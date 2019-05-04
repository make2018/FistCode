using System;
using System.Collections.Generic;
using System.Text;

namespace DLAPSS
{
    public class common
    {
        /// <summary>
        /// 用户登录ID
        /// </summary>
        public static int UserId;

        /// <summary>
        /// 用户名称
        /// </summary>
        public static string UserName;

        /// <summary>
        /// 用户权限 ID
        /// </summary>
        public static string UserRole;

        /// <summary>
        /// 用户权限名称
        /// </summary>
        public static string UserRoleName;

        /// <summary>
        /// 商品名称
        /// </summary>
        public static string Prot_name = "";

        /// <summary>
        /// 库存下限
        /// </summary>
        public static int store_lastNum;

        /// <summary>
        /// 库存表 实例
        /// </summary>
        public static StoreRoom s;

        /// <summary>
        /// 退货原因
        /// </summary>
        public static string returnprod_reason;

        /// <summary>
        /// 是否查询
        /// </summary>
        public static bool Prot_EnterAndOut = false;
    }
}
