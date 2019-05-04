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
        /// 清空控件
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
        /// 显示控件
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
        /// 隐藏控件
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
        /// 取消
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
        //删除
        private void tsb_Btn_Delete_Click(object sender, EventArgs e)
        {
            string sql = " delete from providers where PrivId=" + Convert.ToInt32(dgv_Providers.CurrentRow.Cells[0].Value);
            DialogResult dr = MessageBox.Show("你确定要删除此信息吗？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                int result = GetProvidersChangeBySql(sql);
                if (result > 0)
                {
                    MessageBox.Show("删除成功！", "提示");
                    lp = GetProvidersByPriv_name("");
                    dgv_Providers.DataSource = lp;
                }
                else
                {
                    MessageBox.Show("此信息与商品信息有关联请先删除商品信息！", "提示");
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
                MessageBox.Show("系统繁忙,请稍后再试!", "提示");
            }
            finally
            {
                con.Close();
            }
            return i;
        }
        /// <summary>
        /// 使用供货商名称查找供货商信息
        /// </summary>
        /// <param name="Priv_name">供货商名称</param>
        /// <returns>供货商表集合</returns>
        public List<Providers> GetProvidersByPriv_name(string Priv_name)
        {
            List<Providers> lp = new List<Providers>();
            //创建数据库接对象
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                //打开连接
                con.Open();
                string sql = "select * from providers where Privname like '%'+@Priv_name+'%'";
                //创建命令执行对象
                SqlCommand com = new SqlCommand(sql, con);
                //添加参数
                com.Parameters.Add("@Priv_name", SqlDbType.VarChar, 50).Value = Priv_name;
                //获取数据读取对象
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
                //关闭数据读取对象
                dr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("系统出现异常，请您稍后再试！");
            }
            finally 
            {
                //关闭数据库连接
                con.Close();
            }
            return lp;
        }
        //窗体加载
        private void Frm_ProvidersInfo_Load(object sender, EventArgs e)
        {
            tsb_Btn_Save.Enabled = false;
            Conceal();
            lp = GetProvidersByPriv_name("");
            dgv_Providers.DataSource = lp;
        }
        //根据厂商名称查询
        private void tsb_Btn_Lookup_Click(object sender, EventArgs e)
        {
            lp = GetProvidersByPriv_name(tsb_Txt_Lookup.Text);
            dgv_Providers.DataSource = lp;
        }
        //添加
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
        //修改
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
        //取消
        private void tsb_Btn_Cancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }
        //退出
        private void tsb_Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //保存
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
                        MessageBox.Show("修改成功！", "提示");
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
                            MessageBox.Show("你要添加的信息已存在！", "提示");
                            return;
                        }
                    }
                    int result = GetProvidersChangeBySql(sql);
                    if (result > 0)
                    {
                        MessageBox.Show("添加成功！", "提示");
                        lp = GetProvidersByPriv_name("");
                        dgv_Providers.DataSource = lp;
                    }

                }
                Cancel();
                Clear();
            }
        }
        //非空验证
        private bool vailInput()
        {
            if (txt_Priv_adr.Text.Trim() == "")
            {
                MessageBox.Show("地址不能为空！","提示");
                return false;
            }
            if (txt_Priv_linkMan.Text.Trim() == "")
            {
                MessageBox.Show("联系人不能为空！", "提示");
                return false;
            }
            if (txt_Priv_name.Text.Trim() == "")
            {
                MessageBox.Show("厂家名称不能为空！", "提示");
                return false;
            }
            if (txt_Priv_tel.Text.Trim() == "")
            {
                MessageBox.Show("联系电话不能为空！", "提示");
                return false;
            }
            return true;
        }
        }
}