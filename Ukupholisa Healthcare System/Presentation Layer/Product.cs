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
    public partial class frmPolicyUI : Form
    {
        public frmPolicyUI()
        {
            InitializeComponent();
        }

        private void btnClientPolicy_Click(object sender, EventArgs e)
        {

        }

        private void btnCallCentrePolicy_Click(object sender, EventArgs e)
        {

        }

        private void btnDatabasePolicy_Click(object sender, EventArgs e)
        {

        }

        private void btnMedicalPolicy_Click(object sender, EventArgs e)
        {

        }

        private void frmPolicyUI_Load(object sender, EventArgs e)
        {
            ProductData product = new ProductData();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = product.ReadAllProducts();
            dgvPolicyDetailsView.DataSource = bindingSource;
        }
    }
}
