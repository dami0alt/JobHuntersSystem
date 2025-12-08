using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SecureCoreInheritedControl;

namespace Users
{
    public partial class frmUsers : ManagementForms.frmBasefk
    {
        private string tableName = "Users";
        private List<string> FkTableNams = new List<string>{
        "UserRanks","Species","UserCategories","Planets"
        };
        public frmUsers()
        {
            InitializeComponent();
            base._tableName = tableName;
            base._FkTableNames = FkTableNams;
        }
        protected override void ConfigurateDataGridView()
        {
            base.ConfigurateDataGridView();

            dgtData.Columns["CodeUser"].HeaderText = "Code User";
            dgtData.Columns["UserName"].HeaderText = "User Name";
            dgtData.Columns["Photo"].HeaderText = "Photo Path";

            dgtData.Columns["Hash"].Visible = false;
            dgtData.Columns["Password"].Visible = false;

            var column = new DataGridViewComboBoxColumn
            {
                HeaderText = "User Rank",
                Name = "UserRank",
                DataPropertyName = "idUserRank",
                DropDownWidth = 160,
                Width = 90,
                MaxDropDownItems = 3,
                FlatStyle = FlatStyle.Flat,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            column.DataSource = ds.Tables[1];
            column.DisplayMember = "CodeRank";
            column.ValueMember = "idUserRank";
            dgtData.Columns.Add(column);

            var column2 = new DataGridViewComboBoxColumn
            {
                HeaderText = "Specie",
                Name = "Species",
                DataPropertyName = "idSpecie",
                DropDownWidth = 160,
                Width = 90,
                MaxDropDownItems = 3,
                FlatStyle = FlatStyle.Flat,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            column2.DataSource = ds.Tables[2];
            column2.DisplayMember = "CodeSpecie";
            column2.ValueMember = "idSpecie";
            dgtData.Columns.Add(column2);

            var column3 = new DataGridViewComboBoxColumn
            {
                HeaderText = "User Category",
                Name = "UserCategories",
                DataPropertyName = "idUserCategory",
                DropDownWidth = 160,
                Width = 90,
                MaxDropDownItems = 3,
                FlatStyle = FlatStyle.Flat,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            column3.DataSource = ds.Tables[3];
            column3.DisplayMember = "CodeCategory";
            column3.ValueMember = "idUserCategory";
            dgtData.Columns.Add(column3);

            var column4 = new DataGridViewComboBoxColumn
            {
                HeaderText = "Planet",
                Name = "Planets",
                DataPropertyName = "idPlanet",
                DropDownWidth = 160,
                Width = 90,
                MaxDropDownItems = 3,
                FlatStyle = FlatStyle.Flat,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            column4.DataSource = ds.Tables[4];
            column4.DisplayMember = "CodePlanet";
            column4.ValueMember = "idPlanet";
            dgtData.Columns.Add(column4);

        }
        protected override void NewRegister()
        {
            base.NewRegister();

            int index = ds.Tables[0].Rows.Count - 1;
            ds.Tables[0].Rows[index]["Password"] = "12345aA";
        }
    }
}
