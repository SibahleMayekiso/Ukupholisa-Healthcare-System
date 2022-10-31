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
    }
}
