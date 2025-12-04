using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Planets
{
    public partial class frmPlanets : ManagementForms.frmBasefk
    {
        private string tableName = "Planets";
        private List<string> FkTableNams = new List<string>{
        "Sectors","Species","Filiations"
        };

        public frmPlanets()
        {
            InitializeComponent();
            base._tableName = tableName;
            base._FkTableNames = FkTableNams;
        }

        protected override void ConfigurateDataGridView()
        {
            base.ConfigurateDataGridView();
            dgtData.Columns["CodePlanet"].HeaderText = "Code Planet";
            dgtData.Columns["DescPlanet"].HeaderText = "Description Planet";
            dgtData.Columns["long"].HeaderText = "Long";
            dgtData.Columns["lat"].HeaderText = "Latitude";
            dgtData.Columns["parsecs"].HeaderText = "Parsecs";
            dgtData.Columns["PlanetPicture"].HeaderText = "Planet Pictures";
            dgtData.Columns["IPPlanet"].HeaderText = "Planet Ip";
            dgtData.Columns["PortPlanet"].HeaderText = "Planet Port";
            dgtData.Columns["PortPlanet1"].HeaderText = "Planet Port 1";

            dgtData.Columns["idPlanet"].Visible = false;
            dgtData.Columns["idSector"].Visible = false;
            dgtData.Columns["idNatives"].Visible = false;
            dgtData.Columns["idFiliation"].Visible = false;

            AddColumn("Sectors", "Sectors", "idSector", "idSector", "CodeSector", 1);
            AddColumn("Specie", "Species", "idSpecie", "idNatives", "CodeSpecie", 2);
            AddColumn("Filiations", "Filiations", "idFiliation", "idFiliation", "CodeFiliation", 3);
        }

        private void AddColumn(string Header, string tableName, string id, string fid, string typeMember, int table) 
        {
            var column = new DataGridViewComboBoxColumn
            {
                HeaderText = Header,
                Name = tableName,
                DataPropertyName = fid,
                DropDownWidth = 160,
                Width = 90,
                MaxDropDownItems = 3,
                FlatStyle = FlatStyle.Flat,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            column.DataSource = ds.Tables[table];
            column.DisplayMember = typeMember;
            column.ValueMember = id;
            dgtData.Columns.Add(column);
        }

        private void frmPlanets_Load(object sender, EventArgs e)
        {

        }
    }
}
