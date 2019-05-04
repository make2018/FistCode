using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace DLAPSS.Store
{
    public partial class Frm_Store_LastNum : Form
    {
        public Frm_Store_LastNum()
        {
            InitializeComponent();
        }

        private void txt_Store_LastNum_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txt_Store_LastNum.Text.Trim()== "") 
                    {
                        return;
                    }
                    common.store_lastNum = Convert.ToInt32(txt_Store_LastNum.Text);
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("请输入正确的数字格式");
            }
        }
    }
}