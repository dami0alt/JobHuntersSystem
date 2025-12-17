using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHuntersSystem
{
    public partial class frmSplash : Form
    {
        int percentage = 1;
        int steps = 0;
        public frmSplash()
        {
            InitializeComponent();
            TimerSplash.Start();
        }

        private void TimerSplash_Tick(object sender, EventArgs e)
        {

            pgbSplash.Increment(1);

            if(pgbSplash.Value % 25 == 0)
            {
                steps++;
                if (steps % 4 != 0)
                {
                    int dots = (pgbSplash.Value % 25) + 1;

                    lblDots.Text += new string('.', dots);
                }
                else{
                    lblDots.Text = string.Empty;
                }
              
            }
           
            switch (percentage)
            {
                case 1:
                    lblInformation.Text = "Initializing system";
                    break;
                case 20:
                    lblInformation.Text = "Establishing secure connection";
                    break;
                case 30:
                    lblInformation.Text = "Preparing graphical environment";
                    break;
                case 40:
                    lblInformation.Text = "Optimizing available resources";
                    break;
                case 55:
                    lblInformation.Text = "Synchronizing data modules";
                    break;
                case 65:
                    lblInformation.Text = "Finalizing startup processes";
                    break;
                case 85:
                    lblInformation.Text = "Ready to launch application";
                    break;
            }

            if (pgbSplash.Value % 5 == 0)
            {
                percentage++;
                lblProgress.Text = percentage + "%";
            }
           


            if (pgbSplash.Value == pgbSplash.Maximum)
            {
                TimerSplash.Stop();
                this.Close();
            }
        }
        private void frmSplash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                e.Handled = true;
            }
        } //para no cerrar con alt+f4       
    }
}
