using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHuntersSystem
{
    public partial class FrmUserInfo : Form
    {
        public FrmUserInfo(string username, string category, string rank, Image profileImage)
        {
            InitializeComponent();

            lblUsername.Text = username;
            lblCategory.Text = category;
            lblRank.Text = rank;

            if (profileImage != null)
            {
                ProfilePic.Image = profileImage;
            }
        }

        private void FrmUserInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
