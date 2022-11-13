using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ukupholisa_Healthcare_System.Business_Logic_Layer;
using Ukupholisa_Healthcare_System.Data_Access_Layer;

namespace Ukupholisa_Healthcare_System.Presentation_Layer
{
    public partial class frmProviderUI : Form
    {
        public frmProviderUI()
        {
            InitializeComponent();
        }

        private void frmProviderUI_Load(object sender, EventArgs e)
        {
            Provider provider = new Provider();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = provider.GetProviderDetailsTable();
            dgvProviderUiView.DataSource = bindingSource;
        }

        private void btnClientNav_Click(object sender, EventArgs e)
        {
            frmClient client = new frmClient();
            client.Show();
            this.Close();
        }

        private void btnCallCentreNav_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPolicy_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPolicyUI policy = new frmPolicyUI();
            policy.Show();
        }

        private void btnMedical_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMedicalUI medical = new frmMedicalUI();
            medical.Show();
        }

        private void btnSendNegotiation_Click(object sender, EventArgs e)
        {
            if (numNegotiateRate.Value > 30)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to negotiate contract", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Negotiation Sent");
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Negotiation Not Sent");
                }
            }
            else
            {
                string ValidOutput = "";
                Provider negotations = new Provider();
                ValidOutput = negotations.SendNegotiationstValidation(int.Parse(numIdSelector.Text), int.Parse(txtCurrentRate.Text), int.Parse(numNegotiateRate.Text));
                MessageBox.Show(ValidOutput);

            }
        }

        private void btnAllProvderDetails_Click(object sender, EventArgs e)
        {
            Provider provider = new Provider();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = provider.GetProviderDetailsTable();
            dgvProviderUiView.DataSource = bindingSource;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Provider provider = new Provider();
            string message = "";

            provider.Name = txtProviderName.Text;
            provider.Email = txtProviderEmail.Text;
            provider.ChargeRate = Convert.ToInt32(numChargeRate.Value);
            provider.Rating = txtProviderRating.Text;
            provider.Provider_Status = cmbProviderStatus.GetItemText(cmbProviderStatus.SelectedItem);
            try
            {
                message = provider.InsertProviderDetails(provider);
                MessageBox.Show(message);

            }
            catch (Exception err)
            {

                MessageBox.Show(String.Format("{0}: \n{1}", message, err));
            }
                
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
