using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DLAPSS.Entity;

namespace DLAPSS.Store
{
    public partial class Frm_StoreQuery : Form
    {
        public Frm_StoreQuery()
        {
            InitializeComponent();
        }
        //���ݿ������ַ���
        private static readonly string conStr = DBHelper.conStr;
        List<StoreRoom> ls = new List<StoreRoom>();
        //�������
        private void Frm_StoreQuery_Load(object sender, EventArgs e)
        {
            dgv_Store.AutoGenerateColumns = false;
            ls = GetStoreRoomByProt_Name(common.Prot_name);
            dgv_Store.DataSource = ls;
            if (common.Prot_EnterAndOut)
            {
                tsb_Btn_Amend.Visible = false;
                tsb_Btn_Cancel.Visible = false;
                tsb_Btn_Delete.Visible = false;
                tsb_Btn_Lookup.Visible = false;
                tsb_Txt_Lookup.Visible = false;
                common.Prot_EnterAndOut = false;
            }
            common.Prot_name = "";
        }
        /// <summary>
        /// ʹ����Ʒ���Ʋ�ѯ�����Ϣ
        /// </summary>
        /// <param name="Prot_Name">��Ʒ����</param>
        /// <returns></returns>
        public List<StoreRoom> GetStoreRoomByProt_Name(string Prot_Name)
        {
            List<StoreRoom> ls = new List<StoreRoom>();
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                con.Open();
                string sql = string.Format("select productInfo.*,Cards.Cardsname,providers.Privname,storeRoom.storelastNum,storeRoom.storesum,storeRoom.storeid  from productInfo,Cards,providers,storeRoom where productInfo.ProtCard=Cards.Cardsid and productInfo.ProtproviderId=providers.Privid and productInfo.Protid=storeRoom.Protid and productInfo.Protname like '%{0}%'", Prot_Name);
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    StoreRoom sr = new StoreRoom();
                    sr.Prot_id = Convert.ToInt32(dr["Protid"]);
                    sr.Prot_name = dr["Protname"].ToString();
                    sr.Prot_retailprice = Convert.ToSingle(dr["Protretailprice"]);
                    sr.Prot_tradeprice = Convert.ToSingle(dr["Prottradeprice"]);
                    sr.Prot_Bigunit = dr["ProtBigunit"].ToString();
                    sr.Prot_smallunit = dr["Protsmallunit"].ToString();
                    sr.Prot_rate = Convert.ToInt32(dr["ProtRate"]);
                    CardsInfo cardsInfo = new CardsInfo();
                    cardsInfo.CardsId = Convert.ToInt32(dr["ProtCard"]);
                    Providers providers = new Providers();
                    providers.Priv_id = Convert.ToInt32(dr["ProtproviderId"]);
                    sr.Prot_date = Convert.ToDateTime(dr["Protdate"]);
                    sr.Cards_name = dr["Cardsname"].ToString();
                    sr.Priv_name = dr["Privname"].ToString();
                    sr.Store_id = Convert.ToInt32(dr["storeid"]);
                    sr.Store_sum = Convert.ToInt32(dr["storesum"]);
                    sr.Store_lastNum = Convert.ToInt32(dr["storelastNum"]);
                    ls.Add(sr);
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
            return ls;
        }

        /// <summary>
        /// ����Ʒ����ɾ��
        /// </summary>
        /// <param name="Prot_id">��Ҫɾ������Ʒ��ID</param>
        /// <returns>sql���Ӱ�������</returns>
        public int GetstoreRoomDeleteByProt_id(int Prot_id)
        {
            SqlConnection con = new SqlConnection(conStr);
            int i = 0;
            try
            {
                con.Open();
                string sql = "delete from storeRoom where Prot_id=@Prot_id";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.Add("@Prot_id", SqlDbType.Int).Value = Prot_id;
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
        //�����¼�
        private void dgv_Store_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int i = Convert.ToInt32(dgv_Store.CurrentRow.Cells[0].Value);
                foreach (StoreRoom var in ls)
                {
                    if (var.Prot_id == i)
                    {
                        common.s = var;
                        break;
                    }
                }
                this.Close();
            }
        }
        //�޸�
        private void tsb_Btn_Amend_Click(object sender, EventArgs e)
        {
            Frm_Store_LastNum FsL = new Frm_Store_LastNum();
            FsL.ShowDialog();
            string sql =string.Format("update storeRoom set storelastNum={0} where Protid={1}",common.store_lastNum,Convert.ToInt32(dgv_Store.CurrentRow.Cells[0].Value));
            int result = executeQuery(sql);
            if (result > 0)
            {
                MessageBox.Show("�޸ĳɹ�", "��ʾ");
            }
            else 
            {
                MessageBox.Show("�޸�ʧ��","��ʾ");
            }
            ls = GetStoreRoomByProt_Name(common.Prot_name);
            dgv_Store.DataSource = ls;
        }
        public int executeQuery(string sql) 
        {
            int result = 0;
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("ϵͳ��æ��", "��ʾ");
            }
            finally 
            {
                con.Close();
            }
            return result;
        }
        //ɾ��
        private void tsb_Btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Store.SelectedRows.Count > 0) 
            {
                string sql = "delete from storeRoom where Protid="+Convert.ToInt32(dgv_Store.CurrentRow.Cells[0].Value);
                int result = executeQuery(sql);
                if (result > 0)
                {
                    MessageBox.Show("ɾ���ɹ�", "��ʾ");
                }
                else
                {
                    MessageBox.Show("ɾ��ʧ��", "��ʾ");
                }
                ls = GetStoreRoomByProt_Name(common.Prot_name);
                dgv_Store.DataSource = ls;
            }
        }
        //�˳�
        private void tsb_Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //��ѯ
        private void tsb_Btn_Lookup_Click(object sender, EventArgs e)
        {
            ls = GetStoreRoomByProt_Name(tsb_Txt_Lookup.Text);
            dgv_Store.DataSource = ls;
        }
    }
}