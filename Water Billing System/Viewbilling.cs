using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Water_Billing_System
{
    public partial class Viewbilling : Form
    {
        public Viewbilling()
        {
            InitializeComponent();
        }

        private void Viewbilling_Load(object sender, EventArgs e)
        {
            database.datagridViewing("SELECT * FROM bill_record", dgvBillR);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            this.Hide();
            mm.Show();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            database.datagridViewing("SELECT * FROM bill_record WHERE name like '%" + TbxSearch.Text + "%' or date like '%" + TbxSearch.Text + "%' or month like '%" + TbxSearch.Text + "%' or year like '%" + TbxSearch.Text + "%'",dgvBillR);
        }
    }
}
