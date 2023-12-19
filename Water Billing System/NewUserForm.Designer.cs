namespace Water_Billing_System
{
    partial class NewUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.TbxUsername = new System.Windows.Forms.TextBox();
            this.TbxPassword = new System.Windows.Forms.TextBox();
            this.BtnAddNewUser = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "New User";
            // 
            // TbxName
            // 
            this.TbxName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxName.Location = new System.Drawing.Point(231, 116);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(180, 27);
            this.TbxName.TabIndex = 1;
            this.TbxName.Text = "Name";
            this.TbxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbxName.Click += new System.EventHandler(this.TbxName_Click);
            this.TbxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxName_KeyPress);
            // 
            // TbxUsername
            // 
            this.TbxUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxUsername.Location = new System.Drawing.Point(231, 161);
            this.TbxUsername.Name = "TbxUsername";
            this.TbxUsername.Size = new System.Drawing.Size(180, 27);
            this.TbxUsername.TabIndex = 2;
            this.TbxUsername.Text = "Username";
            this.TbxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbxUsername.Click += new System.EventHandler(this.TbxUsername_Click);
            // 
            // TbxPassword
            // 
            this.TbxPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxPassword.Location = new System.Drawing.Point(231, 207);
            this.TbxPassword.Name = "TbxPassword";
            this.TbxPassword.Size = new System.Drawing.Size(180, 27);
            this.TbxPassword.TabIndex = 3;
            this.TbxPassword.Text = "Password";
            this.TbxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbxPassword.Click += new System.EventHandler(this.TbxPassword_Click);
            // 
            // BtnAddNewUser
            // 
            this.BtnAddNewUser.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddNewUser.Location = new System.Drawing.Point(285, 268);
            this.BtnAddNewUser.Name = "BtnAddNewUser";
            this.BtnAddNewUser.Size = new System.Drawing.Size(63, 32);
            this.BtnAddNewUser.TabIndex = 4;
            this.BtnAddNewUser.Text = "+ADD";
            this.BtnAddNewUser.UseVisualStyleBackColor = true;
            this.BtnAddNewUser.Click += new System.EventHandler(this.BtnAddNewUser_Click);
            this.BtnAddNewUser.MouseLeave += new System.EventHandler(this.BtnAddNewUser_MouseLeave);
            this.BtnAddNewUser.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnAddNewUser_MouseMove);
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(12, 349);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 30);
            this.BtnBack.TabIndex = 5;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            this.BtnBack.MouseLeave += new System.EventHandler(this.BtnBack_MouseLeave);
            this.BtnBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnBack_MouseMove);
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Water_Billing_System.Properties.Resources._5a7f1eff255d5e1d91e542d67c8be256;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 391);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnAddNewUser);
            this.Controls.Add(this.TbxPassword);
            this.Controls.Add(this.TbxUsername);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(this.label1);
            this.Name = "NewUserForm";
            this.Text = "NewUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.TextBox TbxUsername;
        private System.Windows.Forms.TextBox TbxPassword;
        private System.Windows.Forms.Button BtnAddNewUser;
        private System.Windows.Forms.Button BtnBack;


    }
}