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

namespace Ukupholisa_Healthcare_System.Presentation_Layer
{
    public partial class frmCallCentreUI : Form
    {
        public frmCallCentreUI()
        {
            InitializeComponent();
        }

        private void frmCallCentreUI_Load(object sender, EventArgs e)
        {
            Call call = new Call();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = call.GetAllCallLogs();
            dgvDetailsCallCentre.DataSource = bindingSource;
        }

        private void btnClientNavCallCentre_Click(object sender, EventArgs e)
        {
            frmClient client = new frmClient();
            client.Show();
        }

        private void btnPolicyCallCentre_Click(object sender, EventArgs e)
        {
            frmPolicyUI policy = new frmPolicyUI();
            policy.Show();
        }

        private void btnProviderCallCentre_Click(object sender, EventArgs e)
        {
            frmProviderUI provider = new frmProviderUI();
            provider.Show();
        }

        private void btnMedicalCallCentre_Click(object sender, EventArgs e)
        {
            frmMedicalUI medical = new frmMedicalUI();
            medical.Show();
        }

        private void ClaimHis_Click(object sender, EventArgs e)
        {
            Claims claim = new Claims();
            claim.Clientid = txtClaimHis.Text;
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = claim.GetCliams(claim);
            dgvClaimHistory.DataSource = bindingSource;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnApproveClaim_Click(object sender, EventArgs e)
        {
            Policy policy = new Policy();
            Call call = new Call();
            
            policy.PolicyID = txtClaimPolicyID.Text;
            Dictionary<string, string> dictStatus = call.ClaimApproval(policy, txtClaimTreatmentID.Text);
            if (dictStatus["claimStatus"] == "APPROVED")
            {
                MessageBox.Show("Claim has been approved");
            }
            else
            {
                MessageBox.Show("Claim has been rejected");
            }
            

        }

        private void btnCallCentreSubmit_Click(object sender, EventArgs e)
        {
            Call call = new Call();
            Client client = new Client();
            Policy policy = new Policy();
            Claims claim = new Claims();
            string message = "";

            client.FirstName = txtClientNameCentre.Text;
            client.Lastname = txtClientSurnameCen.Text;
            //policy. = txtPolicyNameCen.Text;
            //string PolicyDetail = txtPolicyDetialsCen.Text;
            //string DetailsOfCon = txtConditionCen.Text;
            client.ClientID = txtClientNumberCen.Text;
            try
            {
                message = call.InsertClaimDetails(claim);
                MessageBox.Show(message);
            }
            catch (Exception err)
            {

                MessageBox.Show(String.Format("{0}: \n{1}", message, err));
            }

            
            dgvDetailsCallCentre.Refresh();
        }

    }
}
