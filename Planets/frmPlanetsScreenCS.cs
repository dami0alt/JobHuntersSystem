using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Planets
{
    public partial class frmPlanetsScreenCS : ManagementForms.frmScreenCS
    {
        public frmPlanetsScreenCS(string tableName, string formName, string controlId) : base(tableName, formName, controlId)
        {
            InitializeComponent();
        }
    }
}
