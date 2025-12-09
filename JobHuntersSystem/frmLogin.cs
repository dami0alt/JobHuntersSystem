using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentesDeAcceso;
using HashUtils;
using IdentityUser;

namespace JobHuntersSystem
{
    public partial class frmLogin : Form
    {
        BaseDeDades dataBase = new BaseDeDades();
        clsHash hash = new clsHash();
        private int errorCount = 0;
        private string path;

        private int loadingStep = 0;
        private int redirectionTime = 5;
        public frmLogin()
        {
            frmSplash frmSplash = new frmSplash();
            frmSplash.ShowDialog();
            InitializeComponent();

            path = AppDomain.CurrentDomain.BaseDirectory + "Multimedia\\png\\closeEye.png";
            pbPass.ImageLocation = path;
        }
        #region consultas
        private DataTable consultationDataBase(string user)
        {
            string query = $"SELECT * FROM Users WHERE Login = '{user}'";
            DataTable db = dataBase.PortarDataTable(query);
            return db;
        }
        private DataTable consultationDataBaseForRank(int idRank)
        {
            string query = $"SELECT * FROM UserRanks WHERE idUserRank = {idRank}";
            DataTable db = dataBase.PortarDataTable(query);
            return db;
        }
        private DataTable consultationDataBaseForCategory(int idCategory)
        {
            string query = $"SELECT * FROM UserCategories WHERE idUserCategory = {idCategory}";
            DataTable db = dataBase.PortarDataTable(query);
            return db;
        }
        #endregion
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            string passInitial = "12345aA";
            try
            {
                DataTable db = consultationDataBase(user);

                if (db.Rows.Count == 0 || db == null)
                {
                    lblMessage.Text = ("Invalid or nonexistent user credentials ☹");
                    lblBody.Text = ("Insert a correct credential or contact the administrator");
                    lblMessage.ForeColor = Color.Salmon;
                    lblBody.ForeColor = Color.Salmon;
                }
                else
                {
                    string dbPassword = db.Rows[0]["Password"].ToString();
                    bool passValidateInitial = CheckPasswordInitial(pass, passInitial, dbPassword);

                    CheckFinalPassword(passValidateInitial, db, pass, dbPassword, user);
                }
            }
            catch(System.Data.Common.DbException ex)
            {
                lblMessage.Text = "ERROR: Could not connect to the database. Please check the connection.\n"+
                                    $"Details: {ex.Message}";
            }
            catch(Exception ex)
            {
                lblMessage.Text = "ERROR: An unexpected error occurred in the system.\n"+
                                    $"Details: {ex.Message}";
            }


        }      
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool CheckPasswordInitial(string pass, string passInitial, string dbPass)
        {
            if (hash.ValidatePass(pass, passInitial) && hash.ValidatePass(pass, dbPass))
            {
                return true;
            }
            else
            {
                return false;   
            }
        }
        private void CheckFinalPassword(bool passValidateInitial, DataTable db, string pass, string dbPassword, string user)
        {
            string validatePass, salt;
            if (passValidateInitial)
            {
                MessageBox.Show("Default Password Detected!!\nYou will be redirected to change your password","Security Alert!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                frmConfirmPassword changePass = new frmConfirmPassword(user);
                changePass.Show();
                txtPass.Clear();
            }
            else
            {
                salt = db.Rows[0]["Hash"].ToString();
                validatePass = hash.CreatePassword(pass, salt);

                bool passHashed = hash.ValidatePass(validatePass, dbPassword);
                if (passHashed)
                {
                    string userName = db.Rows[0]["UserName"].ToString();
                    lblMessage.Text = $"Welcome {userName} ★";
                    lblMessage.ForeColor = Color.LightGreen;
                    lblBody.Text = "We are currently verifying your access level and preparing your profile data. \nYou will be redirected to the main application shortly.";
                    lblBody.ForeColor = Color.LightGreen;
                    lblInfo.Visible = true;
                    pctGif3.Visible = true;
                    timerRedirection.Start();

                    SaveLinkedData(user);
                }
                else
                {                    
                    ThreateningMessage();
                }
            }
        }
        private void ThreateningMessage()
        {
            txtPass.Clear();
            errorCount++;
            int attempts = 4 - errorCount;
            string message = "";
            if(attempts == 0)
            {
                message = "SECURITY ALERT!\n\n" +
                          "You have exceeded the maximum number of access attempts.\n\n" +
                          "⚠️ FIRST ORDER WARNING ⚠️\n\n" +
                          "The corresponding security measures have been taken.\n\n" +
                          "The system will shut down immediately for security reasons.\n\n" +
                          "Consider this your final warning!";
                MessageBox.Show(message, "Critical Alert!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
          
            lblMessage.Text = "Invalid or nonexistent user credentials ☹";
            lblBody.Text = "Insert a correct credential or contact the administrator";
            lblMessage.ForeColor = Color.Salmon;
            lblBody.ForeColor = Color.Salmon;
        }
        private void SaveLinkedData(string user)
        {
            DataTable db = consultationDataBase(user);

            int id = (int)db.Rows[0]["idUser"];
            string code = db.Rows[0]["CodeUser"].ToString();
            string name = db.Rows[0]["UserName"].ToString();
            string log = db.Rows[0]["Login"].ToString();
            string URLPhoto = db.Rows[0]["Photo"].ToString();

            int idRank = Convert.ToInt32(db.Rows[0]["idUserRank"]);
            int idCategory = Convert.ToInt32(db.Rows[0]["idUserCategory"]);

            DataTable dbRank = consultationDataBaseForRank(idRank);
            string rancDesc;
            if (dbRank.Rows.Count > 0) {rancDesc = dbRank.Rows[0]["DescRank"].ToString(); }
            else { rancDesc = ""; }

            
            DataTable dbCategory = consultationDataBaseForCategory(idCategory);
            string categoryDesc;
            int Acces;
            if (dbCategory.Rows.Count > 0)
            {
                categoryDesc = dbCategory.Rows[0]["DescCategory"].ToString();
                Acces = Convert.ToInt32(dbCategory.Rows[0]["AccessLevel"]);
            }
            else
            {
                categoryDesc = "";
                Acces = 10;
            }

            User mainUser = new User
            {
                idUser = id,
                CodeUser = code,
                UserName = name,
                Login = log,
                Photo = URLPhoto,
                AccesLevel = Acces,
                DescRank = rancDesc,
                DescCategory = categoryDesc
            };

            CurrentUser.MainUser = mainUser;
        }

        private void pbPass_MouseDown(object sender, MouseEventArgs e)
        {
            path = AppDomain.CurrentDomain.BaseDirectory + "Multimedia\\png\\openEye.png";
            pbPass.ImageLocation = path;
            txtPass.PasswordChar = '\0';
        }

        private void pbPass_MouseUp(object sender, MouseEventArgs e)
        {
            path = AppDomain.CurrentDomain.BaseDirectory + "Multimedia\\png\\closeEye.png";
            pbPass.ImageLocation = path;
            txtPass.PasswordChar = '*';
        }

        private void timerRedirection_Tick(object sender, EventArgs e)
        {
            loadingStep++;

            if (loadingStep % 3 == 0)
            {
                redirectionTime--;
            }

            int dots = (loadingStep % 3) + 1;

            lblInfo.Text = $"Redirecting in {redirectionTime}" + new string('.', dots);

            if (loadingStep >= 15)
            {
                timerRedirection.Stop();

                timerRedirection.Dispose();

                this.DialogResult = DialogResult.OK;
            }

        }
    }
}
