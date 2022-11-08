
namespace Ukupholisa_Healthcare_System.Presentation_Layer
{
    partial class frmMedicalUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicalUI));
            this.btnClient = new System.Windows.Forms.Button();
            this.btnPolicy = new System.Windows.Forms.Button();
            this.btnProvider = new System.Windows.Forms.Button();
            this.btnCallCentre = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnViewConditionsNTreatments = new System.Windows.Forms.Button();
            this.btnViewTreatments = new System.Windows.Forms.Button();
            this.btnViewMedicalConditons = new System.Windows.Forms.Button();
            this.dgvViewMedTreatments = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewMedTreatments)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(0, 143);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(150, 45);
            this.btnClient.TabIndex = 23;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnPolicy
            // 
            this.btnPolicy.Location = new System.Drawing.Point(0, 253);
            this.btnPolicy.Name = "btnPolicy";
            this.btnPolicy.Size = new System.Drawing.Size(150, 45);
            this.btnPolicy.TabIndex = 22;
            this.btnPolicy.Text = "Policies";
            this.btnPolicy.UseVisualStyleBackColor = true;
            this.btnPolicy.Click += new System.EventHandler(this.btnPolicy_Click);
            // 
            // btnProvider
            // 
            this.btnProvider.Location = new System.Drawing.Point(0, 201);
            this.btnProvider.Name = "btnProvider";
            this.btnProvider.Size = new System.Drawing.Size(150, 45);
            this.btnProvider.TabIndex = 21;
            this.btnProvider.Text = "Provider";
            this.btnProvider.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProvider.UseVisualStyleBackColor = true;
            this.btnProvider.Click += new System.EventHandler(this.btnProvider_Click);
            // 
            // btnCallCentre
            // 
            this.btnCallCentre.Location = new System.Drawing.Point(0, 92);
            this.btnCallCentre.Name = "btnCallCentre";
            this.btnCallCentre.Size = new System.Drawing.Size(150, 45);
            this.btnCallCentre.TabIndex = 20;
            this.btnCallCentre.Text = "Call Centre";
            this.btnCallCentre.UseVisualStyleBackColor = true;
            this.btnCallCentre.Click += new System.EventHandler(this.btnCallCentre_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnClient);
            this.panel1.Controls.Add(this.btnCallCentre);
            this.panel1.Controls.Add(this.btnProvider);
            this.panel1.Controls.Add(this.btnPolicy);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 338);
            this.panel1.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnViewConditionsNTreatments);
            this.groupBox3.Controls.Add(this.btnViewTreatments);
            this.groupBox3.Controls.Add(this.btnViewMedicalConditons);
            this.groupBox3.Controls.Add(this.dgvViewMedTreatments);
            this.groupBox3.Location = new System.Drawing.Point(162, 51);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(592, 256);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View";
            // 
            // btnViewConditionsNTreatments
            // 
            this.btnViewConditionsNTreatments.Location = new System.Drawing.Point(368, 18);
            this.btnViewConditionsNTreatments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewConditionsNTreatments.Name = "btnViewConditionsNTreatments";
            this.btnViewConditionsNTreatments.Size = new System.Drawing.Size(220, 23);
            this.btnViewConditionsNTreatments.TabIndex = 2;
            this.btnViewConditionsNTreatments.Text = "View Conditions with Treatments";
            this.btnViewConditionsNTreatments.UseVisualStyleBackColor = true;
            // 
            // btnViewTreatments
            // 
            this.btnViewTreatments.Location = new System.Drawing.Point(199, 18);
            this.btnViewTreatments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewTreatments.Name = "btnViewTreatments";
            this.btnViewTreatments.Size = new System.Drawing.Size(164, 23);
            this.btnViewTreatments.TabIndex = 2;
            this.btnViewTreatments.Text = "View Treatments";
            this.btnViewTreatments.UseVisualStyleBackColor = true;
            this.btnViewTreatments.Click += new System.EventHandler(this.btnViewTreatments_Click);
            // 
            // btnViewMedicalConditons
            // 
            this.btnViewMedicalConditons.Location = new System.Drawing.Point(4, 18);
            this.btnViewMedicalConditons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewMedicalConditons.Name = "btnViewMedicalConditons";
            this.btnViewMedicalConditons.Size = new System.Drawing.Size(190, 23);
            this.btnViewMedicalConditons.TabIndex = 1;
            this.btnViewMedicalConditons.Text = "View Medical Conditons";
            this.btnViewMedicalConditons.UseVisualStyleBackColor = true;
            this.btnViewMedicalConditons.Click += new System.EventHandler(this.btnViewMedicalConditons_Click);
            // 
            // dgvViewMedTreatments
            // 
            this.dgvViewMedTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewMedTreatments.Location = new System.Drawing.Point(4, 46);
            this.dgvViewMedTreatments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvViewMedTreatments.Name = "dgvViewMedTreatments";
            this.dgvViewMedTreatments.RowHeadersWidth = 51;
            this.dgvViewMedTreatments.RowTemplate.Height = 24;
            this.dgvViewMedTreatments.Size = new System.Drawing.Size(584, 206);
            this.dgvViewMedTreatments.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(1, 343);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 32);
            this.panel2.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Powered by Belgium Campus Alumni";
            // 
            // frmMedicalUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(754, 375);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMedicalUI";
            this.Text = "Medical";
            this.Load += new System.EventHandler(this.frmMedicalUI_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewMedTreatments)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnPolicy;
        private System.Windows.Forms.Button btnProvider;
        private System.Windows.Forms.Button btnCallCentre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvViewMedTreatments;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnViewTreatments;
        private System.Windows.Forms.Button btnViewMedicalConditons;
        private System.Windows.Forms.Button btnViewConditionsNTreatments;
    }
}