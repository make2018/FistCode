using System;
using System.Collections.Generic;
using System.Text;

namespace DLAPSS
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class UserInfo
    {
        private int userId;

        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        private string userloginId;

        /// <summary>
        /// 用户登录ID
        /// </summary>
        public string UserloginId
        {
            get { return userloginId; }
            set { userloginId = value; }
        }
        private string userName;

        /// <summary>
        /// 真实姓名
        /// </summary>
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private string userPass;

        /// <summary>
        /// 用户密码
        /// </summary>
        public string UserPass
        {
            get { return userPass; }
            set { userPass = value; }
        }
        private string userRole;

        /// <summary>
        /// 用户权限
        /// </summary>
        public string UserRole
        {
            get { return userRole; }
            set { userRole = value; }
        }
        public string UserType { get; set; }//虚拟字段
    }
}
