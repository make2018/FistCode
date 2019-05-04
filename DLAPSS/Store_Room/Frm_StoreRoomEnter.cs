using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DLAPSS.Store;
using System.Data.SqlClient;
namespace DLAPSS.Store_Room
{
    public partial class Frm_StoreRoomEnter : Form
    {
        public Frm_StoreRoomEnter()
        {
            InitializeComponent();
        }
        //�������ݿ��ַ���
        private static readonly string conStr = DBHelper.conStr;
        int num = 0;
        int sum = 0;
        float money = 0;
        //�����Ϣ����
        List<StoreRoom> ls = new List<StoreRoom>();
        //��Ʒ��Ϣ����
        List<ProductInfo> lp = new List<ProductInfo>();
        /// <summary>
        /// ��տռ�
        /// </summary>
        public void Clear()
        {
            txt_Enter_Num.Text = "";
            txt_Prot_Bigunit.Text = "";
            txt_Prot_Name.Text = "";
            txt_Prot_Rate.Text = "";
            txt_Prot_Retailprice.Text = "";
            txt_Prot_Smallunit.Text = "";
            txt_Prot_Tradeprice.Text = "";
        }
        //�������
        private void Frm_StoreRoomEnter_Load(object sender, EventArgs e)
        {
            dgv_Store.AutoGenerateColumns = false;
            cbb_Cards_Name.DisplayMember = "Cardsname";
            cbb_Cards_Name.ValueMember = "Cardsid";
            cbb_Cards_Name.DataSource = LoginInfo.GetCardsByCards_name("");
            cbb_Priv_Name.DisplayMember = "Priv_name";
            cbb_Priv_Name.ValueMember = "Priv_id";
            cbb_Priv_Name.DataSource = LoginInfo.GetProvidersByPriv_name("");
        }
        //�˳�
        private void tsb_Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //ɾ��
        private void tsb_Btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Store.SelectedRows.Count > 0)
            {
                ls.RemoveAt(Convert.ToInt32(dgv_Store.SelectedRows[0].Index));
                dgv_Store.DataSource = null;
                dgv_Store.DataSource = ls;
            }
        }
        //����
        private void tsb_Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Store.DataSource != null)
                {
                    int i = GetOrersChangeBySql();
                    if (i > 0)
                    {
                        foreach (StoreRoom sr in ls)
                        {
                            GetOrerDetailsChangeBySql(i, sr.Prot_id, sr.In_Out_StoreRoom);
                            string sql = "update storeRoom set storesum=@store_sum where Protid=@Prot_id";
                            int store_sum = sr.Store_sum + sr.In_Out_StoreRoom;
                            if (GetStoreRoomChangeBySql(sql, sr.Prot_id, store_sum, sr.Store_lastNum) > 0)
                                MessageBox.Show("��Ʒ��" + sr.Prot_name + "��������" + sr.In_Out_StoreRoom + "�����ɹ�");
                            else
                                MessageBox.Show("��Ʒ��" + sr.Prot_name + "��������" + sr.In_Out_StoreRoom + "�����ʧ��");
                        }
                        ls.Clear();
                        Clear();
                        dgv_Store.DataSource = null;
                        num = 0;
                        sum = 0;
                        money = 0;
                    }
                    else
                    {
                        MessageBox.Show("�����ܱ����ʧ�ܣ�����������");
                    }
                }
                else
                    MessageBox.Show("�������Ʒ��Ϣ");
            }
            catch (Exception)
            {
                MessageBox.Show("ʧ��");
            }
        }
        //��Ʒ���ƴ������¼�
        private void txt_Prot_Name_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    common.Prot_name = txt_Prot_Name.Text;
                    Frm_StoreQuery fs = new Frm_StoreQuery();
                    common.Prot_EnterAndOut = true;
                    fs.ShowDialog();
                    StoreRoom s = common.s;
                    txt_Prot_Bigunit.Text = s.Prot_Bigunit;
                    txt_Prot_Name.Text = s.Prot_name;
                    txt_Prot_Rate.Text = s.Prot_rate.ToString();
                    txt_Prot_Retailprice.Text = s.Prot_retailprice.ToString();
                    txt_Prot_Smallunit.Text = s.Prot_smallunit;
                    txt_Prot_Tradeprice.Text = s.Prot_tradeprice.ToString();
                    cbb_Cards_Name.Text = s.Cards_name;
                    cbb_Priv_Name.Text = s.Priv_name;
                    dtp_Prot_Date.Value = s.Prot_date;
                    txt_Enter_Num.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("��ѡ��һ��");
            }
        }
        /// <summary>
        /// �Ե׵��ܱ�������
        /// </summary>
        /// <param name="order_time">����ʱ��</param>
        /// <param name="userId">����ԱID</param>
        /// <param name="order_sum_money">�ö�����Ʒ�ܼ�</param>
        /// <param name="order_sum_total">�ö�����Ʒ������</param>
        /// <param name="order_type">�ö������� 0���� 1�˻� 2 ���� 3�����˻�</param>
        /// <returns>�㵥�ܱ���</returns>
        public int GetOrersChangeBySql()
        {
            SqlConnection con = new SqlConnection(conStr);
            int i = 0;
            try
            {
                con.Open();
                string sql = string.Format("insert into orders(OrderTime,UserId,OrderSumMoney,OrderSumTotal,OrderType)" +
                    "values('{0}',{1},'{2}',{3},{4})", DateTime.Now, LoginInfo.LoginUserInfo.UserId, money, sum, 0);
                SqlCommand com = new SqlCommand(sql, con);
                i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    com.CommandText = "select @@identity";
                    i = Convert.ToInt32(com.ExecuteScalar());
                }
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
            return i;
        }
        /// <summary>
        /// ����µĶ�����ϸ��
        /// </summary>
        /// <param name="order_id">�����ܱ�ID</param>
        /// <param name="prot_id">��Ʒ���ID</param>
        /// <param name="order_det_sum">��Ʒ����</param>
        /// <returns></returns>
        public int GetOrerDetailsChangeBySql(int order_id, int prot_id, int order_det_sum)
        {
            SqlConnection con = new SqlConnection(conStr);
            int i = 0;
            try
            {
                con.Open();
                string sql = "insert orderDetails values(@Order_id, @Prot_id, @order_det_sum)";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.Add("@order_id", SqlDbType.Int).Value = order_id;
                com.Parameters.Add("@prot_id", SqlDbType.Int).Value = prot_id;
                com.Parameters.Add("@order_det_sum", SqlDbType.Int).Value = order_det_sum;
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
        /// <summary>
        /// ��sql���Կ���������޸�
        /// </summary>
        /// <param name="sql">sql���</param>
        /// <param name="Prot_id">��ƷID ���</param>
        /// <param name="store_sum">��Ʒ���</param>
        /// <param name="store_lastNum">�������</param>
        /// <returns>sql���Ӱ�������</returns>
        public int GetStoreRoomChangeBySql(string sql, int Prot_id, int store_sum, int store_lastNum)
        {
            SqlConnection con = new SqlConnection(conStr);
            int i = 0;
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.Add("@Prot_id", SqlDbType.Int).Value = Prot_id;
                com.Parameters.Add("@store_sum", SqlDbType.Int).Value = store_sum;
                com.Parameters.Add("@store_lastNum", SqlDbType.Int).Value = store_lastNum;
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

        private void txt_Enter_Num_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (Convert.ToInt32(txt_Enter_Num.Text) <= 0)
                    {
                        MessageBox.Show("�����˻�����Ϊ��ֵ��0");
                        txt_Enter_Num.SelectAll();
                        return;
                    }
                    bool b = true;
                    foreach (StoreRoom var in ls)
                    {
                        if (var.Prot_id==common.s.Prot_id)
                        {
                            var.In_Out_StoreRoom += Convert.ToInt32(txt_Enter_Num.Text);
                            sum += Convert.ToInt32(txt_Enter_Num.Text);
                            money += Convert.ToInt32(txt_Enter_Num.Text) * var.Prot_tradeprice;
                            b = false;
                            break;
                        }
                    }
                    StoreRoom s = common.s;
                    if (b)
                    {
                        s.In_Out_StoreRoom = Convert.ToInt32(txt_Enter_Num.Text);
                        num++;
                        sum += s.In_Out_StoreRoom;
                        money+= s.In_Out_StoreRoom * s.Prot_tradeprice;
                        ls.Add(s);
                    }
                    common.s = null;
                    dgv_Store.DataSource = null;
                    dgv_Store.DataSource = ls;
                    Clear();
                    txt_Prot_Name.Focus();
                    lb_money.Text = money.ToString();
                    lb_num.Text = num.ToString();
                    lb_sum.Text = sum.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("��������ȷ�����ָ�ʽ");
                    txt_Enter_Num.SelectAll();
                }
            }
        }
    }
}