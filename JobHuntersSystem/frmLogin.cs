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
        public frmLogin()
        {
            frmSplash frmSplash = new frmSplash();
            frmSplash.ShowDialog();
            InitializeComponent();
        }
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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            string passInitial = "12345aA";            

            DataTable db = consultationDataBase(user);
            if(db.Rows.Count == 0)
            {
                lblMessage.Text = ("Invalid user or nonexistent user credentials");
                lblMessage.ForeColor = Color.Red;
            }
            else
            {
                string dbPassword = db.Rows[0]["Password"].ToString();
                bool passValidateInitial = CheckPasswordInitial(pass, passInitial, dbPassword);

                CheckFinalPassword(passValidateInitial, db, pass, dbPassword, user);
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
                MessageBox.Show("You will now be redirected to create your new password");
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
                    lblMessage.Text = $"Welcome {userName}! Your user validation was successful. \nWe are currently verifying your access level and preparing your profile data. \nYou will be redirected to the main application shortly.";
                    lblMessage.ForeColor = Color.Green;

                    timerMessage.Start();

                    SaveLinkedData(user);
                }
                else
                {
                    txtPass.Clear();
                    lblMessage.Text = ("The password doesn't match with the user.");
                    lblMessage.ForeColor = Color.Red;                   
                }
            }
        }
        private void timerMessage_Tick(object sender, EventArgs e)
        {
            timerMessage.Stop();
            this.DialogResult = DialogResult.OK;
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
    }
}
