using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ukupholisa_Healthcare_System.Data_Access_Layer;
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
            CallData call = new CallData();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = call.ReadCallLogs();
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
            claim.Claimid = int.Parse(txtClaimHis.Text);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = claim.GetCliams(claim);
            dgvDetailsCallCentre.DataSource = bindingSource;
        }
    }
}
