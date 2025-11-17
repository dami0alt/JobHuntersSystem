using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using ManagementForms;
using ComponentesDeAcceso;
namespace JobHuntersSystem
{
    public partial class frmMain : Form
    {
        //A futuro remplazar las propiedaedes del "user"por un data set con la query del usuario
        private int _AccessLevelUser = 210;
        private string _UserName = "Damian2005";
        private string _RoleUser = "Admin";
        private string _ProfileImagePath="Multimedia/png/Clon.png";

        BaseDeDades dbManager;
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
            pctProfileImage.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + _ProfileImagePath; 
        }
    }
}
