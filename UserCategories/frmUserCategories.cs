using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserCategories
{
    public partial class frmUserCategories : ManagementForms.frmBase
    {
        private string _tableName = "UserCategories";
        public frmUserCategories()
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
