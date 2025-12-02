using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ManagementForms
{
    public partial class frmUserRanks : ManagementForms.frmBase
    {
        private string _tableName = "UserRanks";
        public frmUserRanks()
        {
            InitializeComponent();
            base._tableName = _tableName;
        }
        protected override void ConfigurateDataGridView()
        {
            base.ConfigurateDataGridView();
            dgtData.Columns["CodeRank"].HeaderText = "Code";
            dgtData.Columns["DescRank"].HeaderText = "Description";

            dgtData.Columns["idUserRank"].Visible = false;
        }

        private void frmUserRanks_Load(object sender, EventArgs e)
        {

        }
    }
}
