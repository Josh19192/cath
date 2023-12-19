namespace Water_Billing_System
{
    partial class logInForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.PbLogin = new System.Windows.Forms.PictureBox();
            this.TbxUsername = new System.Windows.Forms.TextBox();
            this.TbxPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Say Comic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "BARANGAY BASAK ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Say Comic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "WATER BILLING SYSTEM";
            // 
            // PbLogin
            // 
            this.PbLogin.BackColor = System.Drawing.Color.Transparent;
            this.PbLogin.Location = new System.Drawing.Point(148, 163);
            this.PbLogin.Name = "PbLogin";
            this.PbLogin.Size = new System.Drawing.Size(350, 139);
            this.PbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbLogin.TabIndex = 2;
            this.PbLogin.TabStop = false;
            // 
            // TbxUsername
            // 
            this.TbxUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxUsername.Location = new System.Drawing.Point(238, 212);
            this.TbxUsername.Name = "TbxUsername";
            this.TbxUsername.Size = new System.Drawing.Size(232, 27);
            this.TbxUsername.TabIndex = 4;
            this.TbxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbxUsername.Click += new System.EventHandler(this.TbxUsername_Click);
            // 
            // TbxPassword
            // 
            this.TbxPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxPassword.Location = new System.Drawing.Point(238, 258);
            this.TbxPassword.Name = "TbxPassword";
            this.TbxPassword.Size = new System.Drawing.Size(232, 27);
            this.TbxPassword.TabIndex = 5;
            this.TbxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbxPassword.UseSystemPasswordChar = true;
            this.TbxPassword.Click += new System.EventHandler(this.TbxPassword_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(301, 333);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(106, 38);
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.Text = "LOG IN";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            this.BtnLogin.MouseLeave += new System.EventHandler(this.BtnLogin_MouseLeave);
            this.BtnLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnLogin_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Water_Billing_System.Properties.Resources.icon1;
            this.pictureBox1.Location = new System.Drawing.Point(169, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Water_Billing_System.Properties.Resources.icons8_password_48;
            this.pictureBox2.Location = new System.Drawing.Point(168, 258);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(266, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "ADMINISTRATOR";
            // 
            // logInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Water_Billing_System.Properties.Resources.drop_of_water_578897_12801;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 444);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TbxPassword);
            this.Controls.Add(this.TbxUsername);
            this.Controls.Add(this.PbLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "logInForm";
            this.Text = "logInForm";
            ((System.ComponentModel.ISupportInitialize)(this.PbLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PbLogin;
        private System.Windows.Forms.TextBox TbxUsername;
        private System.Windows.Forms.TextBox TbxPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
    }
}

