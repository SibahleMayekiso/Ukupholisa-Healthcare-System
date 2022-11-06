﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ukupholisa_Healthcare_System.Data_Access_Layer;
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
            ClientData client = new ClientData();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = client.ReadAllClients();
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
    }
}
