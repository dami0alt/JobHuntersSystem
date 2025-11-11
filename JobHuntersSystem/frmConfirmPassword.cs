using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HashUtils;
using ComponentesDeAcceso;

namespace JobHuntersSystem
{
    public partial class frmConfirmPassword : Form
    {
        public frmConfirmPassword(string Login)
        {
            InitializeComponent();
            userName = Login;
        }

        private string userName;
        private clsHash hash = new clsHash();
        private BaseDeDades bd = new BaseDeDades();
        private string salt;
        private string passHash;

        private bool AreEqual()
        {
            if (txtConfirmPassword.Text.Equals(txtNewPassword.Text))
            {
                return true;
            }

            return false;
        }

        private void HashPassword(string password)
        {
            salt = hash.CreateSalt();
            passHash = hash.CreatePassword(password, salt);
        }

        private void UpdatePass()
        {
            string query = "select Password, hash, Login" +
                "from Users" +
                $"where Login = '{userName}'";
            DataSet dataSet = bd.PortarPerConsulta(query);
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                if (row["Login"].ToString() == userName)
                {
                    row["hash"] = salt;
                    row["Password"] = passHash;
                }
            }
            bd.Actualitzar(query, dataSet);
        }

        private void ConfirmPassword()
        {
            if (!AreEqual())
            {
                string message = "Passwords need to be equals";
                MessageBox.Show(message);
            }
            else
            {
                string pass = txtNewPassword.Text;
                HashPassword(pass);
                UpdatePass();
                this.Dispose();
            }
        }

        private void btnConfirmPassword_Click(object sender, EventArgs e)
        {
            ConfirmPassword();
        }
    }
}
