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
using Ukupholisa_Healthcare_System.Presentation_Layer;
using Ukupholisa_Healthcare_System.Data_Access_Layer;

namespace Ukupholisa_Healthcare_System
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            Client client = new Client();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = client.GetClientDetailTable();
            dgvClientView.DataSource = bindingSource;
        }

        private void btnCallCentre_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProviderClient_Click(object sender, EventArgs e)
        {
            this.Close();
            frmProviderUI provider = new frmProviderUI();
            provider.Show();
        }

        private void btnPolicyClient_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPolicyUI policy = new frmPolicyUI();
            policy.Show();
        }

        private void btnMedicalClient_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMedicalUI medical = new frmMedicalUI();
            medical.Show();
        }

        private void btnViewAllClients_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = client.GetClientDetailTable();
            dgvClientView.DataSource = bindingSource;
        }

        private void btnViewClientDependent_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.ClientID = txtClientIdDependent.Text;
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = client.GetClientDependentsTable(client);
            dgvClientView.DataSource = bindingSource;
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            string Name = txtClientName.Text;
            string Surname = txtClientSurname.Text;
            string email = txtClientCondition.Text;
            string Relationship = txtClientHouseNumber.Text;
            string Street = txtClientSuburb.Text;
            int RegoinID = Convert.ToInt32(txtClientCity.Text);
            string CleintNum = txtClientNumber.Text;
            CallData call = new CallData();
            call.CleintData(Name, Surname, CleintNum, email, RegoinID, Street);
            dgvClientView.Refresh();
        }
    }
}
