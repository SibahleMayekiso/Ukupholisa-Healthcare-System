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
    public partial class frmMedicalUI : Form
    {
        
        public frmMedicalUI()
        {
            InitializeComponent();
        }

        private void frmMedicalUI_Load(object sender, EventArgs e)
        {
            MedCondition medical = new MedCondition();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = medical.GetConditionsWithTreatment();
            dgvViewMedTreatments.DataSource = bindingSource;
        }

        private void btnViewMedicalConditons_Click(object sender, EventArgs e)
        {
            MedCondition medical = new MedCondition();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = medical.GetMedicalConditons();
            dgvViewMedTreatments.DataSource = bindingSource;
        }

        private void btnViewTreatments_Click(object sender, EventArgs e)
        {
            Treatment treatment = new Treatment();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = treatment.GetMedicalTreatments();
            dgvViewMedTreatments.DataSource = bindingSource;
        }

        private void btnCallCentre_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            this.Close();
            frmClient client = new frmClient();
            client.Show();
        }

        private void btnProvider_Click(object sender, EventArgs e)
        {
            this.Close();
            frmProviderUI provider = new frmProviderUI();
            provider.Show();
        }

        private void btnPolicy_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPolicyUI policy = new frmPolicyUI();
            policy.Show();
        }

        private void btnViewConditionsNTreatments_Click(object sender, EventArgs e)
        {
            MedCondition medical = new MedCondition();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = medical.GetConditionsWithTreatment();
            dgvViewMedTreatments.DataSource = bindingSource;
        }

        private void btnAddCondition_Click(object sender, EventArgs e)
        {
            MedCondition condition = new MedCondition();
            string message = "";

            condition.ConditionName = txtConditionName.Text;
            condition.Severity = cmbSeverity.SelectedIndex.ToString();
            try
            {
                message = condition.InsertConditionDetails(condition);
                MessageBox.Show(message);

            }
            catch (Exception err)
            {

                MessageBox.Show(String.Format("{0}: \n{1}", message, err));
            }

            dgvViewMedTreatments.Refresh();
        }

        private void btnAddTreatment_Click(object sender, EventArgs e)
        {
            Treatment treatment = new Treatment();
            string message = "";

            treatment.TreatmentName = txtTreamentName.Text;
            treatment.Duration = Convert.ToInt32(numDuration.Value);
            try
            {
                message = treatment.InsertTreatmentDetails(treatment);
                MessageBox.Show(message);

            }
            catch (Exception err)
            {

                MessageBox.Show(String.Format("{0}: \n{1}", message, err));
            }
            
            dgvViewMedTreatments.Refresh();
        }
    }
}
