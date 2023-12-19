namespace Water_Billing_System
{
    partial class Viewbilling
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TbxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBillR = new System.Windows.Forms.DataGridView();
            this.BtnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.BtnSearch);
            this.panel1.Controls.Add(this.TbxSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(134, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 85);
            this.panel1.TabIndex = 21;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(12, 46);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(73, 30);
            this.BtnSearch.TabIndex = 15;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TbxSearch
            // 
            this.TbxSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxSearch.Location = new System.Drawing.Point(90, 48);
            this.TbxSearch.Name = "TbxSearch";
            this.TbxSearch.Size = new System.Drawing.Size(182, 27);
            this.TbxSearch.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "BILLING RECORD";
            // 
            // dgvBillR
            // 
            this.dgvBillR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBillR.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvBillR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillR.Location = new System.Drawing.Point(136, 151);
            this.dgvBillR.Name = "dgvBillR";
            this.dgvBillR.Size = new System.Drawing.Size(550, 307);
            this.dgvBillR.TabIndex = 20;
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(12, 448);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(76, 34);
            this.BtnBack.TabIndex = 22;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // Viewbilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Water_Billing_System.Properties.Resources._5a7f1eff255d5e1d91e542d67c8be256;
            this.ClientSize = new System.Drawing.Size(801, 494);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvBillR);
            this.Name = "Viewbilling";
            this.Text = "viewbilling";
            this.Load += new System.EventHandler(this.Viewbilling_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TbxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBillR;
        private System.Windows.Forms.Button BtnBack;
    }
}