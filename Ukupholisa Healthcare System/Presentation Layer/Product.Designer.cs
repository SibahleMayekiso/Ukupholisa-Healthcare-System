
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
            this.PolicyName = new System.Windows.Forms.Label();
            this.PolicyDetials = new System.Windows.Forms.Label();
            this.PolicyPrice = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.gbxPolicyDetails = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.numProductId = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkUpdateAvailabiltyTime = new System.Windows.Forms.CheckBox();
            this.btnUpdateAvailability = new System.Windows.Forms.Button();
            this.dtpUpdateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpUpdateStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numMaxDependents = new System.Windows.Forms.NumericUpDown();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.chkProductAvailability = new System.Windows.Forms.CheckBox();
            this.gbxPolicyDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbvPolicyView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolicyDetailsView)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProductId)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDependents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClientPolicy
            // 
            this.btnClientPolicy.Location = new System.Drawing.Point(0, 114);
            this.btnClientPolicy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClientPolicy.Name = "btnClientPolicy";
            this.btnClientPolicy.Size = new System.Drawing.Size(200, 80);
            this.btnClientPolicy.TabIndex = 27;
            this.btnClientPolicy.Text = "Client";
            this.btnClientPolicy.UseVisualStyleBackColor = true;
            this.btnClientPolicy.Click += new System.EventHandler(this.btnClientPolicy_Click);
            // 
            // btnMedicalPolicy
            // 
            this.btnMedicalPolicy.Location = new System.Drawing.Point(0, 378);
            this.btnMedicalPolicy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMedicalPolicy.Name = "btnMedicalPolicy";
            this.btnMedicalPolicy.Size = new System.Drawing.Size(200, 80);
            this.btnMedicalPolicy.TabIndex = 26;
            this.btnMedicalPolicy.Text = "Medical";
            this.btnMedicalPolicy.UseVisualStyleBackColor = true;
            this.btnMedicalPolicy.Click += new System.EventHandler(this.btnMedicalPolicy_Click);
            // 
            // btnProviderPolicy
            // 
            this.btnProviderPolicy.Location = new System.Drawing.Point(0, 290);
            this.btnProviderPolicy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProviderPolicy.Name = "btnProviderPolicy";
            this.btnProviderPolicy.Size = new System.Drawing.Size(200, 80);
            this.btnProviderPolicy.TabIndex = 25;
            this.btnProviderPolicy.Text = "Provider";
            this.btnProviderPolicy.UseVisualStyleBackColor = true;
            this.btnProviderPolicy.Click += new System.EventHandler(this.btnProviderPolicy_Click);
            // 
            // btnCallCentrePolicy
            // 
            this.btnCallCentrePolicy.Location = new System.Drawing.Point(0, 202);
            this.btnCallCentrePolicy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCallCentrePolicy.Name = "btnCallCentrePolicy";
            this.btnCallCentrePolicy.Size = new System.Drawing.Size(200, 80);
            this.btnCallCentrePolicy.TabIndex = 24;
            this.btnCallCentrePolicy.Text = "Call Centre";
            this.btnCallCentrePolicy.UseVisualStyleBackColor = true;
            this.btnCallCentrePolicy.Click += new System.EventHandler(this.btnCallCentrePolicy_Click);
            // 
            // PolicyName
            // 
            this.PolicyName.AutoSize = true;
            this.PolicyName.Location = new System.Drawing.Point(7, 27);
            this.PolicyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PolicyName.Name = "PolicyName";
            this.PolicyName.Size = new System.Drawing.Size(93, 16);
            this.PolicyName.TabIndex = 28;
            this.PolicyName.Text = "Product Name";
            // 
            // PolicyDetials
            // 
            this.PolicyDetials.AutoSize = true;
            this.PolicyDetials.Location = new System.Drawing.Point(7, 133);
            this.PolicyDetials.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PolicyDetials.Name = "PolicyDetials";
            this.PolicyDetials.Size = new System.Drawing.Size(66, 16);
            this.PolicyDetials.TabIndex = 29;
            this.PolicyDetials.Text = "Start Date";
            // 
            // PolicyPrice
            // 
            this.PolicyPrice.AutoSize = true;
            this.PolicyPrice.Location = new System.Drawing.Point(7, 34);
            this.PolicyPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PolicyPrice.Name = "PolicyPrice";
            this.PolicyPrice.Size = new System.Drawing.Size(69, 16);
            this.PolicyPrice.TabIndex = 30;
            this.PolicyPrice.Text = "Product ID";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(125, 25);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(191, 22);
            this.txtProductName.TabIndex = 32;
            // 
            // gbxPolicyDetails
            // 
            this.gbxPolicyDetails.Controls.Add(this.chkProductAvailability);
            this.gbxPolicyDetails.Controls.Add(this.cmbProductType);
            this.gbxPolicyDetails.Controls.Add(this.numMaxDependents);
            this.gbxPolicyDetails.Controls.Add(this.label8);
            this.gbxPolicyDetails.Controls.Add(this.dtpEndDate);
            this.gbxPolicyDetails.Controls.Add(this.btnAddProduct);
            this.gbxPolicyDetails.Controls.Add(this.PolicyName);
            this.gbxPolicyDetails.Controls.Add(this.dtpStartDate);
            this.gbxPolicyDetails.Controls.Add(this.label2);
            this.gbxPolicyDetails.Controls.Add(this.label1);
            this.gbxPolicyDetails.Controls.Add(this.txtProductName);
            this.gbxPolicyDetails.Controls.Add(this.PolicyDetials);
            this.gbxPolicyDetails.Location = new System.Drawing.Point(208, 12);
            this.gbxPolicyDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxPolicyDetails.Name = "gbxPolicyDetails";
            this.gbxPolicyDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxPolicyDetails.Size = new System.Drawing.Size(323, 315);
            this.gbxPolicyDetails.TabIndex = 36;
            this.gbxPolicyDetails.TabStop = false;
            this.gbxPolicyDetails.Text = "Product details";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(125, 184);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(191, 22);
            this.dtpEndDate.TabIndex = 38;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(95, 217);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(125, 34);
            this.btnAddProduct.TabIndex = 36;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(125, 128);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(191, 22);
            this.dtpStartDate.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Product Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "End Date";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnClientPolicy);
            this.panel1.Controls.Add(this.btnCallCentrePolicy);
            this.panel1.Controls.Add(this.btnProviderPolicy);
            this.panel1.Controls.Add(this.btnMedicalPolicy);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 574);
            this.panel1.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbvPolicyView
            // 
            this.gbvPolicyView.Controls.Add(this.btnViewAllProducts);
            this.gbvPolicyView.Controls.Add(this.dgvPolicyDetailsView);
            this.gbvPolicyView.Location = new System.Drawing.Point(208, 334);
            this.gbvPolicyView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbvPolicyView.Name = "gbvPolicyView";
            this.gbvPolicyView.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbvPolicyView.Size = new System.Drawing.Size(964, 263);
            this.gbvPolicyView.TabIndex = 36;
            this.gbvPolicyView.TabStop = false;
            this.gbvPolicyView.Text = "View";
            // 
            // btnViewAllProducts
            // 
            this.btnViewAllProducts.Location = new System.Drawing.Point(5, 22);
            this.btnViewAllProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewAllProducts.Name = "btnViewAllProducts";
            this.btnViewAllProducts.Size = new System.Drawing.Size(171, 23);
            this.btnViewAllProducts.TabIndex = 1;
            this.btnViewAllProducts.Text = "View All Products";
            this.btnViewAllProducts.UseVisualStyleBackColor = true;
            this.btnViewAllProducts.Click += new System.EventHandler(this.btnViewAllProducts_Click);
            // 
            // dgvPolicyDetailsView
            // 
            this.dgvPolicyDetailsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolicyDetailsView.Location = new System.Drawing.Point(5, 50);
            this.dgvPolicyDetailsView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPolicyDetailsView.Name = "dgvPolicyDetailsView";
            this.dgvPolicyDetailsView.RowHeadersWidth = 51;
            this.dgvPolicyDetailsView.RowTemplate.Height = 24;
            this.dgvPolicyDetailsView.Size = new System.Drawing.Size(952, 207);
            this.dgvPolicyDetailsView.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.lblRights);
            this.panel2.Location = new System.Drawing.Point(1, 604);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1185, 39);
            this.panel2.TabIndex = 38;
            // 
            // lblRights
            // 
            this.lblRights.AutoSize = true;
            this.lblRights.Location = new System.Drawing.Point(408, 16);
            this.lblRights.Name = "lblRights";
            this.lblRights.Size = new System.Drawing.Size(224, 16);
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
            this.groupBox1.Location = new System.Drawing.Point(537, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(635, 180);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Summary";
            // 
            // chkAlltimeDate
            // 
            this.chkAlltimeDate.AutoSize = true;
            this.chkAlltimeDate.Location = new System.Drawing.Point(149, 28);
            this.chkAlltimeDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAlltimeDate.Name = "chkAlltimeDate";
            this.chkAlltimeDate.Size = new System.Drawing.Size(85, 20);
            this.chkAlltimeDate.TabIndex = 8;
            this.chkAlltimeDate.Text = "Unlimited";
            this.chkAlltimeDate.UseVisualStyleBackColor = true;
            this.chkAlltimeDate.CheckedChanged += new System.EventHandler(this.chkAlltimeDate_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "View All-time Report";
            // 
            // dtpReportEnd
            // 
            this.dtpReportEnd.Location = new System.Drawing.Point(56, 96);
            this.dtpReportEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpReportEnd.Name = "dtpReportEnd";
            this.dtpReportEnd.Size = new System.Drawing.Size(200, 22);
            this.dtpReportEnd.TabIndex = 5;
            // 
            // dtpReportStart
            // 
            this.dtpReportStart.Location = new System.Drawing.Point(56, 64);
            this.dtpReportStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpReportStart.Name = "dtpReportStart";
            this.dtpReportStart.Size = new System.Drawing.Size(200, 22);
            this.dtpReportStart.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "End";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Start";
            // 
            // dgvReportView
            // 
            this.dgvReportView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportView.Location = new System.Drawing.Point(276, 14);
            this.dgvReportView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvReportView.Name = "dgvReportView";
            this.dgvReportView.RowHeadersWidth = 51;
            this.dgvReportView.RowTemplate.Height = 24;
            this.dgvReportView.Size = new System.Drawing.Size(353, 161);
            this.dgvReportView.TabIndex = 2;
            // 
            // btnReportGen
            // 
            this.btnReportGen.Location = new System.Drawing.Point(89, 129);
            this.btnReportGen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReportGen.Name = "btnReportGen";
            this.btnReportGen.Size = new System.Drawing.Size(104, 46);
            this.btnReportGen.TabIndex = 1;
            this.btnReportGen.Text = "Generate Report";
            this.btnReportGen.UseVisualStyleBackColor = true;
            this.btnReportGen.Click += new System.EventHandler(this.btnReportGen_Click);
            // 
            // numProductId
            // 
            this.numProductId.Location = new System.Drawing.Point(11, 58);
            this.numProductId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numProductId.Name = "numProductId";
            this.numProductId.Size = new System.Drawing.Size(120, 22);
            this.numProductId.TabIndex = 39;
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
            this.groupBox2.Location = new System.Drawing.Point(539, 196);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(635, 130);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Product Availability";
            // 
            // chkUpdateAvailabiltyTime
            // 
            this.chkUpdateAvailabiltyTime.AutoSize = true;
            this.chkUpdateAvailabiltyTime.Location = new System.Drawing.Point(240, 59);
            this.chkUpdateAvailabiltyTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkUpdateAvailabiltyTime.Name = "chkUpdateAvailabiltyTime";
            this.chkUpdateAvailabiltyTime.Size = new System.Drawing.Size(85, 20);
            this.chkUpdateAvailabiltyTime.TabIndex = 40;
            this.chkUpdateAvailabiltyTime.Text = "Unlimited";
            this.chkUpdateAvailabiltyTime.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAvailability
            // 
            this.btnUpdateAvailability.Location = new System.Drawing.Point(5, 90);
            this.btnUpdateAvailability.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateAvailability.Name = "btnUpdateAvailability";
            this.btnUpdateAvailability.Size = new System.Drawing.Size(125, 34);
            this.btnUpdateAvailability.TabIndex = 0;
            this.btnUpdateAvailability.Text = "Update";
            this.btnUpdateAvailability.UseVisualStyleBackColor = true;
            // 
            // dtpUpdateEnd
            // 
            this.dtpUpdateEnd.Location = new System.Drawing.Point(240, 85);
            this.dtpUpdateEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpUpdateEnd.Name = "dtpUpdateEnd";
            this.dtpUpdateEnd.Size = new System.Drawing.Size(191, 22);
            this.dtpUpdateEnd.TabIndex = 38;
            // 
            // dtpUpdateStart
            // 
            this.dtpUpdateStart.Location = new System.Drawing.Point(240, 30);
            this.dtpUpdateStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpUpdateStart.Name = "dtpUpdateStart";
            this.dtpUpdateStart.Size = new System.Drawing.Size(191, 22);
            this.dtpUpdateStart.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "End Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "Maximum Allowed Dependents";
            // 
            // numMaxDependents
            // 
            this.numMaxDependents.Location = new System.Drawing.Point(208, 97);
            this.numMaxDependents.Name = "numMaxDependents";
            this.numMaxDependents.Size = new System.Drawing.Size(108, 22);
            this.numMaxDependents.TabIndex = 43;
            // 
            // cmbProductType
            // 
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Items.AddRange(new object[] {
            "Exclusive",
            "Premium",
            "General",
            "Budget"});
            this.cmbProductType.Location = new System.Drawing.Point(125, 59);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(191, 24);
            this.cmbProductType.TabIndex = 44;
            // 
            // chkProductAvailability
            // 
            this.chkProductAvailability.AutoSize = true;
            this.chkProductAvailability.Location = new System.Drawing.Point(125, 156);
            this.chkProductAvailability.Name = "chkProductAvailability";
            this.chkProductAvailability.Size = new System.Drawing.Size(85, 20);
            this.chkProductAvailability.TabIndex = 45;
            this.chkProductAvailability.Text = "Unlimited";
            this.chkProductAvailability.UseVisualStyleBackColor = true;
            this.chkProductAvailability.CheckedChanged += new System.EventHandler(this.chkProductAvailability_CheckedChanged);
            // 
            // frmPolicyUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1184, 644);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbvPolicyView);
            this.Controls.Add(this.gbxPolicyDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPolicyUI";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.frmPolicyUI_Load);
            this.gbxPolicyDetails.ResumeLayout(false);
            this.gbxPolicyDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbvPolicyView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolicyDetailsView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProductId)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDependents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientPolicy;
        private System.Windows.Forms.Button btnMedicalPolicy;
        private System.Windows.Forms.Button btnProviderPolicy;
        private System.Windows.Forms.Button btnCallCentrePolicy;
        private System.Windows.Forms.Label PolicyName;
        private System.Windows.Forms.Label PolicyDetials;
        private System.Windows.Forms.Label PolicyPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.GroupBox gbxPolicyDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbvPolicyView;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dgvPolicyDetailsView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRights;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReportGen;
        private System.Windows.Forms.NumericUpDown numProductId;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdateAvailability;
        private System.Windows.Forms.DateTimePicker dtpUpdateEnd;
        private System.Windows.Forms.DateTimePicker dtpUpdateStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnViewAllProducts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpReportEnd;
        private System.Windows.Forms.DateTimePicker dtpReportStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvReportView;
        private System.Windows.Forms.CheckBox chkAlltimeDate;
        private System.Windows.Forms.CheckBox chkUpdateAvailabiltyTime;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.NumericUpDown numMaxDependents;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkProductAvailability;
    }
}