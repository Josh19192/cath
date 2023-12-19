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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            LbUserID.Hide();
            database.datagridViewing("SELECT * FROM account", dgvUser);
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                LbUserID.Text = dgvUser.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void BtnAddU_Click(object sender, EventArgs e)
        {
            NewUserForm user = new NewUserForm();
            user.Show();
            this.Hide();
        }

        private void BtnDeleteU_Click(object sender, EventArgs e)
        {
            database.saveUpdaDel("DELETE FROM account WHERE account_id = '" + LbUserID.Text + "'", "Data has been DELETED.");
            database.datagridViewing("SELECT * FROM account", dgvUser);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            this.Hide();
            main.Show();
        }

        
    }
}
