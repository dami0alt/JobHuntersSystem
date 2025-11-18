using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ManagementForms
{
    public partial class frmUsersCategories : ManagementForms.frmBase
    {
        private string _tableName = "UserCategories";
        public frmUsersCategories()
        {
            InitializeComponent();
            base._tableName = _tableName;
        }

        protected override void ConfigurateDataGridView()
        {
            base.ConfigurateDataGridView();
            dgtData.Columns["CodeCategory"].HeaderText = "Category";
            dgtData.Columns["DescCategory"].HeaderText = "Description";
            dgtData.Columns["AccessLevel"].HeaderText = "Access Level";
        }

    }
}
