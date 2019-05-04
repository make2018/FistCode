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
    public partial class Frm_ProvidersInfo : Form
    {
        public Frm_ProvidersInfo()
        {
            InitializeComponent();
        }
        private static readonly string conStr = DBHelper.conStr;
        List<Providers> lp = new List<Providers>();
        int type = 0;
        /// <summary>
        /// ��տؼ�
        /// </summary>
        public void Clear()
        {
            txt_Priv_adr.Text = "";
            txt_Priv_linkMan.Text = "";
            txt_Priv_name.Text = "";
            txt_Priv_tel.Text = "";
            lb_Priv_id.Text = "0";
        }

        /// <summary>
        /// ��ʾ�ؼ�
        /// </summary>
        public void Display()
        {
            txt_Priv_adr.Enabled = true;
            txt_Priv_linkMan.Enabled = true;
            txt_Priv_name.Enabled = true;
            txt_Priv_tel.Enabled = true;
            tsb_Btn_Save.Enabled = true;
        }

        /// <summary>
        /// ���ؿؼ�
        /// </summary>
        public void Conceal()
        {
            txt_Priv_adr.Enabled = false;
            txt_Priv_linkMan.Enabled = false;
            txt_Priv_name.Enabled = false;
            txt_Priv_tel.Enabled = false;
            tsb_Btn_Save.Enabled = false;
        }

        /// <summary>
        /// ȡ��
        /// </summary>
        public void Cancel()
        {
            tsb_Btn_Add.Enabled = true;
            tsb_Btn_Amend.Enabled = true;
            tsb_Btn_Save.Enabled = true;
            tsb_Btn_Delete.Enabled = true;
            tsb_Txt_Lookup.Enabled = true;
            tsb_Btn_Lookup.Enabled = true;
            Clear();
            Conceal();
        }
        //ɾ��
        private void tsb_Btn_Delete_Click(object sender, EventArgs e)
        {
            string sql = " delete from providers where PrivId=" + Convert.ToInt32(dgv_Providers.CurrentRow.Cells[0].Value);
            DialogResult dr = MessageBox.Show("��ȷ��Ҫɾ������Ϣ��", "��ʾ", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                int result = GetProvidersChangeBySql(sql);
                if (result > 0)
                {
                    MessageBox.Show("ɾ���ɹ���", "��ʾ");
                    lp = GetProvidersByPriv_name("");
                    dgv_Providers.DataSource = lp;
                }
                else
                {
                    MessageBox.Show("����Ϣ����Ʒ��Ϣ�й�������ɾ����Ʒ��Ϣ��", "��ʾ");
                }
            }
        }

        public int GetProvidersChangeBySql(string sql)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(sql, con);
                i = com.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("ϵͳ��æ,���Ժ�����!", "��ʾ");
            }
            finally
            {
                con.Close();
            }
            return i;
        }
        /// <summary>
        /// ʹ�ù��������Ʋ��ҹ�������Ϣ
        /// </summary>
        /// <param name="Priv_name">����������</param>
        /// <returns>�����̱���</returns>
        public List<Providers> GetProvidersByPriv_name(string Priv_name)
        {
            List<Providers> lp = new List<Providers>();
            //�������ݿ�Ӷ���
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                //������
                con.Open();
                string sql = "select * from providers where Privname like '%'+@Priv_name+'%'";
                //��������ִ�ж���
                SqlCommand com = new SqlCommand(sql, con);
                //��Ӳ���
                com.Parameters.Add("@Priv_name", SqlDbType.VarChar, 50).Value = Priv_name;
                //��ȡ���ݶ�ȡ����
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
                //�ر����ݶ�ȡ����
                dr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ϵͳ�����쳣�������Ժ����ԣ�");
            }
            finally 
            {
                //�ر����ݿ�����
                con.Close();
            }
            return lp;
        }
        //�������
        private void Frm_ProvidersInfo_Load(object sender, EventArgs e)
        {
            tsb_Btn_Save.Enabled = false;
            Conceal();
            lp = GetProvidersByPriv_name("");
            dgv_Providers.DataSource = lp;
        }
        //���ݳ������Ʋ�ѯ
        private void tsb_Btn_Lookup_Click(object sender, EventArgs e)
        {
            lp = GetProvidersByPriv_name(tsb_Txt_Lookup.Text);
            dgv_Providers.DataSource = lp;
        }
        //���
        private void tsb_Btn_Add_Click(object sender, EventArgs e)
        {
            type = 1;
            Display();
            tsb_Btn_Amend.Enabled = false;
            tsb_Txt_Lookup.Enabled = false;
            tsb_Btn_Delete.Enabled = false;
            tsb_Btn_Lookup.Enabled = false;
            txt_Priv_name.Focus();
        }
        //�޸�
        private void tsb_Btn_Amend_Click(object sender, EventArgs e)
        {
            type = 0;
            Display();
            tsb_Btn_Add.Enabled = false;
            tsb_Btn_Delete.Enabled = false;
            tsb_Txt_Lookup.Enabled = false;
            tsb_Btn_Lookup.Enabled = false;
            txt_Priv_name.Text = dgv_Providers.CurrentRow.Cells[1].Value.ToString();
            txt_Priv_adr.Text = dgv_Providers.CurrentRow.Cells[4].Value.ToString();
            txt_Priv_linkMan.Text = dgv_Providers.CurrentRow.Cells[2].Value.ToString();
            txt_Priv_tel.Text = dgv_Providers.CurrentRow.Cells[3].Value.ToString();
            txt_Priv_name.Focus();
        }
        //ȡ��
        private void tsb_Btn_Cancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }
        //�˳�
        private void tsb_Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //����
        private void tsb_Btn_Save_Click(object sender, EventArgs e)
        {
            if (vailInput())
            {
                if (type == 0)
                {
                    string sql = string.Format("update providers set PrivName='{0}',PrivLinkMan='{1}',PrivTel='{2}',PrivAdr='{3}' where PrivId={4}", txt_Priv_name.Text, txt_Priv_linkMan.Text, txt_Priv_tel.Text, txt_Priv_adr.Text, Convert.ToInt32(dgv_Providers.CurrentRow.Cells[0].Value));
                    int result = GetProvidersChangeBySql(sql);
                    if (result > 0)
                    {
                        MessageBox.Show("�޸ĳɹ���", "��ʾ");
                        lp = GetProvidersByPriv_name("");
                        dgv_Providers.DataSource = lp;
                    }
                }
                else if (type == 1)
                {


                    string sql = string.Format
                        ("insert into providers(PrivName,PrivLinkMan,PrivTel,PrivAdr)" +
                        "values('{0}','{1}','{2}','{3}')",
                        txt_Priv_name.Text, txt_Priv_linkMan.Text, txt_Priv_tel.Text, txt_Priv_adr.Text);
                    foreach (Providers item in lp)
                    {
                        if (item.Priv_name == txt_Priv_name.Text)
                        {
                            MessageBox.Show("��Ҫ��ӵ���Ϣ�Ѵ��ڣ�", "��ʾ");
                            return;
                        }
                    }
                    int result = GetProvidersChangeBySql(sql);
                    if (result > 0)
                    {
                        MessageBox.Show("��ӳɹ���", "��ʾ");
                        lp = GetProvidersByPriv_name("");
                        dgv_Providers.DataSource = lp;
                    }

                }
                Cancel();
                Clear();
            }
        }
        //�ǿ���֤
        private bool vailInput()
        {
            if (txt_Priv_adr.Text.Trim() == "")
            {
                MessageBox.Show("��ַ����Ϊ�գ�","��ʾ");
                return false;
            }
            if (txt_Priv_linkMan.Text.Trim() == "")
            {
                MessageBox.Show("��ϵ�˲���Ϊ�գ�", "��ʾ");
                return false;
            }
            if (txt_Priv_name.Text.Trim() == "")
            {
                MessageBox.Show("�������Ʋ���Ϊ�գ�", "��ʾ");
                return false;
            }
            if (txt_Priv_tel.Text.Trim() == "")
            {
                MessageBox.Show("��ϵ�绰����Ϊ�գ�", "��ʾ");
                return false;
            }
            return true;
        }
        }
}