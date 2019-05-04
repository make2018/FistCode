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
    public partial class Frm_ProductInfo : Form
    {
        public Frm_ProductInfo()
        {
            InitializeComponent();
        }
        //�������ݿ��ַ���
        private static readonly string conStr = DBHelper.conStr;
        List<ProductInfo> lp = new List<ProductInfo>();
        int type = 0;
        /// <summary>
        /// ���ؿؼ�
        /// </summary>
        private void Conceal()
        {
            txt_Prot_Bigunit.Enabled = false;
            txt_Prot_Name.Enabled = false;
            txt_Prot_Rate.Enabled = false;
            txt_Prot_Retailprice.Enabled = false;
            txt_Prot_Smallunit.Enabled = false;
            txt_Prot_Tradeprice.Enabled = false;
            dtp_Prot_Date.Enabled = false;
            cbb_Cards_Name.Enabled = false;
            cbb_Priv_Name.Enabled = false;
            txt_Store_LastNum.Enabled = false;
            tsb_Btn_Save.Enabled = false;
        }
        /// <summary>
        /// ��ʾ�ؼ�
        /// </summary>
        private void Display()
        {
            txt_Prot_Bigunit.Enabled = true;
            txt_Prot_Name.Enabled = true;
            txt_Prot_Rate.Enabled = true;
            txt_Prot_Retailprice.Enabled = true;
            txt_Prot_Smallunit.Enabled = true;
            txt_Prot_Tradeprice.Enabled = true;
            dtp_Prot_Date.Enabled = true;
            cbb_Cards_Name.Enabled = true;
            cbb_Priv_Name.Enabled = true;
            txt_Store_LastNum.Enabled = true;
        }
        /// <summary>
        /// ��տؼ�����
        /// </summary>
        private void Clear()
        {
            txt_Prot_Tradeprice.Text = "";
            txt_Prot_Smallunit.Text = "";
            txt_Prot_Retailprice.Text = "";
            txt_Prot_Rate.Text = "";
            txt_Prot_Name.Text = "";
            txt_Prot_Bigunit.Text = "";
            cbb_Cards_Name.Text = "";
            cbb_Priv_Name.Text = "";
            dtp_Prot_Date.Text = "";
            txt_Store_LastNum.Text = "";
            lb_Prot_id.Text = "0";
        }

        /// <summary>
        /// ȡ��
        /// </summary>
        private void Cancel()
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

        /// <summary>
        /// �޸���ӱ���
        /// </summary>
        private void Save()
        {        
                int Prot_id = Convert.ToInt32(lb_Prot_id.Text);
                string Prot_name = txt_Prot_Name.Text;
                float Prot_retailprice = Convert.ToSingle(txt_Prot_Retailprice.Text);
                float Prot_tradeprice = Convert.ToSingle(txt_Prot_Tradeprice.Text);
                string Prot_Bigunit = txt_Prot_Bigunit.Text;
                string Prot_smallunit = txt_Prot_Smallunit.Text;
                int prot_rate = Convert.ToInt32(txt_Prot_Rate.Text);
                int Prot_cardId = Convert.ToInt32(cbb_Cards_Name.SelectedValue);
                int Prot_providerId = Convert.ToInt32(cbb_Priv_Name.SelectedValue.ToString());
                DateTime Prot_date = dtp_Prot_Date.Value;
                string Store_LastNum = txt_Store_LastNum.Text;
                if (type == 0)
                {
                    foreach (ProductInfo item in lp)
                    {
                        if (item.Prot_name.Equals(txt_Prot_Name.Text)) 
                        {
                            MessageBox.Show("����Ʒ�Դ��ڣ�","��ʾ");
                            return;
                        }
                    }
                    string sql = string.Format("insert into productInfo(ProtName,"
                   +" ProtRetailprice,ProtTradeprice,ProtBigunit,ProtSmallunit,"
                   +" ProtRate,ProtCard,ProtProviderId,ProtDate)"
                   + "values('{0}','{1}','{2}','{3}','{4}',{5},{6},'{7}','{8}')",
                   Prot_name, Prot_retailprice, Prot_tradeprice, Prot_Bigunit,
                   Prot_smallunit, prot_rate, Prot_cardId, Prot_providerId, Prot_date);
                    int result = ExecuteQuery(sql);

                    if (result > 0)
                    {
                        SqlConnection con = new SqlConnection(conStr);
                        con.Open();
                        SqlCommand cmd = new SqlCommand( "select max(protid) from productInfo",con);
                        int inputProtId = Convert.ToInt32(cmd.ExecuteScalar());
                        con.Close();
                        if (inputProtId != 0)
                        {
                            string sql2 = 
                                string.Format("insert into storeRoom(Protid,storesum,storelastNum)"
                            +"values({1},0,{0})", Convert.ToInt32(txt_Store_LastNum.Text),inputProtId);
                            result = result + ExecuteQuery(sql2);
                            MessageBox.Show("��ӳɹ���", "��ʾ");
                        }
                    }
                }
                else if (type == 1)
                {
                    string sql = string.Format("update productInfo set ProtName='{0}',"
                    +"ProtRetailprice='{1}',ProtTradeprice='{2}',ProtBigunit='{3}',"
                    +"ProtSmallunit='{4}',ProtRate={5},ProtCard={6},ProtProviderId={7},"
                    +"ProtDate='{8}'where ProtId={9}", Prot_name, Prot_retailprice,
                    Prot_tradeprice, Prot_Bigunit, Prot_smallunit, prot_rate,
                    Prot_cardId, Prot_providerId, Prot_date, Prot_id);
                    int result = ExecuteQuery(sql);
                    if (result > 0)
                    {
                        MessageBox.Show("�޸ĳɹ���", "��ʾ");
                    }
                }
        }
        //�������
        private void Frm_ProductInfo_Load(object sender, EventArgs e)
        {
            dgv_PrdouctInfo.AutoGenerateColumns = false;
            lp =GetProductInfoByProt_Name("");
            dgv_PrdouctInfo.DataSource = lp;
            Conceal();
            cbb_Cards_Name.DisplayMember = "Cardsname";
            cbb_Cards_Name.ValueMember = "Cardsid";
            cbb_Cards_Name.DataSource =LoginInfo.GetCardsByCards_name("");
            cbb_Priv_Name.DisplayMember = "Priv_name";
            cbb_Priv_Name.ValueMember = "Priv_id";
            cbb_Priv_Name.DataSource = LoginInfo.GetProvidersByPriv_name("");
        }
        //���
        private void tsb_Btn_Add_Click(object sender, EventArgs e)
        {
            type = 0;
            tsb_Btn_Amend.Enabled = false;
            tsb_Txt_Lookup.Enabled = false;
            tsb_Btn_Delete.Enabled = false;
            tsb_Btn_Lookup.Enabled = false;
            tsb_Btn_Save.Enabled = true;
            Display();
            txt_Prot_Name.Focus();
        }
        //�޸�
        private void tsb_Btn_Amend_Click(object sender, EventArgs e)
        {
            type = 1;
            tsb_Btn_Add.Enabled = false;
            tsb_Btn_Save.Enabled = true;
            tsb_Btn_Delete.Enabled = false;
            tsb_Txt_Lookup.Enabled = false;
            tsb_Btn_Lookup.Enabled = false;
            Display();
            txt_Store_LastNum.Enabled = false;
            txt_Prot_Name.Focus();
            lb_Prot_id.Text = dgv_PrdouctInfo.CurrentRow.Cells[0].Value.ToString();
            txt_Prot_Name.Text = dgv_PrdouctInfo.CurrentRow.Cells[1].Value.ToString();
            txt_Prot_Retailprice.Text = dgv_PrdouctInfo.CurrentRow.Cells[2].Value.ToString();
            txt_Prot_Tradeprice.Text = dgv_PrdouctInfo.CurrentRow.Cells[3].Value.ToString();
            txt_Prot_Bigunit.Text = dgv_PrdouctInfo.CurrentRow.Cells[4].Value.ToString();
            txt_Prot_Smallunit.Text = dgv_PrdouctInfo.CurrentRow.Cells[5].Value.ToString();
            txt_Prot_Rate.Text = dgv_PrdouctInfo.CurrentRow.Cells[6].Value.ToString();
            cbb_Cards_Name.Text = dgv_PrdouctInfo.CurrentRow.Cells[7].Value.ToString();
            cbb_Priv_Name.Text = dgv_PrdouctInfo.CurrentRow.Cells[8].Value.ToString();
            dtp_Prot_Date.Value = Convert.ToDateTime(dgv_PrdouctInfo.CurrentRow.Cells[9].Value);
        }
        //����
        private void tsb_Btn_Save_Click(object sender, EventArgs e)
        {
            Save();
            lp = GetProductInfoByProt_Name("");
            dgv_PrdouctInfo.DataSource = lp;
            Clear();
            Conceal();
            tsb_Btn_Amend.Enabled = true;
            tsb_Btn_Delete.Enabled = true;
        }
        //ɾ��
        private void tsb_Btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_PrdouctInfo.SelectedRows.Count > 0)
            {
                int pId = Convert.ToInt32(dgv_PrdouctInfo.SelectedRows[0].Cells[0].Value);
                string sql = "delete from productInfo where ProtId=" + pId;
                DialogResult dr = MessageBox.Show("��ȷ��Ҫɾ������Ʒ��Ϣ��ɾ��֮�����й��ڸ���Ʒ�ļ�¼����ȫ�����", "��ʾ",MessageBoxButtons.OKCancel);
                string sqlStoreCount="select StoreSum from storeRoom where  protid="+pId;
                int storeCount=0;
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand(sqlStoreCount, con);
                 storeCount=Convert.ToInt32(cmd.ExecuteScalar());
                if (storeCount > 0)
                {
                    MessageBox.Show("����Ʒ���п�棬���Ƚ�����������⣬��ɾ����Ʒ", "��ʾ");
                    return;
                }
                else 
                {
                    string sqlDelStoreCount = "delete from storeRoom where protid="+pId;
                    string sqlDelDetial = " delete from orderdetails where protid=" + pId;
                    string sqlDelReturn = "delete from returnproduct where protid="+pId;
                    ExecuteQuery(sqlDelStoreCount);
                    ExecuteQuery(sqlDelDetial);
                    ExecuteQuery(sqlDelReturn);
                }
                con.Close();
                if (dr == DialogResult.OK)
                {
                    int result = ExecuteQuery(sql);
                    if (result > 0)
                    {
                        MessageBox.Show("ɾ���ɹ�!", "��ʾ");
                        lp = GetProductInfoByProt_Name("");
                        dgv_PrdouctInfo.DataSource = lp;
                    }
                }
            }
        }
        //ȡ��
        private void tsb_Btn_Cancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void tsb_Txt_Lookup_KeyDown(object sender, KeyEventArgs e)
        {

        }
        //��ѯ
        private void tsb_Btn_Lookup_Click(object sender, EventArgs e)
        {
            if (tsb_Txt_Lookup.Text.Trim() == "" || String.IsNullOrEmpty(tsb_Txt_Lookup.Text))
            {
                MessageBox.Show("�������ѯ������", "��ʾ");
            }
            else
            {
                lp=GetProductInfoByProt_Name(tsb_Txt_Lookup.Text);
                dgv_PrdouctInfo.DataSource = lp;
            }
        }
        private void txt_Enter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txt_Store_LastNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Save();
        }
        //�˳�
        private void tsb_Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// ʹ����Ʒ���Ʋ�ѯ��Ʒ��Ϣ
        /// </summary>
        /// <param name="Prot_name">��Ʒ����</param>
        /// <returns>��Ʒ�༯��</returns>
        public List<ProductInfo> GetProductInfoByProt_Name(string Prot_name)
        {
            List<ProductInfo> lp = new List<ProductInfo>();
            SqlConnection con = new SqlConnection(conStr);//���ݿ����Ӷ���
            try
            {
                con.Open();
                string sql = string.Format("select productInfo.*,Cards.*,providers.* from productInfo,Cards,providers where productInfo.Protcard=Cards.Cardsid and productInfo.ProtproviderId=providers.Privid and ProtName like '%{0}%'", Prot_name);
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    ProductInfo p = new ProductInfo();
                    p.Prot_id = Convert.ToInt32(dr["Protid"]);
                    p.Prot_name = dr["Protname"].ToString();
                    p.Prot_retailprice = Convert.ToSingle(dr["Protretailprice"]);
                    p.Prot_tradeprice = Convert.ToSingle(dr["Prottradeprice"]);
                    p.Prot_Bigunit = dr["ProtBigunit"].ToString();
                    p.Prot_smallunit = dr["Protsmallunit"].ToString();
                    p.Prot_rate = Convert.ToInt32(dr["Protrate"]);
                    p.ProvName = dr["PrivName"].ToString();
                    p.CardsName = dr["CardsName"].ToString();
                    p.Prot_providerId = Convert.ToInt32(dr["PrivId"]);
                    p.ProvName = dr["PrivName"].ToString();
                    p.Prot_date = Convert.ToDateTime(dr["Protdate"]);
                    CardsInfo loadCards = new CardsInfo();
                    loadCards.CardsId = Convert.ToInt32(dr["CardsId"]);
                    loadCards.CardsName = dr["CardsName"].ToString();
                    lp.Add(p);
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
            return lp;
        }

        /// <summary>
        /// ִ�����Ӻ��޸ģ�ɾ������
        /// </summary>
        /// <param name="sql">sql���</param>
        /// <returns>��Ӱ������</returns>
        public int ExecuteQuery(string sql)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                 i = cmd.ExecuteNonQuery();   
            }
            catch (Exception)
            {
                MessageBox.Show("ϵͳ��æ,�����Ժ����ԣ�", "��ʾ");
            }
            finally 
            {
              con.Close();
            }
            return i;
        }
    }
}