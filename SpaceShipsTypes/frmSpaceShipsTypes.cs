using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpaceShipsTypes
{
    public partial class frmSpaceShipsTypes : ManagementForms.frmBasefk
    {
        private string tableName = "SpaceShipTypes";
        private List<string> FkTableNams = new List<string>{
        "Filiations","SpaceShipCategories"};
        public frmSpaceShipsTypes()
        {
            InitializeComponent();
            base._tableName = tableName;
            base._FkTableNames = FkTableNams;
        }
        protected override void ConfigurateDataGridView()
        {
            base.ConfigurateDataGridView();

            dgtData.Columns["CodeSpaceShipType"].HeaderText = "Code Type";
            dgtData.Columns["DescSpaceShipType"].HeaderText = "Description Type";

            var column = new DataGridViewComboBoxColumn
            {
                HeaderText = "Filiation",
                Name = "Filiations",
                DataPropertyName = "idFiliation",
                DropDownWidth = 160,
                Width = 90,
                MaxDropDownItems = 3,
                FlatStyle = FlatStyle.Flat,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            column.DataSource = ds.Tables[1];
            column.DisplayMember = "CodeFiliation";
            column.ValueMember = "idFiliation";
            dgtData.Columns.Add(column);

            var column2 = new DataGridViewComboBoxColumn
            {
                HeaderText = "Category",
                Name = "SpaceShipCategories",
                DataPropertyName = "idSpaceShipCategory",
                DropDownWidth = 160,
                Width = 90,
                MaxDropDownItems = 3,
                FlatStyle = FlatStyle.Flat,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            column2.DataSource = ds.Tables[2];
            column2.DisplayMember = "CodeSpaceShipCategory";
            column2.ValueMember = "idSpaceShipCategory";
            dgtData.Columns.Add(column2);

        }
    }
}
