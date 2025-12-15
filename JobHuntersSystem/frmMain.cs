using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementForms;
using ComponentesDeAcceso;
using IdentityUser;
using System.Runtime.InteropServices;

namespace JobHuntersSystem
{
    public partial class frmMain : Form
    {
        private int _AccessLevelUser = CurrentUser.MainUser.AccesLevel;
        private string _UserName = CurrentUser.MainUser.UserName;
        private string _RoleUser = CurrentUser.MainUser.DescRank;
        private string _ProfileImagePath = AppDomain.CurrentDomain.BaseDirectory + CurrentUser.MainUser.Photo;
        private SpeechManager speech;

        BaseDeDades dbManager;

        string logoPath = AppDomain.CurrentDomain.BaseDirectory + "Multimedia/png/Banner.png";
        string version = "Version 1.0";
        bool PanelMinimized = false;
        #region cursor
        [DllImport("user32.dll")]
        public static extern IntPtr LoadCursorFromFile(string lpFileName);
        string cursorPath = "Multimedia/ani/Working.ani";
        #endregion

        public frmMain()
        {
            InitializeComponent();
            dbManager = new BaseDeDades();

            string timeFrame = DateTime.Now.ToString("HH:mm:ss");
            lblTime.Text = timeFrame;
            timerTime.Start();

            lblVersion.Text = version;
        }
        DataTable dtUserOptions;

        private void LoadUserOptions()
        {
            string query = "SELECT * FROM UserOptions ORDER BY RenderingOrder ASC";
            dtUserOptions = dbManager.PortarDataTable(query);

            foreach (DataRow row in dtUserOptions.Rows)
            {
                int AccessLevel = 0;
                AccessLevel = Convert.ToInt32(row["AccesLevel"]);
                if (_AccessLevelUser >= AccessLevel)
                {
                    flpOptions.Controls.Add(new SWUserControls.SWLauchForm
                    {
                        Description = row["Description"].ToString(),
                        ClassName = row["dllName"].ToString(),
                        FormName = row["FormName"].ToString(),
                        InitialImagePath = row["PicturePathMain"].ToString(),
                        HoverImagePath = row["PicturePathHover"].ToString(),
                        HoverBackColor = row["BackColorHover"].ToString(),
                        HoverFontColor = row["FontColorHover"].ToString(),
                    });
                }
            }
        }
        private void LoadAniCursor()
        {
            cursorPath = AppDomain.CurrentDomain.BaseDirectory + cursorPath;
            IntPtr hCursor = LoadCursorFromFile(cursorPath);
            if (hCursor != IntPtr.Zero)
            {
                this.Cursor = new Cursor(hCursor);
            }
            else
            {
                MessageBox.Show("The cursor couldn't be loaded", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetHonor()
        {
            if (_AccessLevelUser <= 10)
            {
                lblHonor.Text = "★";
            }
            else if (_AccessLevelUser <= 20)
            {
                lblHonor.Text = "★ ★";
            }
            else if (_AccessLevelUser <= 40)
            {
                lblHonor.Text = "★ ★ ★";
            }
            else if (_AccessLevelUser <= 60)
            {
                lblHonor.Text = "★ ★ ★ ★";
            }
            else if (_AccessLevelUser <= 80)
            {
                lblHonor.Text = "★ ★ ★ ★ ★";
            }
            else
            {
                lblHonor.Text = "★ ★ ★ ★ ★ ♚";
            }
        }
        private void SetImageProfile()
        {
            if (File.Exists(_ProfileImagePath))
            {
                pctProfileImage.ImageLocation = _ProfileImagePath;

            }
            else
            {
                pctProfileImage.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "Multimedia/Users/Anonym.png";
            }
            if (CurrentUser.MainUser.AccesLevel == 100)
            {
                pctSecretItem.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "Multimedia/png/crown.png";
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadAniCursor();
            LoadUserOptions();

            lblUserName.Text = _UserName;
            lblRoleUser.Text = _RoleUser;

            pctLogo.ImageLocation = logoPath;
            SetImageProfile();
            SetHonor();

           
            speech = new SpeechManager(this);
            string path = AppDomain.CurrentDomain.BaseDirectory;
            if (speech.IsRunning)
            {
                pctVoice.ImageLocation = path+ "Multimedia/png/Voice.png";
            }
            else
            {
                pctVoice.ImageLocation = path+"Multimedia/png/NotVoice.png";
            }
        }

        private void pctExtender_Click(object sender, EventArgs e)
        {
            string iconPath = "";
            if (PanelMinimized)
            {
                pctLogo.Visible = true;
                iconPath = AppDomain.CurrentDomain.BaseDirectory + "Multimedia/png/minimized.png";
                pctExtender.ImageLocation = iconPath;
                pnlOptions.Size = new Size(236, 852);
                PanelMinimized = false;
            }
            else
            {
                pctLogo.Visible = false;
                iconPath = AppDomain.CurrentDomain.BaseDirectory + "Multimedia/png/list.png";
                pctExtender.ImageLocation = iconPath;
                pnlOptions.Size = new Size(72, 852);
                PanelMinimized = true;
            }
        }

        private void pctExtender_MouseEnter(object sender, EventArgs e)
        {
            pctExtender.BackColor = Color.FromArgb(220, 164, 69);
        }

        private void pctExtender_MouseLeave(object sender, EventArgs e)
        {
            pctExtender.BackColor = pnlTool.BackColor;
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            string timeFrame = DateTime.Now.ToString("HH:mm:ss");
            lblTime.Text = timeFrame;
        }

        private void pctSpaceShip_MouseHover(object sender, EventArgs e)
        {
            pctMessage1.Visible = true;
        }

        private void pctSpaceShip_MouseLeave(object sender, EventArgs e)
        {
            if (pctMessage1.Visible)
            {
                pctMessage1.Visible = false;
            }
        }

        private void pctVoice_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            if (speech.IsRunning)
            {
                speech.Stop();
                pctVoice.ImageLocation = path + "Multimedia/png/NotVoice.png";
            }
            else
            {
                speech.Resume();
                pctVoice.ImageLocation = path + "Multimedia/png/Voice.png";
            }
        }
    }
}
