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
            ProviderData provider = new ProviderData();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = provider.ReadAllProviders();
            dgvProviderUiView.DataSource = bindingSource;
        }

        private void btnClientNav_Click(object sender, EventArgs e)
        {
            frmClient client = new frmClient();
            client.Show();
            this.Close();
        }
    }
}
