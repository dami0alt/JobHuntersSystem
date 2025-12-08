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
using System.Text.RegularExpressions;


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
            string query = "select *" +
                " from Users";

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
            if (!string.IsNullOrEmpty(txtNewPassword.Text))
            {
                if (!AreEqual())
                {
                    lblInformation.Visible = true;
                    string message = "Passwords need to be equals";
                    lblInformation.Text = message;
                    lblInformation.ForeColor = Color.Salmon;
                }
                else
                {
                    string pass = txtNewPassword.Text;
                    HashPassword(pass);
                    UpdatePass();
                    this.Dispose();
                }
            }
            else
            {
                txtConfirmPassword.Clear();

                lblInformation.Visible = true;
                string message = "Passwords couldn't be null";
                lblInformation.Text = message;
                lblInformation.ForeColor = Color.Salmon;
            }
           
        }

        private void btnConfirmPassword_Click(object sender, EventArgs e)
        {
            ConfirmPassword();
        }

        private void timerInfo_Tick(object sender, EventArgs e)
        {
            lblInformation.Visible = false;
            timerInfo.Stop();
        }
        // Al menos una mayúscula
        Regex hasUpperCase = new Regex(@"[A-Z]");

        // Al menos una minúscula
        Regex hasLowerCase = new Regex(@"[a-z]");

        // Al menos un dígito
        Regex hasDigit = new Regex(@"\d");

        // Al menos un carácter especial
        Regex hasSpecialChar = new Regex(@"[!@#$%^&*(),.?""{}|<>]");


        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNewPassword.Text))
            {
                string pwd = txtNewPassword.Text;

                bool hasUpper = Regex.IsMatch(pwd, @"[A-Z]");
                bool hasLower = Regex.IsMatch(pwd, @"[a-z]");
                bool hasDigit = Regex.IsMatch(pwd, @"\d");
                bool hasSpecial = Regex.IsMatch(pwd, @"[!@#$%^&*(),.?""{}|<>]");
                bool minLength8 = pwd.Length >= 8;

                if (hasUpper && hasLower && hasDigit && hasSpecial && minLength8 && minLength8)
                {
                    lblSecurity.Text = "Strong";
                    lblSecurity.ForeColor = Color.LightGreen;

                    pnlSecurityLevel.Size = new Size(128,14);
                    pnlSecurityLevel.BackColor = Color.LightGreen;
                }
                else if ((hasUpper || hasLower) && hasDigit && pwd.Length >= 6)
                {
                    lblSecurity.Text = "Medium";
                    lblSecurity.ForeColor = Color.Orange;

                    pnlSecurityLevel.Size = new Size(80, 14);
                    pnlSecurityLevel.BackColor = Color.Orange;
                }
                else
                {
                    lblSecurity.Text = "Weak";
                    lblSecurity.ForeColor = Color.Salmon;

                    pnlSecurityLevel.Size = new Size(35,14);
                    pnlSecurityLevel.BackColor = Color.Salmon;
                }

            }
        }
    }
}
