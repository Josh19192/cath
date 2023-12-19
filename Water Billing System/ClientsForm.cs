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
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            BtnUpdate.Hide();
            BtnDelete.Hide();
            LbID.Hide();
            database.datagridViewing("SELECT * FROM client_info", dgvClientsR);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TbxContactNo.Text.Length != 11) 
            {
                MessageBox.Show("Invalid Contact number!");
            }
            else
            {
                database.saveUpdaDel("INSERT INTO client_info( last_name, first_name, middle_name, contact_no, purok,month,year,date) VALUES('" + TbxLastN.Text + "','" + TbxFirstN.Text + "', '" + TbxMiddleN.Text + "', '" + TbxContactNo.Text + "', '" + TbxPurok.Text + "',MONTHNAME(CURRENT_DATE), YEAR(CURRENT_DATE), CURRENT_DATE)", "ADDED");
                database.datagridViewing("SELECT * FROM client_info", dgvClientsR);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            database.saveUpdaDel("DELETE FROM billing_info WHERE client_id = '" + LbID.Text + "'","Data has been deleted");
            database.saveUpdaDel("DELETE FROM client_info WHERE client_id = '" + LbID.Text + "'", "Data has been deleted");
            database.datagridViewing("SELECT * FROM client_info", dgvClientsR);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            database.datagridViewing("SELECT * FROM client_info WHERE first_name like '%" + TbxSearch.Text + "%' or last_name like '%" + TbxSearch.Text + "%'", dgvClientsR);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            BtnUpdate.Hide();
            BtnDelete.Hide();
            BtnAdd.Show();
            LbID.Text = "";
            TbxFirstN.Text = "";
            TbxMiddleN.Text = "";
            TbxLastN.Text = "";
            TbxContactNo.Text ="";
            TbxPurok.Text="";
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            database.saveUpdaDel("UPDATE client_info SET first_name = '" + TbxFirstN.Text + "',middle_name = '" + TbxMiddleN.Text + "', last_name = '" + TbxLastN.Text + "', contact_no = '" + TbxContactNo.Text + "' WHERE client_id = '" + LbID.Text + "'", "Data has been UPDATED.");
            database.datagridViewing("SELECT * FROM client_info", dgvClientsR);
        }

        private void dgvClientsR_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BtnAdd.Hide();
                BtnUpdate.Show();
                BtnDelete.Show();
                LbID.Text = dgvClientsR.Rows[e.RowIndex].Cells[0].Value.ToString();
                TbxLastN.Text = dgvClientsR.Rows[e.RowIndex].Cells[1].Value.ToString();                
                TbxFirstN.Text = dgvClientsR.Rows[e.RowIndex].Cells[2].Value.ToString();
                TbxMiddleN.Text = dgvClientsR.Rows[e.RowIndex].Cells[3].Value.ToString();
                TbxContactNo.Text = dgvClientsR.Rows[e.RowIndex].Cells[4].Value.ToString();
                TbxPurok.Text = dgvClientsR.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch { }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            this.Hide();
            main.Show();

        }

        private void BtnBack_MouseMove(object sender, MouseEventArgs e)
        {
            BtnBack.BackColor = Color.Red;
        }

        private void BtnBack_MouseLeave(object sender, EventArgs e)
        {
            BtnBack.BackColor = Color.White;
        }

        private void BtnClear_MouseMove(object sender, MouseEventArgs e)
        {
            BtnClear.BackColor = Color.Red;
        }

        private void BtnClear_MouseLeave(object sender, EventArgs e)
        {
            BtnClear.BackColor = Color.White;
        }
    }
}
