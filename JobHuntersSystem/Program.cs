using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHuntersSystem
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmSplash splash = new frmSplash(); //añadido
            Application.Run(splash); //añadido

            if (splash.SkipClicked) //añadido
            {
                Application.Run(new frmMain());
            }
            else
            {
                using (frmLogin frmLogin = new frmLogin())
                {
                    DialogResult result = frmLogin.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Application.Run(new frmMain());
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }

        }
    }
}
