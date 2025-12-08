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

        string PasswordLevel = "";

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
                if(PasswordLevel != "Weak")
                {
                    if (!AreEqual())
                    {
                        lblInformation.Visible = true;
                        string message = "Passwords need to be equals.";
                        lblInformation.Text = message;
                        lblInformation.ForeColor = Color.Salmon;
                        timerInfo.Start();
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
                    lblInformation.Visible = true;
                    string message = "The password is very vulnerable.";
                    lblInformation.Text = message;
                    lblInformation.ForeColor = Color.Salmon;
                    timerInfo.Start();
                }
                
            }
            else
            {
                txtConfirmPassword.Clear();

                lblInformation.Visible = true;
                string message = "Passwords couldn't be null.";
                lblInformation.Text = message;
                lblInformation.ForeColor = Color.Salmon;
                timerInfo.Start();
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

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNewPassword.Text))
            {
                string pwd = txtNewPassword.Text;

                // Al menos una mayúscula
                bool hasUpper = Regex.IsMatch(pwd, @"[A-Z]");
                // Al menos una minúscula
                bool hasLower = Regex.IsMatch(pwd, @"[a-z]");
                // Al menos un dígito
                bool hasDigit = Regex.IsMatch(pwd, @"\d");
                // Al menos un carácter especial
                bool hasSpecial = Regex.IsMatch(pwd, @"[!@#$%^&*(),.?""{}|<>]");
                // 8 caracteres minimo
                bool minLength8 = pwd.Length >= 8;

                if (hasUpper && hasLower && hasDigit && hasSpecial && minLength8 && minLength8)
                {
                    PasswordLevel = "Strong";
                    lblSecurity.Text = PasswordLevel;
                    lblSecurity.ForeColor = Color.LightGreen;

                    pnlSecurityLevel.Size = new Size(128,14);
                    pnlSecurityLevel.BackColor = Color.LightGreen;
                }
                else if ((hasUpper || hasLower) && hasDigit && pwd.Length >= 6)
                {
                    PasswordLevel = "Medium";
                    lblSecurity.Text = PasswordLevel;
                    lblSecurity.ForeColor = Color.Orange;

                    pnlSecurityLevel.Size = new Size(80, 14);
                    pnlSecurityLevel.BackColor = Color.Orange;
                }
                else
                {
                    PasswordLevel = "Weak";
                    lblSecurity.Text = PasswordLevel;
                    lblSecurity.ForeColor = Color.Salmon;

                    pnlSecurityLevel.Size = new Size(35,14);
                    pnlSecurityLevel.BackColor = Color.Salmon;
                }

            }
        }
    }
}
