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

namespace Ukupholisa_Healthcare_System
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        private void CleintCondition2_Click(object sender, EventArgs e)
        {

        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            ClientData client = new ClientData();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = client.ReadAllClients();
            dgvClientView.DataSource = bindingSource;
        }
    }
}
