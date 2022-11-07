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
    public partial class frmCallTimerUI : Form
    {
        public bool end = false;
        public frmCallTimerUI()
        {
            InitializeComponent();
        }

        private void btnEndCall_Click(object sender, EventArgs e)
        {
            end = true;
            frmCallerUI caller = new frmCallerUI();
            caller.Close();
            Application.Exit();
            
        }

        private void frmCallTimerUI_Load(object sender, EventArgs e)
        {
            int i = 900;
            while (i > 0)
            {
                string Sec = Convert.ToString(i % 60);
                double min = i / 60;
                string minutes = Convert.ToString(Math.Floor(min));
                lblTime.Text = minutes + ":" + Sec;
                if (i == 300)
                {
                    MessageBox.Show("Warning 5 minutes left");
                }
                if (end == true)
                {
                    i = 0;
                }
                
                i = i - 1;
            }
        }
    }
}