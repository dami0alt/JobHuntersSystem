using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpaceShipCategories
{
    public partial class frmSpaceShipCategoriesScreenCS : ManagementForms.frmScreenCS
    {
        public frmSpaceShipCategoriesScreenCS(string tableName, string formName, string controlId) : base(tableName, formName, controlId)
        {
            InitializeComponent();
        }

    }
}
