using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MenuOption
{
    public partial class frmMenuOptions : ManagementForms.frmBase
    {
        private string _tableName = "UserOptions";

        #region Methods
        string pattern = @"^([1]?[0-9]?[0-9]|2[0-4][0-9]|25[0-5]);" +
            "([1]?[0-9]?[0-9]|2[0-4][0-9]|25[0-5]);" +
            "([1]?[0-9]?[0-9]|2[0-4][0-9]|25[0-5])$";

        private bool ValidRGBCode(string color)
        {
            bool ValidCode = Regex.IsMatch(color, pattern);
            return ValidCode;
        }

        #endregion

        public frmMenuOptions()
        {
            InitializeComponent();
            base._tableName = _tableName;

        }
        protected override void ConfigurateDataGridView()
        {
            base.ConfigurateDataGridView();
            dgtData.Columns["dllName"].HeaderText = "DLL Name";
            dgtData.Columns["FormName"].HeaderText = "Form Name";
            dgtData.Columns["PicturePathMain"].HeaderText = "Main Icon Path";
            dgtData.Columns["PicturePathHover"].HeaderText = "Hover Icon Path";
            dgtData.Columns["BackColorMain"].HeaderText = "Background Color";
            dgtData.Columns["BackColorHover"].HeaderText = "Hover Background Color";
            dgtData.Columns["FontColorMain"].HeaderText = "Font Color";
            dgtData.Columns["FontColorHover"].HeaderText = "Hover Font Color";
            dgtData.Columns["Description"].HeaderText = "Description";
            dgtData.Columns["AccesLevel"].HeaderText = "Access Level";

            dgtData.Columns["idControl"].Visible = false;
        }

        private void SWtxtBackColorMain_Validating(object sender, CancelEventArgs e)
        {
            string color = SWtxtBackColorMain.Text;
            if (!ValidRGBCode(color))
            {
                SWtxtAccesLevel.Text = "";
                MessageBox.Show("Error");
            }
        }

        private void SWtxtPicturePathMain_TextChanged(object sender, EventArgs e)
        {
            isIcon.ImagePath = SWtxtPicturePathMain.Text;
        }
    }
}
