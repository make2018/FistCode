using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace DLAPSS.Store_Room
{
    public partial class Frm_ReturnProduct : Form
    {
        public Frm_ReturnProduct()
        {
            InitializeComponent();
        }

        private void txt_Returnprod_Reason_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                common.returnprod_reason = txt_Returnprod_Reason.Text;
                this.Close();
            }
        }
    }
}