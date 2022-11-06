
namespace Ukupholisa_Healthcare_System.Presentation_Layer
{
    partial class frmCallerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCallerUI));
            this.btnAnswerCall = new System.Windows.Forms.Button();
            this.btnRejectCall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxProfilePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnswerCall
            // 
            this.btnAnswerCall.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAnswerCall.Location = new System.Drawing.Point(52, 278);
            this.btnAnswerCall.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnswerCall.Name = "btnAnswerCall";
            this.btnAnswerCall.Size = new System.Drawing.Size(130, 45);
            this.btnAnswerCall.TabIndex = 0;
            this.btnAnswerCall.Text = "Answer";
            this.btnAnswerCall.UseVisualStyleBackColor = false;
            this.btnAnswerCall.Click += new System.EventHandler(this.btnAnswerCall_Click);
            // 
            // btnRejectCall
            // 
            this.btnRejectCall.BackColor = System.Drawing.Color.Red;
            this.btnRejectCall.Location = new System.Drawing.Point(204, 278);
            this.btnRejectCall.Margin = new System.Windows.Forms.Padding(4);
            this.btnRejectCall.Name = "btnRejectCall";
            this.btnRejectCall.Size = new System.Drawing.Size(130, 45);
            this.btnRejectCall.TabIndex = 1;
            this.btnRejectCall.Text = "Reject";
            this.btnRejectCall.UseVisualStyleBackColor = false;
            this.btnRejectCall.Click += new System.EventHandler(this.btnRejectCall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client Calling...";
            // 
            // pbxProfilePicture
            // 
            this.pbxProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("pbxProfilePicture.Image")));
            this.pbxProfilePicture.Location = new System.Drawing.Point(88, 76);
            this.pbxProfilePicture.Name = "pbxProfilePicture";
            this.pbxProfilePicture.Size = new System.Drawing.Size(210, 175);
            this.pbxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProfilePicture.TabIndex = 3;
            this.pbxProfilePicture.TabStop = false;
            // 
            // frmCallerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 346);
            this.Controls.Add(this.pbxProfilePicture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRejectCall);
            this.Controls.Add(this.btnAnswerCall);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCallerUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caller";
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnswerCall;
        private System.Windows.Forms.Button btnRejectCall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxProfilePicture;
    }
}