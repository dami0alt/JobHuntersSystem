using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserCategories
{
    public partial class frmUserCategoriesScreenCS : ManagementForms.frmScreenCS
    {
        public frmUserCategoriesScreenCS(string tableName, string formName, string controlId) : base(tableName, formName, controlId)
        {
            InitializeComponent();
        }
    }
}
