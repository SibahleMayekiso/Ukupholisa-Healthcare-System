namespace Ukupholisa_Healthcare_System
{
    partial class frmClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            this.btnCallCentre = new System.Windows.Forms.Button();
            this.btnProviderClient = new System.Windows.Forms.Button();
            this.btnPolicyClient = new System.Windows.Forms.Button();
            this.btnMedicalClient = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxLogoClient = new System.Windows.Forms.PictureBox();
            this.dgvClientView = new System.Windows.Forms.DataGridView();
            this.gbxClientView = new System.Windows.Forms.GroupBox();
            this.btnViewClientDependent = new System.Windows.Forms.Button();
            this.btnViewAllClients = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRightsClient = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientView)).BeginInit();
            this.gbxClientView.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCallCentre
            // 
            this.btnCallCentre.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCallCentre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCallCentre.Location = new System.Drawing.Point(0, 118);
            this.btnCallCentre.Name = "btnCallCentre";
            this.btnCallCentre.Size = new System.Drawing.Size(150, 52);
            this.btnCallCentre.TabIndex = 16;
            this.btnCallCentre.Text = "Call Centre";
            this.btnCallCentre.UseVisualStyleBackColor = false;
            this.btnCallCentre.Click += new System.EventHandler(this.btnCallCentre_Click);
            // 
            // btnProviderClient
            // 
            this.btnProviderClient.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProviderClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnProviderClient.Location = new System.Drawing.Point(0, 174);
            this.btnProviderClient.Name = "btnProviderClient";
            this.btnProviderClient.Size = new System.Drawing.Size(150, 52);
            this.btnProviderClient.TabIndex = 17;
            this.btnProviderClient.Text = "Provider";
            this.btnProviderClient.UseVisualStyleBackColor = false;
            this.btnProviderClient.Click += new System.EventHandler(this.btnProviderClient_Click);
            // 
            // btnPolicyClient
            // 
            this.btnPolicyClient.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPolicyClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPolicyClient.Location = new System.Drawing.Point(0, 232);
            this.btnPolicyClient.Name = "btnPolicyClient";
            this.btnPolicyClient.Size = new System.Drawing.Size(150, 52);
            this.btnPolicyClient.TabIndex = 18;
            this.btnPolicyClient.Text = "Policy";
            this.btnPolicyClient.UseVisualStyleBackColor = false;
            this.btnPolicyClient.Click += new System.EventHandler(this.btnPolicyClient_Click);
            // 
            // btnMedicalClient
            // 
            this.btnMedicalClient.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMedicalClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMedicalClient.Location = new System.Drawing.Point(0, 291);
            this.btnMedicalClient.Name = "btnMedicalClient";
            this.btnMedicalClient.Size = new System.Drawing.Size(150, 52);
            this.btnMedicalClient.TabIndex = 19;
            this.btnMedicalClient.Text = "Medical";
            this.btnMedicalClient.UseVisualStyleBackColor = false;
            this.btnMedicalClient.Click += new System.EventHandler(this.btnMedicalClient_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.pbxLogoClient);
            this.panel1.Controls.Add(this.btnCallCentre);
            this.panel1.Controls.Add(this.btnProviderClient);
            this.panel1.Controls.Add(this.btnMedicalClient);
            this.panel1.Controls.Add(this.btnPolicyClient);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 499);
            this.panel1.TabIndex = 20;
            // 
            // pbxLogoClient
            // 
            this.pbxLogoClient.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pbxLogoClient.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogoClient.Image")));
            this.pbxLogoClient.Location = new System.Drawing.Point(0, 0);
            this.pbxLogoClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxLogoClient.Name = "pbxLogoClient";
            this.pbxLogoClient.Size = new System.Drawing.Size(150, 81);
            this.pbxLogoClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogoClient.TabIndex = 17;
            this.pbxLogoClient.TabStop = false;
            // 
            // dgvClientView
            // 
            this.dgvClientView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientView.Location = new System.Drawing.Point(4, 42);
            this.dgvClientView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvClientView.Name = "dgvClientView";
            this.dgvClientView.RowHeadersWidth = 51;
            this.dgvClientView.RowTemplate.Height = 24;
            this.dgvClientView.Size = new System.Drawing.Size(562, 263);
            this.dgvClientView.TabIndex = 22;
            // 
            // gbxClientView
            // 
            this.gbxClientView.Controls.Add(this.btnViewClientDependent);
            this.gbxClientView.Controls.Add(this.dgvClientView);
            this.gbxClientView.Controls.Add(this.btnViewAllClients);
            this.gbxClientView.Location = new System.Drawing.Point(155, 58);
            this.gbxClientView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxClientView.Name = "gbxClientView";
            this.gbxClientView.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxClientView.Size = new System.Drawing.Size(572, 326);
            this.gbxClientView.TabIndex = 23;
            this.gbxClientView.TabStop = false;
            this.gbxClientView.Text = "View";
            // 
            // btnViewClientDependent
            // 
            this.btnViewClientDependent.Location = new System.Drawing.Point(115, 17);
            this.btnViewClientDependent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewClientDependent.Name = "btnViewClientDependent";
            this.btnViewClientDependent.Size = new System.Drawing.Size(106, 20);
            this.btnViewClientDependent.TabIndex = 24;
            this.btnViewClientDependent.Text = "View Dependents";
            this.btnViewClientDependent.UseVisualStyleBackColor = true;
            // 
            // btnViewAllClients
            // 
            this.btnViewAllClients.Location = new System.Drawing.Point(4, 17);
            this.btnViewAllClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewAllClients.Name = "btnViewAllClients";
            this.btnViewAllClients.Size = new System.Drawing.Size(106, 20);
            this.btnViewAllClients.TabIndex = 23;
            this.btnViewAllClients.Text = "View All Clients";
            this.btnViewAllClients.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.lblRightsClient);
            this.panel2.Location = new System.Drawing.Point(0, 489);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(736, 32);
            this.panel2.TabIndex = 24;
            // 
            // lblRightsClient
            // 
            this.lblRightsClient.AutoSize = true;
            this.lblRightsClient.Location = new System.Drawing.Point(322, 7);
            this.lblRightsClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRightsClient.Name = "lblRightsClient";
            this.lblRightsClient.Size = new System.Drawing.Size(178, 13);
            this.lblRightsClient.TabIndex = 0;
            this.lblRightsClient.Text = "Powered by Belgium Campus Alumni";
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(735, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbxClientView);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClient";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientView)).EndInit();
            this.gbxClientView.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCallCentre;
        private System.Windows.Forms.Button btnProviderClient;
        private System.Windows.Forms.Button btnPolicyClient;
        private System.Windows.Forms.Button btnMedicalClient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvClientView;
        private System.Windows.Forms.PictureBox pbxLogoClient;
        private System.Windows.Forms.GroupBox gbxClientView;
        private System.Windows.Forms.Button btnViewClientDependent;
        private System.Windows.Forms.Button btnViewAllClients;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRightsClient;
    }
}

