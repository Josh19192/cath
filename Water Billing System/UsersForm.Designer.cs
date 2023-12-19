namespace Water_Billing_System
{
    partial class UsersForm
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.BtnAddU = new System.Windows.Forms.Button();
            this.BtnDeleteU = new System.Windows.Forms.Button();
            this.LbUserID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(12, 421);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(74, 31);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "BACK";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Water_Billing_System.Properties.Resources.icons8_admin_96;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "USER ";
            // 
            // dgvUser
            // 
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(12, 109);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.Size = new System.Drawing.Size(678, 302);
            this.dgvUser.TabIndex = 3;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            // 
            // BtnAddU
            // 
            this.BtnAddU.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddU.Location = new System.Drawing.Point(506, 63);
            this.BtnAddU.Name = "BtnAddU";
            this.BtnAddU.Size = new System.Drawing.Size(105, 31);
            this.BtnAddU.TabIndex = 4;
            this.BtnAddU.Text = "+ADD NEW";
            this.BtnAddU.UseVisualStyleBackColor = true;
            this.BtnAddU.Click += new System.EventHandler(this.BtnAddU_Click);
            // 
            // BtnDeleteU
            // 
            this.BtnDeleteU.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteU.Location = new System.Drawing.Point(617, 63);
            this.BtnDeleteU.Name = "BtnDeleteU";
            this.BtnDeleteU.Size = new System.Drawing.Size(74, 31);
            this.BtnDeleteU.TabIndex = 5;
            this.BtnDeleteU.Text = "DELETE";
            this.BtnDeleteU.UseVisualStyleBackColor = true;
            this.BtnDeleteU.Click += new System.EventHandler(this.BtnDeleteU_Click);
            // 
            // LbUserID
            // 
            this.LbUserID.AutoSize = true;
            this.LbUserID.BackColor = System.Drawing.Color.Transparent;
            this.LbUserID.Location = new System.Drawing.Point(10, 109);
            this.LbUserID.Name = "LbUserID";
            this.LbUserID.Size = new System.Drawing.Size(27, 13);
            this.LbUserID.TabIndex = 6;
            this.LbUserID.Text = "user";
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Water_Billing_System.Properties.Resources._5a7f1eff255d5e1d91e542d67c8be256;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 464);
            this.Controls.Add(this.BtnDeleteU);
            this.Controls.Add(this.BtnAddU);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.LbUserID);
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Button BtnAddU;
        private System.Windows.Forms.Button BtnDeleteU;
        private System.Windows.Forms.Label LbUserID;
    }
}