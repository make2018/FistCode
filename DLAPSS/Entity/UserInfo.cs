using System;
using System.Collections.Generic;
using System.Text;

namespace DLAPSS
{
    /// <summary>
    /// �û���
    /// </summary>
    public class UserInfo
    {
        private int userId;

        /// <summary>
        /// �û�ID
        /// </summary>
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        private string userloginId;

        /// <summary>
        /// �û���¼ID
        /// </summary>
        public string UserloginId
        {
            get { return userloginId; }
            set { userloginId = value; }
        }
        private string userName;

        /// <summary>
        /// ��ʵ����
        /// </summary>
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private string userPass;

        /// <summary>
        /// �û�����
        /// </summary>
        public string UserPass
        {
            get { return userPass; }
            set { userPass = value; }
        }
        private string userRole;

        /// <summary>
        /// �û�Ȩ��
        /// </summary>
        public string UserRole
        {
            get { return userRole; }
            set { userRole = value; }
        }
        public string UserType { get; set; }//�����ֶ�
    }
}
