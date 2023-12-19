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
    public partial class BillingForm : Form
    {
        public BillingForm()
        {
            InitializeComponent();
        }

        int client_id;

        private void BillingForm_Load(object sender, EventArgs e)
        {
            lblunpaidId.Hide();
            database.saveUpdaDel("INSERT INTO `billing_info` (`client_id`, `month`, `year`, `date`, `status`) SELECT client_info.client_id, MONTHNAME(CURRENT_DATE), YEAR(CURRENT_DATE), CURRENT_DATE, 'Unpaid' FROM `client_info` WHERE( SELECT MAX(`date`) FROM `billing_info` WHERE `billing_info`.`client_id` = `client_info`.`client_id` ) < CURRENT_DATE OR( SELECT MAX(`date`) FROM `billing_info` WHERE `billing_info`.`client_id` = `client_info`.client_id) IS NULL;","Billing has been updated.");
            database.datagridViewing("SELECT `client_id`,concat( `first_name`,' ', `last_name`) as Name, `contact_no`, `purok` FROM client_info", dgvClientRecord);
        }

        private void BtnSearchClient_Click(object sender, EventArgs e)
        {
            database.datagridViewing("SELECT `client_id`,concat( `first_name`,' ', `last_name`) as Name, `contact_no`, `purok` FROM client_info WHERE first_name like '%" + TbxSearchClient.Text + "%' or last_name like '%" + TbxSearchClient.Text + "%'", dgvClientRecord);
        }

        //billing
        private void dgvClientRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                client_id = int.Parse(dgvClientRecord.Rows[e.RowIndex].Cells[0].Value.ToString());
               
                LbName.Text = dgvClientRecord.Rows[e.RowIndex].Cells[1].Value.ToString();
                database.datagridViewing("SELECT `billing_id`, `month`, `year`, `status` FROM `billing_info` WHERE status = 'Paid' and client_id=" + client_id, dgvPaid);
                database.getUnpaid(client_id, dgvUnpaid, LbBalance);
            }
            catch { }
        }

        private void BtnPaid_Click(object sender, EventArgs e)
        {
            try
            {
                database.saveUpdaDel("UPDATE `billing_info` SET `status`='Paid' WHERE billing_id=" + lblunpaidId.Text, "Paid");
                database.getUnpaid(client_id, dgvUnpaid, LbBalance);
                RtbReceipt.Clear();
                RtbReceipt.Text += ("*************************************");
                RtbReceipt.Text += ("**\t           BARANGAY BASAK           ");
                RtbReceipt.Text += ("**\t       WATER BILLING SYSTEM       **");
                RtbReceipt.Text += ("***********************************");
                RtbReceipt.Text += ("Brgy. Basak, San Juan, Southern Leyte\n");
                RtbReceipt.Text += ("Date: " + DateTime.Now + "\n\n");
                RtbReceipt.Text += ("Name: " + LbName.Text + "\n");
                RtbReceipt.Text += ("Month Paid: " + LbMonth.Text + "\n");
                RtbReceipt.Text += ("Year: " + LbYear.Text + "\n");
                RtbReceipt.Text += ("Amount: 20\n");
                RtbReceipt.Text += ("Balance: " + LbBalance.Text + "\n");
                RtbReceipt.Text += ("\n                             Signature:         ");

                database.datagridViewing("SELECT `billing_id`, `month`, `year`, `status` FROM `billing_info` WHERE status = 'Paid' and client_id=" + client_id, dgvPaid);
            }
            catch { }
            DateTime now = DateTime.Now;
            database.saveUpdaDel("INSERT INTO bill_record (name,date,month,year) VALUES('" + LbName.Text + "',CURRENT_DATE,'" + LbMonth.Text + "', '" + LbYear.Text + "')", "ADDED");
           

        }

        private void dgvUnpaid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblunpaidId.Text = dgvUnpaid.Rows[e.RowIndex].Cells[0].Value.ToString();
                LbMonth.Text = dgvUnpaid.Rows[e.RowIndex].Cells[1].Value.ToString();
                LbYear.Text = dgvUnpaid.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch { }
        }

        private void BtnBack_MouseLeave(object sender, EventArgs e)
        {
            BtnBack.BackColor = Color.White;
        }

        private void BtnBack_MouseMove(object sender, MouseEventArgs e)
        {
            BtnBack.BackColor = Color.Red;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(RtbReceipt.Text, new Font("Century Gothic", 36, FontStyle.Bold), Brushes.Black, new Point(10, 10));

        }

        private void BtnPrintReceipt_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            this.Hide();
            main.Show();
        }

        private void LbBalance_Click(object sender, EventArgs e)
        {

        }

        private void Cbxchoose_MouseLeave(object sender, EventArgs e)
        {
            

        }
    }
}
