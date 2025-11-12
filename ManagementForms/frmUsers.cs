using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementForms
{
    public partial class frmUsers : frmBase
    {
        private string _tableName = "Users";
        public frmUsers()
        {
            InitializeComponent();
            base._tableName = _tableName;
        }
    }
}
