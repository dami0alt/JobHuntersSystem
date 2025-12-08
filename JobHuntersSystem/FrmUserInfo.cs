using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IdentityUser;

namespace JobHuntersSystem
{
    public partial class FrmUserInfo : Form
    {
        private int _accesLevel;
        private string _username;
        private string _rank;
        private string _category;
        private Image _profileImage;
        public FrmUserInfo(string username, string rank, string category, Image profileImage)
        {
            InitializeComponent();
            _username = username;
            _rank = rank;
            _category = category;
            _profileImage = profileImage;
            _accesLevel = CurrentUser.MainUser.AccesLevel;
        }
        private void SetHonor()
        {
            if (_accesLevel <= 10)
            {
                lblHonor.Text = "★";
            }
            else if (_accesLevel <= 20)
            {
                lblHonor.Text = "★ ★";
            }
            else if (_accesLevel <= 40)
            {
                lblHonor.Text = "★ ★ ★";
            }
            else if (_accesLevel <= 60)
            {
                lblHonor.Text = "★ ★ ★ ★";
            }
            else if (_accesLevel <= 80)
            {
                lblHonor.Text = "★ ★ ★ ★ ★";
            }
            else
            {
                lblHonor.Text = "★ ★ ★ ★ ★ ♚";
            }
        }
        private void FrmUserInfo_Load(object sender, EventArgs e)
        {

            lblUser.Text = _username;
            lblRank.Text = _rank;
            lblCategory.Text = _category;

            if (_profileImage != null)
            {
                ProfilePic.Image = _profileImage;
            }

            if (_accesLevel == 100)
            {
                pctSecretItem.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "Multimedia/png/crown.png";
            }
            SetHonor();
        }
    }
}
