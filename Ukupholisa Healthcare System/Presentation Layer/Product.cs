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
    public partial class frmPolicyUI : Form
    {
        public frmPolicyUI()
        {
            InitializeComponent();
            
        }

        private void btnClientPolicy_Click(object sender, EventArgs e)
        {
            this.Close();
            frmClient client = new frmClient();
            client.Show();
        }

        private void btnCallCentrePolicy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMedicalPolicy_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMedicalUI medical = new frmMedicalUI();
            medical.Show();
        }

        private void frmPolicyUI_Load(object sender, EventArgs e)
        {
            ProductData product = new ProductData();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = product.ReadAllProducts();
            dgvPolicyDetailsView.DataSource = bindingSource;
        }

        private void btnProviderPolicy_Click(object sender, EventArgs e)
        {
            this.Close();
            frmProviderUI provider = new frmProviderUI();
            provider.Show();
        }

        private void rdbAlltimeDate_Click(object sender, EventArgs e)
        {
            
        }

        private void chkAlltimeDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAlltimeDate.Checked)
            {
                dtpReportStart.Enabled = false;
                dtpReportEnd.Enabled = false;
            }
            else
            {
                dtpReportStart.Enabled = true;
                dtpReportEnd.Enabled = true;
            }
        }

        private void btnReportGen_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            BindingSource bindingSource = new BindingSource();
            
            if (chkAlltimeDate.Checked)
            {
                bindingSource.DataSource = product.GetProductReport();
                dgvReportView.DataSource = bindingSource;
            }
            else
            {
                bindingSource.DataSource = product.GetProductReportByDate(dtpStartDate.Value, dtpEndDate.Value);
                dgvReportView.DataSource = bindingSource;
            }
            
        }
    }
}
