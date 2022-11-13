using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ukupholisa_Healthcare_System.Business_Logic_Layer;
using Ukupholisa_Healthcare_System.Presentation_Layer;

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
            Client client = new Client();
            string message = "";

            client.FirstName = txtClientName.Text;
            client.Lastname = txtClientSurname.Text;
            //client. = txtClientCondition.Text;
            //client. = txtClientHouseNumber.Text;
            //client. = txtClientSuburb.Text;
            //client. = Convert.ToInt32(txtClientCity.Text);
            client.CellphoneNum = txtClientNumber.Text;
            try
            {
                message = client.InsertClientDetails(client);
                MessageBox.Show(message);

            }
            catch (Exception err)
            {

                MessageBox.Show(String.Format("{0}: \n{1}", message, err));
            }
          
            dgvClientView.Refresh();
        }
    }
}
