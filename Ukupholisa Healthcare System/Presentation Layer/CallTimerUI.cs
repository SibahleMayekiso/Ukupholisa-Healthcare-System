using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ukupholisa_Healthcare_System.Presentation_Layer
{
    public partial class frmCallTimerUI : Form
    {
        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            //Method is used to make a Thread-safe call to change the WinForm control property.

            //**NOTE**: Multithreading can expose your code to very serious and complex bugs. Two or more
            //threads manipulating a control can force the control into an inconsistent state
            //and lead to race conditions, deadlocks, and freezes or hangs. If you implement
            //multithreading in your app, be sure to call cross-thread controls in a thread-safe way.
            if (lblTime.InvokeRequired)
            {
                SetTextCallback del = new SetTextCallback(SetText);
                lblTime.Invoke(del, new object[] {text});
            }
            else
            {
                lblTime.Text = text;
            }
        }
        public void timer()
        {
            int i = 900;
            while (i >= 0)
            {
                string Sec = Convert.ToString(i % 60);
                double min = i / 60;
                string minutes = Convert.ToString(Math.Floor(min));
                //try
                //{
                //    //if (lblTime.InvokeRequired)
                //    //{
                //    //    lblTime.Invoke(new Action(timer));                                             
                //    //    return;
                //    //}
                //    SetText
                //    lblTime.Text = minutes + ":" + Sec;
                //}
                //catch (Exception e)
                //{
                //    MessageBox.Show(e.ToString());
                //}

                SetText(minutes + ":" + Sec);
                
                if (i == 300)
                {
                    MessageBox.Show("Warning 5 minutes left");
                }
                if (end == true)
                {
                    i = 0;
                }
                Thread.Sleep(1000);
                i = i - 1;
            }   
            if (i < 0)
            {
                MessageBox.Show("Time has Elapsed. Call will now terminate and the application will close.");
                Application.Exit();
            }
        }
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
            Thread Clock = new Thread(timer);
            Clock.Start();
        }
    }
}
