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
    }
}
