using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DLAPSS.BasicDataInfo
{
    public partial class Frm_UserInfo : Form
    {
        public Frm_UserInfo()
        {
            InitializeComponent();
        }
        int type = 0;
        List<UserInfo> lu = null;
        //�˳�
        private void tsb_Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //���
        private void tsb_Btn_Add_Click(object sender, EventArgs e)
        {
            type = 1;
            tsb_Btn_Save.Enabled = true;
            tsb_Btn_Amend.Enabled = false;
            tsb_Btn_Delete.Enabled = false;
            pnl_baseInfo.Enabled = true;
            txt_UserloginId.Enabled = true;
            txt_clear();
        }
        //ɾ��
        private void tsb_Btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_UserInfo.SelectedRows.Count > 0) 
            {
                int userId =Convert.ToInt32(dgv_UserInfo.SelectedRows[0].Cells[0].Value);
                string sql = "delete from userInfo where UserId="+userId;
                int result = GetUserInfoChangeBySql(sql);
                if (result > 0) 
                {
                    MessageBox.Show("ɾ���ɹ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    lu = GetUserInfoByUserloginIdOrUserName("");
                    dgv_UserInfo.DataSource = lu;
                    txt_clear();
                    pnl_baseInfo.Enabled = false;
                }
            }
        }
        //�޸�
        private void tsb_Btn_Amend_Click(object sender, EventArgs e)
        {
            type = 0;
            if (dgv_UserInfo.SelectedRows.Count > 0)
            {
                tsb_Btn_Save.Enabled = true;
                tsb_Btn_Add.Enabled = false;
                tsb_Btn_Delete.Enabled = false;
                pnl_baseInfo.Enabled = true;
                txt_UserloginId.Enabled = false;
                txt_UserloginId.Text = dgv_UserInfo.SelectedRows[0].Cells[1].Value.ToString();
                txt_UserName.Text = dgv_UserInfo.SelectedRows[0].Cells[2].Value.ToString();
                txt_UserPass.Text = dgv_UserInfo.SelectedRows[0].Cells[3].Value.ToString();
                if (dgv_UserInfo.SelectedRows[0].Cells["UserRole"].Value.ToString() == "2")
                    rdo_sellUser.Checked=true;
                else if (dgv_UserInfo.SelectedRows[0].Cells["UserRole"].Value.ToString() == "1")
                    rdo_buyUser.Checked=true;
            }
        }
        /// <summary>
        /// ʹ���û���¼��������ʵ������ѯ����UserInfo����Ϣ
        /// </summary>
        /// <param name="UserloginIdOrUserName">�û���¼��������ʵ����</param>
        /// <returns>UserInfo����</returns>
        public List<UserInfo> GetUserInfoByUserloginIdOrUserName(string UserloginIdOrUserName)
        {
            lu = new List<UserInfo>();
            SqlConnection con = new SqlConnection(DBHelper.conStr);
            try
            {
                con.Open();
                //��ѯ���зǳ�������Ա
                string sql = string.Format("select * from userInfo where userLoginId like '%{0}%'and userRole!=0 or userName like '%{0}%' and userRole!=0", UserloginIdOrUserName);
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    UserInfo u = new UserInfo();
                    u.UserId = Convert.ToInt32(dr["UserId"]);
                    u.UserloginId = dr["UserloginId"].ToString();
                    u.UserName = dr["UserName"].ToString();
                    u.UserPass = dr["UserPass"].ToString();
                    u.UserRole = dr["UserRole"].ToString();
                    u.UserType = dr["UserRole"].ToString() == "1" ? "����Ա" : "�ɹ�Ա";
                    lu.Add(u);
                }
                dr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ϵͳ�����쳣�������Ժ����ԣ�");
            }
            finally
            {
                con.Close();
            }
            con.Close();
            return lu;
        }

        private void Frm_UserInfo_Load(object sender, EventArgs e)
        {
            tsb_Btn_Save.Enabled = false;
            dgv_UserInfo.DataSource = GetUserInfoByUserloginIdOrUserName("");
        }
        //ȡ��
        private void tsb_Btn_Cancel_Click(object sender, EventArgs e)
        {
            tsb_Btn_Save.Enabled = false;
            tsb_Btn_Delete.Enabled = true;
            tsb_Btn_Amend.Enabled = true;
            tsb_Btn_Add.Enabled = true;
            txt_clear();
            pnl_baseInfo.Enabled = false;
        }
        private void txt_clear()
        {
            txt_UserloginId.Text = "";
            txt_UserName.Text = "";
            txt_UserPass.Text = "";
            txt_UserPass1.Text = "";
        }
        /// <summary>
        /// ��sql�����������޸Ĳ����
        /// </summary>
        /// <param name="sql">sql���</param>
        /// <param name="UserloginId">��¼�˺�</param>
        /// <param name="UserName">��ʵ����</param>
        /// <param name="UserPass">����</param>
        /// <param name="UserRole">Ȩ��</param>
        /// <returns>sql���Ӱ�������</returns>
        public int GetUserInfoChangeBySql(string sql)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(DBHelper.conStr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(sql, con);
                i = com.ExecuteNonQuery();
             
            }
            catch (Exception)
            {
               MessageBox.Show("ϵͳ�����쳣�������Ժ����ԣ�");
            }
            finally
            {
                con.Close();
            }
            return i;
        }
        public bool Vail() 
        {
            if (txt_UserloginId.Text.Trim() == "" || String.IsNullOrEmpty(txt_UserloginId.Text)) 
            {
                MessageBox.Show("�������û�����","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                return false;
            }
            else if (txt_UserName.Text.Trim() == "" || String.IsNullOrEmpty(txt_UserName.Text)) 
            {
                MessageBox.Show("��������ʵ������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (txt_UserPass.Text.Trim() == "" || String.IsNullOrEmpty(txt_UserPass.Text)) 
            {
                MessageBox.Show("���������룡", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (!txt_UserPass1.Text.Trim().Equals(txt_UserPass.Text.Trim()))
            {
                MessageBox.Show("�������벻һ�£�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else 
            {
             return true;
            }
        }
        //����
        private void tsb_Btn_Save_Click(object sender, EventArgs e)
        {
            if (type == 0)
            {
                if (Vail())
                {
                    int userRole = rdo_buyUser.Checked == true ? 2 : 1;
                    string sql = string.Format("update userInfo set UserName='{0}',UserPass='{1}',userrole={3} where UserloginId='{2}'", txt_UserName.Text, txt_UserPass.Text, txt_UserloginId.Text, userRole);
                   int result=GetUserInfoChangeBySql(sql);
                   if (result > 0)
                   {
                       MessageBox.Show("�޸ĳɹ���","��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                       lu=GetUserInfoByUserloginIdOrUserName("");
                       dgv_UserInfo.DataSource = lu;
                       txt_clear();
                       pnl_baseInfo.Enabled = false;
                       tsb_Btn_Delete.Enabled = true;
                   }
                }
            }
            else if (type == 1) 
            {
                if (Vail()) 
                {
                    int userRole = rdo_buyUser.Checked == true ? 2 : 1;
                    string sql = string.Format("insert into dbo.userInfo(UserloginId,UserName,UserPass,UserRole)values('{0}','{1}','{2}',{3})", txt_UserloginId.Text, txt_UserName.Text, txt_UserPass.Text, userRole);
                    foreach (UserInfo item in lu)
                    {
                        if (item.UserloginId.Equals(txt_UserloginId.Text)) 
                        {
                            MessageBox.Show("���û��Ѵ��ڣ����޸ĵ�¼��","��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            return;
                        }
                    }
                    int result = GetUserInfoChangeBySql(sql);
                    if (result > 0) 
                    {
                        MessageBox.Show("��ӳɹ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        lu = GetUserInfoByUserloginIdOrUserName("");
                        dgv_UserInfo.DataSource = lu;
                        txt_clear();
                        pnl_baseInfo.Enabled = false;
                    }
                }
            }
        }
        //����������ѯ
        private void tsb_Btn_Lookup_Click(object sender, EventArgs e)
        {
            if (tsb_Txt_Lookup.Text.Trim() == "")
            {
                MessageBox.Show("�������ѯ������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                lu=GetUserInfoByUserloginIdOrUserName(tsb_Txt_Lookup.Text);
                dgv_UserInfo.DataSource = lu;
            }
        }
    }
}