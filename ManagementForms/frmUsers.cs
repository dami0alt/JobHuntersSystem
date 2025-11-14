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
        protected override void ConfigurateDataGridView()
        {
            base.ConfigurateDataGridView();
            dgtData.Columns["CodeUser"].HeaderText = "Code User";
            dgtData.Columns["UserName"].HeaderText = "User Name";
            dgtData.Columns["Photo"].HeaderText = "Photo Path";

            dgtData.Columns["Hash"].Visible = false;
            dgtData.Columns["Password"].Visible =false;

        }
        protected override void NewRegister()
        {
            base.NewRegister();

            DataRow lastRow = dts.Tables[0].Rows[dts.Tables[0].Rows.Count - 1];
            lastRow["Password"] = "12345aA";

        }
    }
}
