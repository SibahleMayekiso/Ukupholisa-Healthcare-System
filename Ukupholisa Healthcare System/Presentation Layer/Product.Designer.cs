
namespace Ukupholisa_Healthcare_System.Presentation_Layer
{
    partial class frmPolicyUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPolicyUI));
            this.btnClientPolicy = new System.Windows.Forms.Button();
            this.btnMedicalPolicy = new System.Windows.Forms.Button();
            this.btnProviderPolicy = new System.Windows.Forms.Button();
            this.btnCallCentrePolicy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbvPolicyView = new System.Windows.Forms.GroupBox();
            this.btnViewAllProducts = new System.Windows.Forms.Button();
            this.dgvPolicyDetailsView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRights = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAlltimeDate = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpReportEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpReportStart = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvReportView = new System.Windows.Forms.DataGridView();
            this.btnReportGen = new System.Windows.Forms.Button();
            this.PolicyDetials = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.PolicyName = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.rdbUnlimited = new System.Windows.Forms.RadioButton();
            this.gbxPolicyDetails = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpUpdateStart = new System.Windows.Forms.DateTimePicker();
            this.PolicyPrice = new System.Windows.Forms.Label();
            this.numProductId = new System.Windows.Forms.NumericUpDown();
            this.dtpUpdateEnd = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateAvailability = new System.Windows.Forms.Button();
            this.chkUpdateAvailabiltyTime = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbvPolicyView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolicyDetailsView)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportView)).BeginInit();
            this.gbxPolicyDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProductId)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClientPolicy
            // 
            this.btnClientPolicy.Location = new System.Drawing.Point(0, 93);
            this.btnClientPolicy.Name = "btnClientPolicy";
            this.btnClientPolicy.Size = new System.Drawing.Size(150, 65);
            this.btnClientPolicy.TabIndex = 27;
            this.btnClientPolicy.Text = "Client";
            this.btnClientPolicy.UseVisualStyleBackColor = true;
            this.btnClientPolicy.Click += new System.EventHandler(this.btnClientPolicy_Click);
            // 
            // btnMedicalPolicy
            // 
            this.btnMedicalPolicy.Location = new System.Drawing.Point(0, 307);
            this.btnMedicalPolicy.Name = "btnMedicalPolicy";
            this.btnMedicalPolicy.Size = new System.Drawing.Size(150, 65);
            this.btnMedicalPolicy.TabIndex = 26;
            this.btnMedicalPolicy.Text = "Medical";
            this.btnMedicalPolicy.UseVisualStyleBackColor = true;
            this.btnMedicalPolicy.Click += new System.EventHandler(this.btnMedicalPolicy_Click);
            // 
            // btnProviderPolicy
            // 
            this.btnProviderPolicy.Location = new System.Drawing.Point(0, 236);
            this.btnProviderPolicy.Name = "btnProviderPolicy";
            this.btnProviderPolicy.Size = new System.Drawing.Size(150, 65);
            this.btnProviderPolicy.TabIndex = 25;
            this.btnProviderPolicy.Text = "Provider";
            this.btnProviderPolicy.UseVisualStyleBackColor = true;
            this.btnProviderPolicy.Click += new System.EventHandler(this.btnProviderPolicy_Click);
            // 
            // btnCallCentrePolicy
            // 
            this.btnCallCentrePolicy.Location = new System.Drawing.Point(0, 164);
            this.btnCallCentrePolicy.Name = "btnCallCentrePolicy";
            this.btnCallCentrePolicy.Size = new System.Drawing.Size(150, 65);
            this.btnCallCentrePolicy.TabIndex = 24;
            this.btnCallCentrePolicy.Text = "Call Centre";
            this.btnCallCentrePolicy.UseVisualStyleBackColor = true;
            this.btnCallCentrePolicy.Click += new System.EventHandler(this.btnCallCentrePolicy_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnClientPolicy);
            this.panel1.Controls.Add(this.btnCallCentrePolicy);
            this.panel1.Controls.Add(this.btnProviderPolicy);
            this.panel1.Controls.Add(this.btnMedicalPolicy);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 466);
            this.panel1.TabIndex = 37;
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
            // gbvPolicyView
            // 
            this.gbvPolicyView.Controls.Add(this.btnViewAllProducts);
            this.gbvPolicyView.Controls.Add(this.dgvPolicyDetailsView);
            this.gbvPolicyView.Location = new System.Drawing.Point(156, 271);
            this.gbvPolicyView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbvPolicyView.Name = "gbvPolicyView";
            this.gbvPolicyView.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbvPolicyView.Size = new System.Drawing.Size(723, 214);
            this.gbvPolicyView.TabIndex = 36;
            this.gbvPolicyView.TabStop = false;
            this.gbvPolicyView.Text = "View";
            // 
            // btnViewAllProducts
            // 
            this.btnViewAllProducts.Location = new System.Drawing.Point(4, 18);
            this.btnViewAllProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewAllProducts.Name = "btnViewAllProducts";
            this.btnViewAllProducts.Size = new System.Drawing.Size(128, 19);
            this.btnViewAllProducts.TabIndex = 1;
            this.btnViewAllProducts.Text = "View All Products";
            this.btnViewAllProducts.UseVisualStyleBackColor = true;
            // 
            // dgvPolicyDetailsView
            // 
            this.dgvPolicyDetailsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolicyDetailsView.Location = new System.Drawing.Point(4, 41);
            this.dgvPolicyDetailsView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPolicyDetailsView.Name = "dgvPolicyDetailsView";
            this.dgvPolicyDetailsView.RowHeadersWidth = 51;
            this.dgvPolicyDetailsView.RowTemplate.Height = 24;
            this.dgvPolicyDetailsView.Size = new System.Drawing.Size(714, 168);
            this.dgvPolicyDetailsView.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.lblRights);
            this.panel2.Location = new System.Drawing.Point(1, 491);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(889, 32);
            this.panel2.TabIndex = 38;
            // 
            // lblRights
            // 
            this.lblRights.AutoSize = true;
            this.lblRights.Location = new System.Drawing.Point(306, 13);
            this.lblRights.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRights.Name = "lblRights";
            this.lblRights.Size = new System.Drawing.Size(176, 13);
            this.lblRights.TabIndex = 0;
            this.lblRights.Text = "Powered by Begium Campus Alumni";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAlltimeDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpReportEnd);
            this.groupBox1.Controls.Add(this.dtpReportStart);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dgvReportView);
            this.groupBox1.Controls.Add(this.btnReportGen);
            this.groupBox1.Location = new System.Drawing.Point(403, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(476, 146);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Summary";
            // 
            // chkAlltimeDate
            // 
            this.chkAlltimeDate.AutoSize = true;
            this.chkAlltimeDate.Location = new System.Drawing.Point(112, 23);
            this.chkAlltimeDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkAlltimeDate.Name = "chkAlltimeDate";
            this.chkAlltimeDate.Size = new System.Drawing.Size(69, 17);
            this.chkAlltimeDate.TabIndex = 8;
            this.chkAlltimeDate.Text = "Unlimited";
            this.chkAlltimeDate.UseVisualStyleBackColor = true;
            this.chkAlltimeDate.CheckedChanged += new System.EventHandler(this.chkAlltimeDate_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "View All-time Report";
            // 
            // dtpReportEnd
            // 
            this.dtpReportEnd.Location = new System.Drawing.Point(42, 78);
            this.dtpReportEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpReportEnd.Name = "dtpReportEnd";
            this.dtpReportEnd.Size = new System.Drawing.Size(151, 20);
            this.dtpReportEnd.TabIndex = 5;
            // 
            // dtpReportStart
            // 
            this.dtpReportStart.Location = new System.Drawing.Point(42, 52);
            this.dtpReportStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpReportStart.Name = "dtpReportStart";
            this.dtpReportStart.Size = new System.Drawing.Size(151, 20);
            this.dtpReportStart.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "End";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Start";
            // 
            // dgvReportView
            // 
            this.dgvReportView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportView.Location = new System.Drawing.Point(207, 11);
            this.dgvReportView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvReportView.Name = "dgvReportView";
            this.dgvReportView.RowHeadersWidth = 51;
            this.dgvReportView.RowTemplate.Height = 24;
            this.dgvReportView.Size = new System.Drawing.Size(265, 131);
            this.dgvReportView.TabIndex = 2;
            // 
            // btnReportGen
            // 
            this.btnReportGen.Location = new System.Drawing.Point(67, 105);
            this.btnReportGen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReportGen.Name = "btnReportGen";
            this.btnReportGen.Size = new System.Drawing.Size(78, 37);
            this.btnReportGen.TabIndex = 1;
            this.btnReportGen.Text = "Generate Report";
            this.btnReportGen.UseVisualStyleBackColor = true;
            this.btnReportGen.Click += new System.EventHandler(this.btnReportGen_Click);
            // 
            // PolicyDetials
            // 
            this.PolicyDetials.AutoSize = true;
            this.PolicyDetials.Location = new System.Drawing.Point(5, 75);
            this.PolicyDetials.Name = "PolicyDetials";
            this.PolicyDetials.Size = new System.Drawing.Size(55, 13);
            this.PolicyDetials.TabIndex = 29;
            this.PolicyDetials.Text = "Start Date";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(94, 20);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(144, 20);
            this.txtProductName.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "End Date";
            // 
            // txtProductType
            // 
            this.txtProductType.Location = new System.Drawing.Point(94, 46);
            this.txtProductType.Name = "txtProductType";
            this.txtProductType.Size = new System.Drawing.Size(144, 20);
            this.txtProductType.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Product Type";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(94, 71);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(144, 20);
            this.dtpStartDate.TabIndex = 38;
            // 
            // PolicyName
            // 
            this.PolicyName.AutoSize = true;
            this.PolicyName.Location = new System.Drawing.Point(5, 22);
            this.PolicyName.Name = "PolicyName";
            this.PolicyName.Size = new System.Drawing.Size(75, 13);
            this.PolicyName.TabIndex = 28;
            this.PolicyName.Text = "Product Name";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(71, 176);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(94, 28);
            this.btnAddProduct.TabIndex = 36;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(94, 116);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(144, 20);
            this.dtpEndDate.TabIndex = 38;
            // 
            // rdbUnlimited
            // 
            this.rdbUnlimited.AutoSize = true;
            this.rdbUnlimited.Location = new System.Drawing.Point(94, 95);
            this.rdbUnlimited.Margin = new System.Windows.Forms.Padding(2);
            this.rdbUnlimited.Name = "rdbUnlimited";
            this.rdbUnlimited.Size = new System.Drawing.Size(94, 17);
            this.rdbUnlimited.TabIndex = 41;
            this.rdbUnlimited.TabStop = true;
            this.rdbUnlimited.Text = "Unlimited Offer";
            this.rdbUnlimited.UseVisualStyleBackColor = true;
            // 
            // gbxPolicyDetails
            // 
            this.gbxPolicyDetails.Controls.Add(this.rdbUnlimited);
            this.gbxPolicyDetails.Controls.Add(this.dtpEndDate);
            this.gbxPolicyDetails.Controls.Add(this.btnAddProduct);
            this.gbxPolicyDetails.Controls.Add(this.PolicyName);
            this.gbxPolicyDetails.Controls.Add(this.dtpStartDate);
            this.gbxPolicyDetails.Controls.Add(this.label2);
            this.gbxPolicyDetails.Controls.Add(this.txtProductType);
            this.gbxPolicyDetails.Controls.Add(this.label1);
            this.gbxPolicyDetails.Controls.Add(this.txtProductName);
            this.gbxPolicyDetails.Controls.Add(this.PolicyDetials);
            this.gbxPolicyDetails.Location = new System.Drawing.Point(156, 10);
            this.gbxPolicyDetails.Margin = new System.Windows.Forms.Padding(2);
            this.gbxPolicyDetails.Name = "gbxPolicyDetails";
            this.gbxPolicyDetails.Padding = new System.Windows.Forms.Padding(2);
            this.gbxPolicyDetails.Size = new System.Drawing.Size(242, 256);
            this.gbxPolicyDetails.TabIndex = 36;
            this.gbxPolicyDetails.TabStop = false;
            this.gbxPolicyDetails.Text = "Product details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "End Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Start Date";
            // 
            // dtpUpdateStart
            // 
            this.dtpUpdateStart.Location = new System.Drawing.Point(180, 24);
            this.dtpUpdateStart.Margin = new System.Windows.Forms.Padding(2);
            this.dtpUpdateStart.Name = "dtpUpdateStart";
            this.dtpUpdateStart.Size = new System.Drawing.Size(144, 20);
            this.dtpUpdateStart.TabIndex = 38;
            // 
            // PolicyPrice
            // 
            this.PolicyPrice.AutoSize = true;
            this.PolicyPrice.Location = new System.Drawing.Point(5, 28);
            this.PolicyPrice.Name = "PolicyPrice";
            this.PolicyPrice.Size = new System.Drawing.Size(58, 13);
            this.PolicyPrice.TabIndex = 30;
            this.PolicyPrice.Text = "Product ID";
            // 
            // numProductId
            // 
            this.numProductId.Location = new System.Drawing.Point(8, 47);
            this.numProductId.Margin = new System.Windows.Forms.Padding(2);
            this.numProductId.Name = "numProductId";
            this.numProductId.Size = new System.Drawing.Size(90, 20);
            this.numProductId.TabIndex = 39;
            // 
            // dtpUpdateEnd
            // 
            this.dtpUpdateEnd.Location = new System.Drawing.Point(180, 69);
            this.dtpUpdateEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dtpUpdateEnd.Name = "dtpUpdateEnd";
            this.dtpUpdateEnd.Size = new System.Drawing.Size(144, 20);
            this.dtpUpdateEnd.TabIndex = 38;
            // 
            // btnUpdateAvailability
            // 
            this.btnUpdateAvailability.Location = new System.Drawing.Point(4, 73);
            this.btnUpdateAvailability.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateAvailability.Name = "btnUpdateAvailability";
            this.btnUpdateAvailability.Size = new System.Drawing.Size(94, 28);
            this.btnUpdateAvailability.TabIndex = 0;
            this.btnUpdateAvailability.Text = "Update";
            this.btnUpdateAvailability.UseVisualStyleBackColor = true;
            // 
            // chkUpdateAvailabiltyTime
            // 
            this.chkUpdateAvailabiltyTime.AutoSize = true;
            this.chkUpdateAvailabiltyTime.Location = new System.Drawing.Point(180, 48);
            this.chkUpdateAvailabiltyTime.Margin = new System.Windows.Forms.Padding(2);
            this.chkUpdateAvailabiltyTime.Name = "chkUpdateAvailabiltyTime";
            this.chkUpdateAvailabiltyTime.Size = new System.Drawing.Size(69, 17);
            this.chkUpdateAvailabiltyTime.TabIndex = 40;
            this.chkUpdateAvailabiltyTime.Text = "Unlimited";
            this.chkUpdateAvailabiltyTime.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkUpdateAvailabiltyTime);
            this.groupBox2.Controls.Add(this.btnUpdateAvailability);
            this.groupBox2.Controls.Add(this.dtpUpdateEnd);
            this.groupBox2.Controls.Add(this.numProductId);
            this.groupBox2.Controls.Add(this.PolicyPrice);
            this.groupBox2.Controls.Add(this.dtpUpdateStart);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(404, 159);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(476, 106);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Product Availability";
            // 
            // frmPolicyUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(888, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbvPolicyView);
            this.Controls.Add(this.gbxPolicyDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPolicyUI";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.frmPolicyUI_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbvPolicyView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolicyDetailsView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportView)).EndInit();
            this.gbxPolicyDetails.ResumeLayout(false);
            this.gbxPolicyDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProductId)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientPolicy;
        private System.Windows.Forms.Button btnMedicalPolicy;
        private System.Windows.Forms.Button btnProviderPolicy;
        private System.Windows.Forms.Button btnCallCentrePolicy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbvPolicyView;
        private System.Windows.Forms.DataGridView dgvPolicyDetailsView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRights;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReportGen;
        private System.Windows.Forms.Button btnViewAllProducts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpReportEnd;
        private System.Windows.Forms.DateTimePicker dtpReportStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvReportView;
        private System.Windows.Forms.CheckBox chkAlltimeDate;
        private System.Windows.Forms.Label PolicyDetials;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label PolicyName;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.RadioButton rdbUnlimited;
        private System.Windows.Forms.GroupBox gbxPolicyDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpUpdateStart;
        private System.Windows.Forms.Label PolicyPrice;
        private System.Windows.Forms.NumericUpDown numProductId;
        private System.Windows.Forms.DateTimePicker dtpUpdateEnd;
        private System.Windows.Forms.Button btnUpdateAvailability;
        private System.Windows.Forms.CheckBox chkUpdateAvailabiltyTime;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}