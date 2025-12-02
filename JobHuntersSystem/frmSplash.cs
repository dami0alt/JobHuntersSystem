using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IdentityUser;//añadido

namespace JobHuntersSystem
{
    public partial class frmSplash : Form
    {
        public bool SkipClicked { get; set; } = false; //añadido

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


        //añadido
        private void btnSkip_Click(object sender, EventArgs e)
        {
            User mainUser = new User
            {
                idUser = 3017,
                CodeUser = "DAM",
                UserName = "Damian Altamirano",
                Login = "Damian",
                Photo = "Multimedia/png/Clon.png",
                AccesLevel = 100,
                DescRank = "General",
                DescCategory = "Jedi Master"
            };

            CurrentUser.MainUser = mainUser;

            SkipClicked = true;
            frmMain frmMain = new frmMain();
            frmMain.Show();
            TimerSplash.Stop();

            this.Close();

        }
    }
}
