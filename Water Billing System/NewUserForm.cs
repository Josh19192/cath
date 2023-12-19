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
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            InitializeComponent();
        }

        private void BtnAddNewUser_Click(object sender, EventArgs e)
        {
            database.saveUpdaDel("INSERT into account (name, username, password) VALUES ('" + TbxName.Text + "','" + TbxUsername.Text + "',SHA2('" + TbxPassword.Text + "', 256))", "New User has been ADDED.");
            logInForm form = new logInForm();
            this.Hide();
            form.Show();

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            this.Hide();
            main.Show();
        }

        private void TbxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (char.IsDigit(num) )
            {
                e.Handled = true;
            }
        }

        private void BtnBack_MouseLeave(object sender, EventArgs e)
        {
            BtnBack.BackColor = Color.White;
        }

        private void BtnBack_MouseMove(object sender, MouseEventArgs e)
        {
            BtnBack.BackColor = Color.Red;
        }

        private void BtnAddNewUser_MouseLeave(object sender, EventArgs e)
        {
            BtnAddNewUser.BackColor = Color.White;
        }

        private void BtnAddNewUser_MouseMove(object sender, MouseEventArgs e)
        {
            BtnAddNewUser.BackColor = Color.LimeGreen;
        }

        private void TbxUsername_Click(object sender, EventArgs e)
        {
            TbxUsername.SelectAll();
        }

        private void TbxPassword_Click(object sender, EventArgs e)
        {
            TbxPassword.SelectAll();
        }

        private void TbxName_Click(object sender, EventArgs e)
        {
            TbxName.SelectAll();
        }
    }
}
