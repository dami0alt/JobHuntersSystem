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
        bool PanelMinimized = false;

        public frmMain()
        {
            InitializeComponent();
            dbManager = new BaseDeDades();
        }
        DataTable dtUserOptions;

        private void LoadUserOptions()
        {
            string query = "SELECT * FROM UserOptions";
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
                    });
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadUserOptions();

            lblUserName.Text = _UserName;
            lblRoleUser.Text = _RoleUser;

            pctLogo.ImageLocation = logoPath;
            if (File.Exists(_ProfileImagePath))
            {
                pctProfileImage.ImageLocation = _ProfileImagePath;

            }
            else
            {
                pctProfileImage.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "Multimedia/Users/Anonym.png";
            }
            if(CurrentUser.MainUser.AccesLevel == 100)
            {
                pctSecretItem.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "Multimedia/png/crown.png";
            }
            //speech = new SpeechManager(this);
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
    }
}
