using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SecureCoreInheritedControl;

namespace ManagementForms
{
    public partial class frmUsers : ManagementForms.frmBasefk
    {
        private string tableName = "Users";
        public frmUsers()
        {
            InitializeComponent();
            base._tableName = tableName;
        }
        protected override void ConfigurateDataGridView()
        {
            base.ConfigurateDataGridView();
            dgtData.Columns["CodeUser"].HeaderText = "Code User";
            dgtData.Columns["UserName"].HeaderText = "User Name";
            dgtData.Columns["Photo"].HeaderText = "Photo Path";

            dgtData.Columns["Hash"].Visible = false;
            dgtData.Columns["Password"].Visible = false;

        }
        protected override void NewRegister()
        {
            base.NewRegister();

            DataRow lastRow = dts.Tables[0].Rows[dts.Tables[0].Rows.Count - 1];
            lastRow["Password"] = "12345aA";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDebugging_Click(object sender, EventArgs e)
        {
            foreach(Control ctrl in this.Controls)
            {
                if(ctrl is SWTextbox)
                {
                    ((SWTextbox)ctrl).SetDefaultData();
                }
            }
        }

        private void lblSpecie_Click(object sender, EventArgs e)
        {

        }

        private void SWcdSpecie_Load(object sender, EventArgs e)
        {

        }

        private void SWtxtSpecie_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
