namespace Ukupholisa_Healthcare_System.Presentation_Layer
{
    partial class frmProviderUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProviderUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMedical = new System.Windows.Forms.Button();
            this.btnPolicy = new System.Windows.Forms.Button();
            this.btnCallCentreNav = new System.Windows.Forms.Button();
            this.btnClientNav = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numChargeRate = new System.Windows.Forms.NumericUpDown();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtProviderEmail = new System.Windows.Forms.TextBox();
            this.txtProviderName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSendNegotiation = new System.Windows.Forms.Button();
            this.numNegotiateRate = new System.Windows.Forms.NumericUpDown();
            this.numIdSelector = new System.Windows.Forms.NumericUpDown();
            this.btnProviderSearch = new System.Windows.Forms.Button();
            this.txtCurrentRate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAllProvderDetails = new System.Windows.Forms.Button();
            this.dgvProviderUiView = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTreatmentUpdate = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numSearchId = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProviderRating = new System.Windows.Forms.TextBox();
            this.cmbProviderStatus = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChargeRate)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNegotiateRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdSelector)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviderUiView)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSearchId)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMedical);
            this.panel1.Controls.Add(this.btnPolicy);
            this.panel1.Controls.Add(this.btnCallCentreNav);
            this.panel1.Controls.Add(this.btnClientNav);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 572);
            this.panel1.TabIndex = 0;
            // 
            // btnMedical
            // 
            this.btnMedical.Location = new System.Drawing.Point(0, 322);
            this.btnMedical.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMedical.Name = "btnMedical";
            this.btnMedical.Size = new System.Drawing.Size(200, 55);
            this.btnMedical.TabIndex = 4;
            this.btnMedical.Text = "Medical";
            this.btnMedical.UseVisualStyleBackColor = true;
            this.btnMedical.Click += new System.EventHandler(this.btnMedical_Click);
            // 
            // btnPolicy
            // 
            this.btnPolicy.Location = new System.Drawing.Point(0, 249);
            this.btnPolicy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPolicy.Name = "btnPolicy";
            this.btnPolicy.Size = new System.Drawing.Size(200, 55);
            this.btnPolicy.TabIndex = 3;
            this.btnPolicy.Text = "Policies";
            this.btnPolicy.UseVisualStyleBackColor = true;
            this.btnPolicy.Click += new System.EventHandler(this.btnPolicy_Click);
            // 
            // btnCallCentreNav
            // 
            this.btnCallCentreNav.Location = new System.Drawing.Point(0, 174);
            this.btnCallCentreNav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCallCentreNav.Name = "btnCallCentreNav";
            this.btnCallCentreNav.Size = new System.Drawing.Size(200, 55);
            this.btnCallCentreNav.TabIndex = 2;
            this.btnCallCentreNav.Text = "Call Centre";
            this.btnCallCentreNav.UseVisualStyleBackColor = true;
            this.btnCallCentreNav.Click += new System.EventHandler(this.btnCallCentreNav_Click);
            // 
            // btnClientNav
            // 
            this.btnClientNav.Location = new System.Drawing.Point(0, 97);
            this.btnClientNav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClientNav.Name = "btnClientNav";
            this.btnClientNav.Size = new System.Drawing.Size(200, 55);
            this.btnClientNav.TabIndex = 1;
            this.btnClientNav.Text = "Client";
            this.btnClientNav.UseVisualStyleBackColor = true;
            this.btnClientNav.Click += new System.EventHandler(this.btnClientNav_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(0, 616);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 39);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Powered by Belgium Campus Alumni";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbProviderStatus);
            this.groupBox1.Controls.Add(this.txtProviderRating);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.numChargeRate);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtProviderEmail);
            this.groupBox1.Controls.Add(this.txtProviderName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(205, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(343, 227);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Provider";
            // 
            // numChargeRate
            // 
            this.numChargeRate.Location = new System.Drawing.Point(179, 82);
            this.numChargeRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numChargeRate.Name = "numChargeRate";
            this.numChargeRate.Size = new System.Drawing.Size(140, 22);
            this.numChargeRate.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(175, 183);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 34);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(73, 183);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 34);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtProviderEmail
            // 
            this.txtProviderEmail.Location = new System.Drawing.Point(179, 52);
            this.txtProviderEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProviderEmail.Name = "txtProviderEmail";
            this.txtProviderEmail.Size = new System.Drawing.Size(140, 22);
            this.txtProviderEmail.TabIndex = 1;
            // 
            // txtProviderName
            // 
            this.txtProviderName.Location = new System.Drawing.Point(179, 25);
            this.txtProviderName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProviderName.Name = "txtProviderName";
            this.txtProviderName.Size = new System.Drawing.Size(140, 22);
            this.txtProviderName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Provider Charge Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Provider Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Provider Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Provider ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Treatment ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSendNegotiation);
            this.groupBox2.Controls.Add(this.numNegotiateRate);
            this.groupBox2.Controls.Add(this.numIdSelector);
            this.groupBox2.Controls.Add(this.btnProviderSearch);
            this.groupBox2.Controls.Add(this.txtCurrentRate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(573, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(343, 175);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Negotiations";
            // 
            // btnSendNegotiation
            // 
            this.btnSendNegotiation.Location = new System.Drawing.Point(123, 133);
            this.btnSendNegotiation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendNegotiation.Name = "btnSendNegotiation";
            this.btnSendNegotiation.Size = new System.Drawing.Size(95, 34);
            this.btnSendNegotiation.TabIndex = 5;
            this.btnSendNegotiation.Text = "Send";
            this.btnSendNegotiation.UseVisualStyleBackColor = true;
            this.btnSendNegotiation.Click += new System.EventHandler(this.btnSendNegotiation_Click);
            // 
            // numNegotiateRate
            // 
            this.numNegotiateRate.Location = new System.Drawing.Point(179, 105);
            this.numNegotiateRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numNegotiateRate.Name = "numNegotiateRate";
            this.numNegotiateRate.Size = new System.Drawing.Size(140, 22);
            this.numNegotiateRate.TabIndex = 4;
            // 
            // numIdSelector
            // 
            this.numIdSelector.Location = new System.Drawing.Point(117, 27);
            this.numIdSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numIdSelector.Name = "numIdSelector";
            this.numIdSelector.Size = new System.Drawing.Size(120, 22);
            this.numIdSelector.TabIndex = 3;
            // 
            // btnProviderSearch
            // 
            this.btnProviderSearch.Location = new System.Drawing.Point(244, 20);
            this.btnProviderSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProviderSearch.Name = "btnProviderSearch";
            this.btnProviderSearch.Size = new System.Drawing.Size(95, 34);
            this.btnProviderSearch.TabIndex = 2;
            this.btnProviderSearch.Text = "Search";
            this.btnProviderSearch.UseVisualStyleBackColor = true;
            // 
            // txtCurrentRate
            // 
            this.txtCurrentRate.Location = new System.Drawing.Point(179, 71);
            this.txtCurrentRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCurrentRate.Name = "txtCurrentRate";
            this.txtCurrentRate.Size = new System.Drawing.Size(140, 22);
            this.txtCurrentRate.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Negotiated Charge Rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Current Rate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Provider  ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAllProvderDetails);
            this.groupBox3.Controls.Add(this.dgvProviderUiView);
            this.groupBox3.Location = new System.Drawing.Point(206, 354);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(709, 258);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View";
            // 
            // btnAllProvderDetails
            // 
            this.btnAllProvderDetails.Location = new System.Drawing.Point(5, 26);
            this.btnAllProvderDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAllProvderDetails.Name = "btnAllProvderDetails";
            this.btnAllProvderDetails.Size = new System.Drawing.Size(315, 34);
            this.btnAllProvderDetails.TabIndex = 1;
            this.btnAllProvderDetails.Text = "ViewAll Providers";
            this.btnAllProvderDetails.UseVisualStyleBackColor = true;
            this.btnAllProvderDetails.Click += new System.EventHandler(this.btnAllProvderDetails_Click);
            // 
            // dgvProviderUiView
            // 
            this.dgvProviderUiView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProviderUiView.Location = new System.Drawing.Point(5, 66);
            this.dgvProviderUiView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProviderUiView.Name = "dgvProviderUiView";
            this.dgvProviderUiView.RowHeadersWidth = 51;
            this.dgvProviderUiView.RowTemplate.Height = 24;
            this.dgvProviderUiView.Size = new System.Drawing.Size(699, 185);
            this.dgvProviderUiView.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnTreatmentUpdate);
            this.groupBox4.Controls.Add(this.numericUpDown3);
            this.groupBox4.Controls.Add(this.numericUpDown2);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(205, 243);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(343, 107);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Provider Treatment Management";
            // 
            // btnTreatmentUpdate
            // 
            this.btnTreatmentUpdate.Location = new System.Drawing.Point(127, 71);
            this.btnTreatmentUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTreatmentUpdate.Name = "btnTreatmentUpdate";
            this.btnTreatmentUpdate.Size = new System.Drawing.Size(95, 30);
            this.btnTreatmentUpdate.TabIndex = 3;
            this.btnTreatmentUpdate.Text = "Update";
            this.btnTreatmentUpdate.UseVisualStyleBackColor = true;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(179, 46);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(140, 22);
            this.numericUpDown3.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(179, 18);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(140, 22);
            this.numericUpDown2.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSearch);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.numSearchId);
            this.groupBox5.Location = new System.Drawing.Point(573, 243);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(343, 110);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search Provider Treatments";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(123, 66);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 34);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Send";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Provider ID";
            // 
            // numSearchId
            // 
            this.numSearchId.Location = new System.Drawing.Point(187, 25);
            this.numSearchId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numSearchId.Name = "numSearchId";
            this.numSearchId.Size = new System.Drawing.Size(140, 22);
            this.numSearchId.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Provider Rating";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 16);
            this.label12.TabIndex = 6;
            this.label12.Text = "Provider Status";
            // 
            // txtProviderRating
            // 
            this.txtProviderRating.Location = new System.Drawing.Point(179, 109);
            this.txtProviderRating.Name = "txtProviderRating";
            this.txtProviderRating.Size = new System.Drawing.Size(140, 22);
            this.txtProviderRating.TabIndex = 7;
            // 
            // cmbProviderStatus
            // 
            this.cmbProviderStatus.FormattingEnabled = true;
            this.cmbProviderStatus.Items.AddRange(new object[] {
            "ACTIVE",
            "INACTIVE"});
            this.cmbProviderStatus.Location = new System.Drawing.Point(179, 134);
            this.cmbProviderStatus.Name = "cmbProviderStatus";
            this.cmbProviderStatus.Size = new System.Drawing.Size(140, 24);
            this.cmbProviderStatus.TabIndex = 8;
            // 
            // frmProviderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(994, 653);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProviderUI";
            this.Text = "ProviderUI";
            this.Load += new System.EventHandler(this.frmProviderUI_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChargeRate)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNegotiateRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdSelector)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviderUiView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSearchId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMedical;
        private System.Windows.Forms.Button btnPolicy;
        private System.Windows.Forms.Button btnCallCentreNav;
        private System.Windows.Forms.Button btnClientNav;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProviderName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProviderEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numChargeRate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSendNegotiation;
        private System.Windows.Forms.NumericUpDown numNegotiateRate;
        private System.Windows.Forms.NumericUpDown numIdSelector;
        private System.Windows.Forms.Button btnProviderSearch;
        private System.Windows.Forms.TextBox txtCurrentRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvProviderUiView;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnTreatmentUpdate;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button btnAllProvderDetails;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numSearchId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtProviderRating;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbProviderStatus;
    }
}