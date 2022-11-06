using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukupholisa_Healthcare_System.Presentation_Layer
{
    public partial class frmCallerUI : Form
    {
        public frmCallerUI()
        {
            InitializeComponent();
        }

        private void btnRejectCall_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAnswerCall_Click(object sender, EventArgs e)
        {
            frmCallCentreUI callCentreUI = new frmCallCentreUI();
            frmCallTimerUI timer = new frmCallTimerUI();
            callCentreUI.Show();
            timer.Show();
            this.Hide();
        }
    }
}
