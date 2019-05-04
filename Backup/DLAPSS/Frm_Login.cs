using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DLAPSS
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        //��¼
        private void btt_Login_Click(object sender, EventArgs e)
        {
            loginValidate();
        }
        /// <summary>
        /// ��¼��֤����
        /// </summary>
        public void loginValidate()
        {
            if (txt_UserloginId.Text.Trim() == "" || string.IsNullOrEmpty(txt_UserloginId.Text))
            {
                MessageBox.Show("�û�������Ϊ�գ�", "��¼��ʾ");
                txt_UserloginId.Focus();
            }
            else if (txt_UserPass.Text.Trim() == "" || string.IsNullOrEmpty(txt_UserPass.Text))
            {
                MessageBox.Show("���벻��Ϊ�գ�", "��¼��ʾ");
                txt_UserPass.Focus();
            }
            else if (cbo_loginType.Text.Trim() == "" || string.IsNullOrEmpty(cbo_loginType.Text.Trim()))
            {
                MessageBox.Show("��ѡ���¼���ͣ�", "��¼��ʾ");
            }
            else
            {
                UserInfo u = null;
                SqlConnection con = new SqlConnection(DBHelper.conStr);
                try
                {   
                   
                    con.Open();
                    int userRole = cbo_loginType.SelectedIndex;
                    string sql = string.Format("select * from userInfo where UserloginId='{0}' and UserPass='{1}' and UserRole={2}", txt_UserloginId.Text, txt_UserPass.Text,userRole);
                    SqlCommand com = new SqlCommand(sql, con);
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.Read())
                    {
                        u = new UserInfo();
                        u.UserId = Convert.ToInt32(dr["UserId"]);
                        u.UserloginId = dr["UserloginId"].ToString();
                        u.UserName = dr["UserName"].ToString();
                        u.UserPass = dr["UserPass"].ToString();
                        u.UserRole = dr["UserRole"].ToString();
                    }
                    dr.Close();
                    if (u != null)
                    {
                        LoginInfo.LoginUserInfo = u;//�����¼�û���Ϣ
                        this.Visible = false;
                        Frm_Main fm = new Frm_Main();
                        fm.Show();
                    }
                    else
                    {
                        MessageBox.Show("�û������������", "��¼��ʾ");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("��ע�����ݿ������ַ�����", "��¼��ʾ");
                }
                finally
                {
                    con.Close();
                }
            }
        }
        //����
        private void btt_Reset_Click(object sender, EventArgs e)
        {
            txt_UserloginId.Text = "";
            txt_UserPass.Text = "";
            txt_UserloginId.Focus();
        }

        private void cbo_loginType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//������س���
            {
                if (txt_UserloginId.Text != "" && txt_UserPass.Text != "")
                    loginValidate();
                else
                    SendKeys.Send("{TAB}");
            }
        }
    }
}