using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShipCategories
{
    public partial class FrmSpaceShipCategories : ManagementForms.frmBase
    {
        private string _tableName = "SpaceShipCategories";

        public FrmSpaceShipCategories()
        {
            InitializeComponent();
            base._tableName = _tableName;
        }

        protected override void ConfigurateDataGridView()
        {
            base.ConfigurateDataGridView();
            dgtData.Columns["CodeSpaceShipCategory"].HeaderText = "Ship Code";
            dgtData.Columns["DescSpaceShipCategory"].HeaderText = "Ship Description";

            dgtData.Columns["idSpaceShipCategory"].Visible = false;
        }
    }
}

