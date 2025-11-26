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
        public FrmUserInfo(string username, string rank, string category, Image profileImage)
        {
            InitializeComponent();

            lblUsername.Text = username;
            lblRank.Text = rank;
            lblCategory.Text = category;

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
