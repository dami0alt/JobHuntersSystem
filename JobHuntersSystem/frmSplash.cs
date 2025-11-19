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
        public frmSplash()
        {
            InitializeComponent();
            TimerSplash.Start();
        }

        private void TimerSplash_Tick(object sender, EventArgs e)
        {
            pgbSplash.Increment(1);
            lblProgress.Text = pgbSplash.Value.ToString() + "%";

            if(pgbSplash.Value == pgbSplash.Maximum)
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
