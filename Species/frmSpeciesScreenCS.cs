using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Species
{
    public partial class frmSpeciesScreenCS : ManagementForms.frmScreenCS
    {
        public frmSpeciesScreenCS(string tableName, string formName, string controlId) : base(tableName, formName, controlId)
        {
            InitializeComponent();
        }
    }
}
