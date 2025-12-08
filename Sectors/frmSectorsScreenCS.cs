using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sectors
{
    public partial class frmSectorsScreenCS : ManagementForms.frmScreenCS
    {
        public frmSectorsScreenCS(string tableName, string formName, string controlId) : base(tableName, formName, controlId)
        {
            InitializeComponent();
        }
    }
}
