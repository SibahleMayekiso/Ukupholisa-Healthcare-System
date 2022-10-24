
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
            this.btnClientPolicy = new System.Windows.Forms.Button();
            this.btnMedicalPolicy = new System.Windows.Forms.Button();
            this.btnDatabasePolicy = new System.Windows.Forms.Button();
            this.btnCallCentrePolicy = new System.Windows.Forms.Button();
            this.PolicyName = new System.Windows.Forms.Label();
            this.PolicyDetials = new System.Windows.Forms.Label();
            this.PolicyPrice = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.gbxPolicyDetails = new System.Windows.Forms.GroupBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbvPolicyView = new System.Windows.Forms.GroupBox();
            this.dgvPolicyDetailsView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRights = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwReport = new System.Windows.Forms.ListView();
            this.btnReportGen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtProductType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numProductId = new System.Windows.Forms.NumericUpDown();
            this.rdbUnlimited = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdateAvailability = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpUpdateStart = new System.Windows.Forms.DateTimePicker();
            this.dtpUpdateEnd = new System.Windows.Forms.DateTimePicker();
            this.rdbUpdateUnlimited = new System.Windows.Forms.RadioButton();
            this.btnViewAllProducts = new System.Windows.Forms.Button();
            this.gbxPolicyDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbvPolicyView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolicyDetailsView)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProductId)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClientPolicy
            // 
            this.btnClientPolicy.Location = new System.Drawing.Point(0, 114);
            this.btnClientPolicy.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnMedicalPolicy.Margin = new System.Windows.Forms.Padding(4);
            this.btnMedicalPolicy.Name = "btnMedicalPolicy";
            this.btnMedicalPolicy.Size = new System.Drawing.Size(200, 80);
            this.btnMedicalPolicy.TabIndex = 26;
            this.btnMedicalPolicy.Text = "Medical";
            this.btnMedicalPolicy.UseVisualStyleBackColor = true;
            this.btnMedicalPolicy.Click += new System.EventHandler(this.btnMedicalPolicy_Click);
            // 
            // btnDatabasePolicy
            // 
            this.btnDatabasePolicy.Location = new System.Drawing.Point(0, 290);
            this.btnDatabasePolicy.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatabasePolicy.Name = "btnDatabasePolicy";
            this.btnDatabasePolicy.Size = new System.Drawing.Size(200, 80);
            this.btnDatabasePolicy.TabIndex = 25;
            this.btnDatabasePolicy.Text = "Database";
            this.btnDatabasePolicy.UseVisualStyleBackColor = true;
            this.btnDatabasePolicy.Click += new System.EventHandler(this.btnDatabasePolicy_Click);
            // 
            // btnCallCentrePolicy
            // 
            this.btnCallCentrePolicy.Location = new System.Drawing.Point(0, 202);
            this.btnCallCentrePolicy.Margin = new System.Windows.Forms.Padding(4);
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
            this.PolicyDetials.Location = new System.Drawing.Point(7, 92);
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
            this.txtProductName.Location = new System.Drawing.Point(126, 24);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(190, 22);
            this.txtProductName.TabIndex = 32;
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
            this.gbxPolicyDetails.Location = new System.Drawing.Point(208, 12);
            this.gbxPolicyDetails.Name = "gbxPolicyDetails";
            this.gbxPolicyDetails.Size = new System.Drawing.Size(323, 279);
            this.gbxPolicyDetails.TabIndex = 36;
            this.gbxPolicyDetails.TabStop = false;
            this.gbxPolicyDetails.Text = "Product details";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(95, 216);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(125, 35);
            this.btnAddProduct.TabIndex = 36;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnClientPolicy);
            this.panel1.Controls.Add(this.btnCallCentrePolicy);
            this.panel1.Controls.Add(this.btnDatabasePolicy);
            this.panel1.Controls.Add(this.btnMedicalPolicy);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 573);
            this.panel1.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbvPolicyView
            // 
            this.gbvPolicyView.Controls.Add(this.btnViewAllProducts);
            this.gbvPolicyView.Controls.Add(this.dgvPolicyDetailsView);
            this.gbvPolicyView.Location = new System.Drawing.Point(208, 297);
            this.gbvPolicyView.Name = "gbvPolicyView";
            this.gbvPolicyView.Size = new System.Drawing.Size(779, 264);
            this.gbvPolicyView.TabIndex = 36;
            this.gbvPolicyView.TabStop = false;
            this.gbvPolicyView.Text = "View";
            // 
            // dgvPolicyDetailsView
            // 
            this.dgvPolicyDetailsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolicyDetailsView.Location = new System.Drawing.Point(6, 51);
            this.dgvPolicyDetailsView.Name = "dgvPolicyDetailsView";
            this.dgvPolicyDetailsView.RowHeadersWidth = 51;
            this.dgvPolicyDetailsView.RowTemplate.Height = 24;
            this.dgvPolicyDetailsView.Size = new System.Drawing.Size(767, 207);
            this.dgvPolicyDetailsView.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.lblRights);
            this.panel2.Location = new System.Drawing.Point(1, 567);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 40);
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
            this.groupBox1.Controls.Add(this.btnReportGen);
            this.groupBox1.Controls.Add(this.lvwReport);
            this.groupBox1.Location = new System.Drawing.Point(537, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 135);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Summary";
            // 
            // lvwReport
            // 
            this.lvwReport.HideSelection = false;
            this.lvwReport.Location = new System.Drawing.Point(116, 14);
            this.lvwReport.Name = "lvwReport";
            this.lvwReport.Size = new System.Drawing.Size(328, 109);
            this.lvwReport.TabIndex = 0;
            this.lvwReport.UseCompatibleStateImageBehavior = false;
            // 
            // btnReportGen
            // 
            this.btnReportGen.Location = new System.Drawing.Point(6, 45);
            this.btnReportGen.Name = "btnReportGen";
            this.btnReportGen.Size = new System.Drawing.Size(104, 45);
            this.btnReportGen.TabIndex = 1;
            this.btnReportGen.Text = "Generate Report";
            this.btnReportGen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "End Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(126, 87);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(190, 22);
            this.dtpStartDate.TabIndex = 38;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(126, 143);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(190, 22);
            this.dtpEndDate.TabIndex = 38;
            // 
            // txtProductType
            // 
            this.txtProductType.Location = new System.Drawing.Point(126, 56);
            this.txtProductType.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductType.Name = "txtProductType";
            this.txtProductType.Size = new System.Drawing.Size(190, 22);
            this.txtProductType.TabIndex = 34;
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
            // numProductId
            // 
            this.numProductId.Location = new System.Drawing.Point(11, 58);
            this.numProductId.Name = "numProductId";
            this.numProductId.Size = new System.Drawing.Size(120, 22);
            this.numProductId.TabIndex = 39;
            // 
            // rdbUnlimited
            // 
            this.rdbUnlimited.AutoSize = true;
            this.rdbUnlimited.Location = new System.Drawing.Point(126, 117);
            this.rdbUnlimited.Name = "rdbUnlimited";
            this.rdbUnlimited.Size = new System.Drawing.Size(115, 20);
            this.rdbUnlimited.TabIndex = 41;
            this.rdbUnlimited.TabStop = true;
            this.rdbUnlimited.Text = "Unlimited Offer";
            this.rdbUnlimited.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbUpdateUnlimited);
            this.groupBox2.Controls.Add(this.btnUpdateAvailability);
            this.groupBox2.Controls.Add(this.dtpUpdateEnd);
            this.groupBox2.Controls.Add(this.numProductId);
            this.groupBox2.Controls.Add(this.PolicyPrice);
            this.groupBox2.Controls.Add(this.dtpUpdateStart);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(538, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 131);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Product Availability";
            // 
            // btnUpdateAvailability
            // 
            this.btnUpdateAvailability.Location = new System.Drawing.Point(6, 90);
            this.btnUpdateAvailability.Name = "btnUpdateAvailability";
            this.btnUpdateAvailability.Size = new System.Drawing.Size(125, 35);
            this.btnUpdateAvailability.TabIndex = 0;
            this.btnUpdateAvailability.Text = "Update";
            this.btnUpdateAvailability.UseVisualStyleBackColor = true;
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
            // dtpUpdateStart
            // 
            this.dtpUpdateStart.Location = new System.Drawing.Point(240, 29);
            this.dtpUpdateStart.Name = "dtpUpdateStart";
            this.dtpUpdateStart.Size = new System.Drawing.Size(190, 22);
            this.dtpUpdateStart.TabIndex = 38;
            // 
            // dtpUpdateEnd
            // 
            this.dtpUpdateEnd.Location = new System.Drawing.Point(240, 85);
            this.dtpUpdateEnd.Name = "dtpUpdateEnd";
            this.dtpUpdateEnd.Size = new System.Drawing.Size(190, 22);
            this.dtpUpdateEnd.TabIndex = 38;
            // 
            // rdbUpdateUnlimited
            // 
            this.rdbUpdateUnlimited.AutoSize = true;
            this.rdbUpdateUnlimited.Location = new System.Drawing.Point(240, 59);
            this.rdbUpdateUnlimited.Name = "rdbUpdateUnlimited";
            this.rdbUpdateUnlimited.Size = new System.Drawing.Size(115, 20);
            this.rdbUpdateUnlimited.TabIndex = 41;
            this.rdbUpdateUnlimited.TabStop = true;
            this.rdbUpdateUnlimited.Text = "Unlimited Offer";
            this.rdbUpdateUnlimited.UseVisualStyleBackColor = true;
            // 
            // btnViewAllProducts
            // 
            this.btnViewAllProducts.Location = new System.Drawing.Point(6, 22);
            this.btnViewAllProducts.Name = "btnViewAllProducts";
            this.btnViewAllProducts.Size = new System.Drawing.Size(171, 23);
            this.btnViewAllProducts.TabIndex = 1;
            this.btnViewAllProducts.Text = "View All Products";
            this.btnViewAllProducts.UseVisualStyleBackColor = true;
            // 
            // frmPolicyUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(990, 607);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbvPolicyView);
            this.Controls.Add(this.gbxPolicyDetails);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPolicyUI";
            this.Text = "Policy";
            this.gbxPolicyDetails.ResumeLayout(false);
            this.gbxPolicyDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbvPolicyView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolicyDetailsView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numProductId)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientPolicy;
        private System.Windows.Forms.Button btnMedicalPolicy;
        private System.Windows.Forms.Button btnDatabasePolicy;
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
        private System.Windows.Forms.ListView lvwReport;
        private System.Windows.Forms.RadioButton rdbUnlimited;
        private System.Windows.Forms.NumericUpDown numProductId;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdateAvailability;
        private System.Windows.Forms.RadioButton rdbUpdateUnlimited;
        private System.Windows.Forms.DateTimePicker dtpUpdateEnd;
        private System.Windows.Forms.DateTimePicker dtpUpdateStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnViewAllProducts;
    }
}