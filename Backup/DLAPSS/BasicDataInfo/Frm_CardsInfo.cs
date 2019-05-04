using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DLAPSS.Entity;


namespace DLAPSS.BasicDataInfo
{
    public partial class Frm_CardsInfo : Form
    {
        public Frm_CardsInfo()
        {
            InitializeComponent();
        }
        //�������ݿ��ַ���
        private static readonly string conStr = DBHelper.conStr;
        List<CardsInfo> lc = new List<CardsInfo>();
        int type = 0;//��Ӳ��������޸Ĳ���
        /// <summary>
        /// ��տؼ�
        /// </summary>
        public void Clear()
        {
            txt_Cards_Id.Text = "";
            txt_Cards_Name.Text = "";
        }

        /// <summary>
        /// ��ʾ�ؼ�
        /// </summary>
        public void Display()
        {
            txt_Cards_Name.Enabled = true;
            tsb_Btn_Save.Enabled = true;
        }

        /// <summary>
        /// ���ؿؼ�
        /// </summary>
        public void Conceal()
        {
            txt_Cards_Name.Enabled = false;
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
        //�������
        private void Frm_CardsInfo_Load(object sender, EventArgs e)
        {
            lc = GetCardsByCards_name("");
            dgv_Cards.DataSource = lc;
            Conceal();
        }
        /// <summary>
        /// ʹ��Ʒ�����Ʋ�ѯ��Ʒ��Ϣ
        /// </summary>
        /// <param name="Cards_name">Ʒ������</param>
        /// <returns>Ʒ�Ʊ���</returns>
        public List<CardsInfo> GetCardsByCards_name(string Cards_name)
        {
            List<CardsInfo> lc = new List<CardsInfo>();
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                con.Open();
                string sql = string.Format("select * from Cards where Cardsname like '%{0}%'", Cards_name);
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    CardsInfo u = new CardsInfo();
                    u.CardsId = Convert.ToInt32(dr["Cardsid"]);
                    u.CardsName = dr["Cardsname"].ToString();
                    lc.Add(u);
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
            return lc;
        }
        //�˳�
        private void tsb_Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
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
            txt_Cards_Name.Focus();
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
            txt_Cards_Id.Text = dgv_Cards.CurrentRow.Cells[0].Value.ToString();
            txt_Cards_Name.Text = dgv_Cards.CurrentRow.Cells[1].Value.ToString();
            txt_Cards_Name.Focus();
        }
        //����
        private void tsb_Btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_Cards_Name.Text.Trim() == "" || string.IsNullOrEmpty(txt_Cards_Name.Text.Trim()))
            {
                MessageBox.Show("��Ʒ���Ʋ���Ϊ�գ�");
                return;
            }
            if (type == 0)//�޸�
            {
                string sql = string.Format("update cards set cardsname='{0}' where CardsId={1}", txt_Cards_Name.Text, Convert.ToInt32(txt_Cards_Id.Text));
                int result = executeQuery(sql);
                if (result > 0)
                {
                    MessageBox.Show("�޸ĳɹ���");
                }
                else
                {
                    MessageBox.Show("�޸�ʧ�ܣ�");
                }
            }
            else if (type == 1)
            {
                //���
                foreach (CardsInfo item in lc)
                {
                    if (item.CardsName == txt_Cards_Name.Text)
                    {
                        MessageBox.Show("����ƷƷ���Ѵ���","��ʾ");
                        return;
                    }
                }
                string sql = string.Format("insert into dbo.cards(cardsName)values('{0}');",txt_Cards_Name.Text);
                int result = executeQuery(sql);
                if (result > 0)
                {
                    MessageBox.Show("��ӳɹ���");
                }
                else
                {
                    MessageBox.Show("���ʧ�ܣ�");
                }
            }
            lc = GetCardsByCards_name("");
            dgv_Cards.DataSource = lc;
            Cancel();
        }
        //ɾ��
        private void tsb_Btn_Delete_Click(object sender, EventArgs e)
        {
            //�жϵ���ѡ������ʱ��
            if (dgv_Cards.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("ȷ��ɾ��������Ϣ��", "��ʾ", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string sql = string.Format("delete from cards where CardsId={0}", Convert.ToInt32(dgv_Cards.SelectedRows[0].Cells[0].Value));
                    int result = executeQuery(sql);
                    if (result > 0)
                    {
                        MessageBox.Show("ɾ���ɹ���", "��ʾ");
                        lc = GetCardsByCards_name("");
                        dgv_Cards.DataSource = lc;
                    }
                }
            }
        }

        // ִ����ɾ�Ĳ����ķ���
        private int executeQuery(string sql)
        {
            SqlConnection con = new SqlConnection(conStr);
            int resule = 0;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                resule = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("����Ϣ����Ʒ��Ϣ�й�������ɾ����Ʒ��Ϣ��", "��ʾ");
            }
            finally
            {
                con.Close();
            }
            return resule;
        }
        //��ѯ
        private void tsb_Btn_Lookup_Click(object sender, EventArgs e)
        {
            lc = GetCardsByCards_name(tsb_Txt_Lookup.Text);
            dgv_Cards.DataSource = lc;
        }
        //ȡ��
        private void tsb_Btn_Cancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }
    }
}