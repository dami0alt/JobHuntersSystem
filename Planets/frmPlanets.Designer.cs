
namespace Planets
{
    partial class frmPlanets
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SWtxtCodePlanet = new SecureCoreInheritedControl.SWTextbox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.SWtxtDescPlanet = new SecureCoreInheritedControl.SWTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSector = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SWtxtPlanetPicture = new SecureCoreInheritedControl.SWTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.SWtxtparsecs = new SecureCoreInheritedControl.SWTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SWtxtPortPlanet = new SecureCoreInheritedControl.SWTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.SWtxtIPPlanet = new SecureCoreInheritedControl.SWTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.SWtxtlong = new SecureCoreInheritedControl.SWTextbox();
            this.SWtxtlat = new SecureCoreInheritedControl.SWTextbox();
            this.SWcdSpecies = new SWUserControls.SWCodi();
            this.lblSpecie = new System.Windows.Forms.Label();
            this.lblFilliation = new System.Windows.Forms.Label();
            this.SWcdFiliation = new SWUserControls.SWCodi();
            this.SWcdSector = new SWUserControls.SWCodi();
            this.SWtxtSector = new SecureCoreInheritedControl.SWTextbox();
            this.SWtxtSpecies = new SecureCoreInheritedControl.SWTextbox();
            this.SWtxtFiliation = new SecureCoreInheritedControl.SWTextbox();
            this.SWtxtPortPlanet1 = new SecureCoreInheritedControl.SWTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.isPlanet = new SWUserControls.ImageSelector();
            this.SuspendLayout();
            // 
            // lblTableName
            // 
            this.lblTableName.Location = new System.Drawing.Point(360, 0);
            this.lblTableName.Size = new System.Drawing.Size(481, 42);
            // 
            // SWtxtCodePlanet
            // 
            this.SWtxtCodePlanet.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtCodePlanet.BackColor = System.Drawing.Color.White;
            this.SWtxtCodePlanet.ControlID = null;
            this.SWtxtCodePlanet.DatabaseName = "CodePlanet";
            this.SWtxtCodePlanet.IsForeignKey = false;
            this.SWtxtCodePlanet.Location = new System.Drawing.Point(160, 73);
            this.SWtxtCodePlanet.MaxLength = 12;
            this.SWtxtCodePlanet.Name = "SWtxtCodePlanet";
            this.SWtxtCodePlanet.NullSpace = true;
            this.SWtxtCodePlanet.Size = new System.Drawing.Size(157, 21);
            this.SWtxtCodePlanet.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(55, 76);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(99, 18);
            this.lblUserName.TabIndex = 22;
            this.lblUserName.Text = "\tPlanet Code";
            // 
            // SWtxtDescPlanet
            // 
            this.SWtxtDescPlanet.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtDescPlanet.BackColor = System.Drawing.Color.White;
            this.SWtxtDescPlanet.ControlID = null;
            this.SWtxtDescPlanet.DatabaseName = "DescPlanet";
            this.SWtxtDescPlanet.IsForeignKey = false;
            this.SWtxtDescPlanet.Location = new System.Drawing.Point(160, 119);
            this.SWtxtDescPlanet.MaxLength = 100;
            this.SWtxtDescPlanet.Name = "SWtxtDescPlanet";
            this.SWtxtDescPlanet.NullSpace = true;
            this.SWtxtDescPlanet.Size = new System.Drawing.Size(157, 21);
            this.SWtxtDescPlanet.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "\tPlanet Description";
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSector.Location = new System.Drawing.Point(701, 76);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(55, 18);
            this.lblSector.TabIndex = 26;
            this.lblSector.Text = "Sector";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Longitude";
            // 
            // SWtxtPlanetPicture
            // 
            this.SWtxtPlanetPicture.AllowedData = SecureCoreInheritedControl.DataType.Path;
            this.SWtxtPlanetPicture.BackColor = System.Drawing.Color.White;
            this.SWtxtPlanetPicture.ControlID = "isPlanet";
            this.SWtxtPlanetPicture.DatabaseName = "PlanetPicture";
            this.SWtxtPlanetPicture.IsForeignKey = false;
            this.SWtxtPlanetPicture.Location = new System.Drawing.Point(766, 211);
            this.SWtxtPlanetPicture.MaxLength = 100;
            this.SWtxtPlanetPicture.Name = "SWtxtPlanetPicture";
            this.SWtxtPlanetPicture.NullSpace = true;
            this.SWtxtPlanetPicture.Size = new System.Drawing.Size(251, 21);
            this.SWtxtPlanetPicture.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(652, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "\tPlanet Image";
            // 
            // SWtxtparsecs
            // 
            this.SWtxtparsecs.AllowedData = SecureCoreInheritedControl.DataType.Number;
            this.SWtxtparsecs.BackColor = System.Drawing.Color.White;
            this.SWtxtparsecs.ControlID = null;
            this.SWtxtparsecs.DatabaseName = "parsecs";
            this.SWtxtparsecs.IsForeignKey = false;
            this.SWtxtparsecs.Location = new System.Drawing.Point(474, 73);
            this.SWtxtparsecs.MaxLength = 12;
            this.SWtxtparsecs.Name = "SWtxtparsecs";
            this.SWtxtparsecs.NullSpace = true;
            this.SWtxtparsecs.Size = new System.Drawing.Size(132, 21);
            this.SWtxtparsecs.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(328, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 18);
            this.label6.TabIndex = 32;
            this.label6.Text = "Distance (Parsecs)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(88, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 30;
            this.label7.Text = "Latitude";
            // 
            // SWtxtPortPlanet
            // 
            this.SWtxtPortPlanet.AllowedData = SecureCoreInheritedControl.DataType.Number;
            this.SWtxtPortPlanet.BackColor = System.Drawing.Color.White;
            this.SWtxtPortPlanet.ControlID = null;
            this.SWtxtPortPlanet.DatabaseName = "PortPlanet";
            this.SWtxtPortPlanet.IsForeignKey = false;
            this.SWtxtPortPlanet.Location = new System.Drawing.Point(474, 166);
            this.SWtxtPortPlanet.MaxLength = 4;
            this.SWtxtPortPlanet.Name = "SWtxtPortPlanet";
            this.SWtxtPortPlanet.NullSpace = true;
            this.SWtxtPortPlanet.Size = new System.Drawing.Size(132, 21);
            this.SWtxtPortPlanet.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(384, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 18);
            this.label9.TabIndex = 40;
            this.label9.Text = "\tPlanet Port";
            // 
            // SWtxtIPPlanet
            // 
            this.SWtxtIPPlanet.AllowedData = SecureCoreInheritedControl.DataType.Path;
            this.SWtxtIPPlanet.BackColor = System.Drawing.Color.White;
            this.SWtxtIPPlanet.ControlID = null;
            this.SWtxtIPPlanet.DatabaseName = "IPPlanet";
            this.SWtxtIPPlanet.IsForeignKey = false;
            this.SWtxtIPPlanet.Location = new System.Drawing.Point(474, 119);
            this.SWtxtIPPlanet.MaxLength = 15;
            this.SWtxtIPPlanet.Name = "SWtxtIPPlanet";
            this.SWtxtIPPlanet.NullSpace = true;
            this.SWtxtIPPlanet.Size = new System.Drawing.Size(132, 21);
            this.SWtxtIPPlanet.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(337, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 18);
            this.label10.TabIndex = 38;
            this.label10.Text = "\tPlanet IP Address";
            // 
            // SWtxtlong
            // 
            this.SWtxtlong.AllowedData = SecureCoreInheritedControl.DataType.Number;
            this.SWtxtlong.BackColor = System.Drawing.Color.White;
            this.SWtxtlong.ControlID = null;
            this.SWtxtlong.DatabaseName = "long";
            this.SWtxtlong.IsForeignKey = false;
            this.SWtxtlong.Location = new System.Drawing.Point(160, 166);
            this.SWtxtlong.MaxLength = 12;
            this.SWtxtlong.Name = "SWtxtlong";
            this.SWtxtlong.NullSpace = true;
            this.SWtxtlong.Size = new System.Drawing.Size(157, 21);
            this.SWtxtlong.TabIndex = 3;
            // 
            // SWtxtlat
            // 
            this.SWtxtlat.AllowedData = SecureCoreInheritedControl.DataType.Number;
            this.SWtxtlat.BackColor = System.Drawing.Color.White;
            this.SWtxtlat.ControlID = null;
            this.SWtxtlat.DatabaseName = "lat";
            this.SWtxtlat.IsForeignKey = false;
            this.SWtxtlat.Location = new System.Drawing.Point(160, 212);
            this.SWtxtlat.MaxLength = 12;
            this.SWtxtlat.Name = "SWtxtlat";
            this.SWtxtlat.NullSpace = true;
            this.SWtxtlat.Size = new System.Drawing.Size(157, 21);
            this.SWtxtlat.TabIndex = 4;
            // 
            // SWcdSpecies
            // 
            this.SWcdSpecies.ClasseCS = "Species.dll";
            this.SWcdSpecies.ControlID = "SWtxtSpecies";
            this.SWcdSpecies.FormCS = "Species.frmSpeciesScreenCS";
            this.SWcdSpecies.Location = new System.Drawing.Point(759, 94);
            this.SWcdSpecies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SWcdSpecies.Name = "SWcdSpecies";
            this.SWcdSpecies.NomCodi = "CodeSpecie";
            this.SWcdSpecies.NomDesc = "DescSpecie";
            this.SWcdSpecies.NomId = "idSpecie";
            this.SWcdSpecies.NomTaula = "Species";
            this.SWcdSpecies.NullSpace = false;
            this.SWcdSpecies.Size = new System.Drawing.Size(376, 49);
            this.SWcdSpecies.TabIndex = 10;
            // 
            // lblSpecie
            // 
            this.lblSpecie.AutoSize = true;
            this.lblSpecie.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecie.Location = new System.Drawing.Point(696, 119);
            this.lblSpecie.Name = "lblSpecie";
            this.lblSpecie.Size = new System.Drawing.Size(60, 18);
            this.lblSpecie.TabIndex = 46;
            this.lblSpecie.Text = "Specie";
            // 
            // lblFilliation
            // 
            this.lblFilliation.AutoSize = true;
            this.lblFilliation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilliation.Location = new System.Drawing.Point(690, 167);
            this.lblFilliation.Name = "lblFilliation";
            this.lblFilliation.Size = new System.Drawing.Size(68, 18);
            this.lblFilliation.TabIndex = 47;
            this.lblFilliation.Text = "Filliation";
            // 
            // SWcdFiliation
            // 
            this.SWcdFiliation.ClasseCS = "Filiations.dll";
            this.SWcdFiliation.ControlID = "SWtxtFiliation";
            this.SWcdFiliation.FormCS = "Filiations.frmFiliationsScreenCS";
            this.SWcdFiliation.Location = new System.Drawing.Point(759, 139);
            this.SWcdFiliation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SWcdFiliation.Name = "SWcdFiliation";
            this.SWcdFiliation.NomCodi = "CodeFiliation";
            this.SWcdFiliation.NomDesc = "DescFiliations";
            this.SWcdFiliation.NomId = "idFiliation";
            this.SWcdFiliation.NomTaula = "Filiations";
            this.SWcdFiliation.NullSpace = false;
            this.SWcdFiliation.Size = new System.Drawing.Size(376, 49);
            this.SWcdFiliation.TabIndex = 11;
            // 
            // SWcdSector
            // 
            this.SWcdSector.ClasseCS = "Sectors.dll";
            this.SWcdSector.ControlID = "SWtxtSector";
            this.SWcdSector.FormCS = "Sectors.frmSectorsScreenCS";
            this.SWcdSector.Location = new System.Drawing.Point(759, 49);
            this.SWcdSector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SWcdSector.Name = "SWcdSector";
            this.SWcdSector.NomCodi = "CodeSector";
            this.SWcdSector.NomDesc = "DescSector";
            this.SWcdSector.NomId = "idSector";
            this.SWcdSector.NomTaula = "Sectors";
            this.SWcdSector.NullSpace = false;
            this.SWcdSector.Size = new System.Drawing.Size(376, 48);
            this.SWcdSector.TabIndex = 9;
            // 
            // SWtxtSector
            // 
            this.SWtxtSector.AllowedData = SecureCoreInheritedControl.DataType.Number;
            this.SWtxtSector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(194)))), ((int)(((byte)(204)))));
            this.SWtxtSector.ControlID = "SWcdSector";
            this.SWtxtSector.DatabaseName = "idSector";
            this.SWtxtSector.IsForeignKey = true;
            this.SWtxtSector.Location = new System.Drawing.Point(1066, 75);
            this.SWtxtSector.Name = "SWtxtSector";
            this.SWtxtSector.NullSpace = false;
            this.SWtxtSector.Size = new System.Drawing.Size(60, 21);
            this.SWtxtSector.TabIndex = 50;
            this.SWtxtSector.TabStop = false;
            // 
            // SWtxtSpecies
            // 
            this.SWtxtSpecies.AllowedData = SecureCoreInheritedControl.DataType.Number;
            this.SWtxtSpecies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(194)))), ((int)(((byte)(204)))));
            this.SWtxtSpecies.ControlID = "SWcdSpecies";
            this.SWtxtSpecies.DatabaseName = "idNatives";
            this.SWtxtSpecies.IsForeignKey = true;
            this.SWtxtSpecies.Location = new System.Drawing.Point(1066, 119);
            this.SWtxtSpecies.Name = "SWtxtSpecies";
            this.SWtxtSpecies.NullSpace = false;
            this.SWtxtSpecies.Size = new System.Drawing.Size(60, 21);
            this.SWtxtSpecies.TabIndex = 51;
            this.SWtxtSpecies.TabStop = false;
            // 
            // SWtxtFiliation
            // 
            this.SWtxtFiliation.AllowedData = SecureCoreInheritedControl.DataType.Number;
            this.SWtxtFiliation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(194)))), ((int)(((byte)(204)))));
            this.SWtxtFiliation.ControlID = "SWcdFiliation";
            this.SWtxtFiliation.DatabaseName = "idFiliation";
            this.SWtxtFiliation.IsForeignKey = true;
            this.SWtxtFiliation.Location = new System.Drawing.Point(1066, 166);
            this.SWtxtFiliation.Name = "SWtxtFiliation";
            this.SWtxtFiliation.NullSpace = false;
            this.SWtxtFiliation.Size = new System.Drawing.Size(60, 21);
            this.SWtxtFiliation.TabIndex = 52;
            this.SWtxtFiliation.TabStop = false;
            // 
            // SWtxtPortPlanet1
            // 
            this.SWtxtPortPlanet1.AllowedData = SecureCoreInheritedControl.DataType.Number;
            this.SWtxtPortPlanet1.BackColor = System.Drawing.Color.White;
            this.SWtxtPortPlanet1.ControlID = null;
            this.SWtxtPortPlanet1.DatabaseName = "PortPlanet";
            this.SWtxtPortPlanet1.IsForeignKey = false;
            this.SWtxtPortPlanet1.Location = new System.Drawing.Point(474, 212);
            this.SWtxtPortPlanet1.MaxLength = 4;
            this.SWtxtPortPlanet1.Name = "SWtxtPortPlanet1";
            this.SWtxtPortPlanet1.NullSpace = true;
            this.SWtxtPortPlanet1.Size = new System.Drawing.Size(132, 21);
            this.SWtxtPortPlanet1.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(371, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 18);
            this.label11.TabIndex = 55;
            this.label11.Text = "\tPlanet Port 1 ";
            // 
            // isPlanet
            // 
            this.isPlanet.CtrlName = "SWtxtPlanetPicture";
            this.isPlanet.DefaultPath = null;
            this.isPlanet.DestinationPath = null;
            this.isPlanet.Location = new System.Drawing.Point(835, 207);
            this.isPlanet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.isPlanet.Name = "isPlanet";
            this.isPlanet.Size = new System.Drawing.Size(298, 105);
            this.isPlanet.TabIndex = 13;
            this.isPlanet.TabStop = false;
            // 
            // frmPlanets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(1201, 729);
            this.Controls.Add(this.SWcdFiliation);
            this.Controls.Add(this.SWcdSpecies);
            this.Controls.Add(this.SWcdSector);
            this.Controls.Add(this.SWtxtPlanetPicture);
            this.Controls.Add(this.isPlanet);
            this.Controls.Add(this.SWtxtPortPlanet1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SWtxtFiliation);
            this.Controls.Add(this.SWtxtSpecies);
            this.Controls.Add(this.SWtxtSector);
            this.Controls.Add(this.lblFilliation);
            this.Controls.Add(this.lblSpecie);
            this.Controls.Add(this.SWtxtPortPlanet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SWtxtIPPlanet);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SWtxtparsecs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SWtxtlat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SWtxtlong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSector);
            this.Controls.Add(this.SWtxtDescPlanet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SWtxtCodePlanet);
            this.Controls.Add(this.lblUserName);
            this.MinimumSize = new System.Drawing.Size(782, 558);
            this.Name = "frmPlanets";
            this.Load += new System.EventHandler(this.frmPlanets_Load);
            this.Controls.SetChildIndex(this.lblUserName, 0);
            this.Controls.SetChildIndex(this.SWtxtCodePlanet, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.SWtxtDescPlanet, 0);
            this.Controls.SetChildIndex(this.lblSector, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.SWtxtlong, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.SWtxtlat, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.SWtxtparsecs, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.SWtxtIPPlanet, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.SWtxtPortPlanet, 0);
            this.Controls.SetChildIndex(this.lblSpecie, 0);
            this.Controls.SetChildIndex(this.lblFilliation, 0);
            this.Controls.SetChildIndex(this.SWtxtSector, 0);
            this.Controls.SetChildIndex(this.SWtxtSpecies, 0);
            this.Controls.SetChildIndex(this.SWtxtFiliation, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.SWtxtPortPlanet1, 0);
            this.Controls.SetChildIndex(this.isPlanet, 0);
            this.Controls.SetChildIndex(this.SWtxtPlanetPicture, 0);
            this.Controls.SetChildIndex(this.SWcdSector, 0);
            this.Controls.SetChildIndex(this.SWcdSpecies, 0);
            this.Controls.SetChildIndex(this.SWcdFiliation, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SecureCoreInheritedControl.SWTextbox SWtxtCodePlanet;
        private System.Windows.Forms.Label lblUserName;
        private SecureCoreInheritedControl.SWTextbox SWtxtDescPlanet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.Label label3;
        private SecureCoreInheritedControl.SWTextbox SWtxtPlanetPicture;
        private System.Windows.Forms.Label label4;
        private SecureCoreInheritedControl.SWTextbox SWtxtparsecs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private SecureCoreInheritedControl.SWTextbox SWtxtPortPlanet;
        private System.Windows.Forms.Label label9;
        private SecureCoreInheritedControl.SWTextbox SWtxtIPPlanet;
        private System.Windows.Forms.Label label10;
        private SecureCoreInheritedControl.SWTextbox SWtxtlong;
        private SecureCoreInheritedControl.SWTextbox SWtxtlat;
        private SWUserControls.SWCodi SWcdSpecies;
        private System.Windows.Forms.Label lblSpecie;
        private System.Windows.Forms.Label lblFilliation;
        private SWUserControls.SWCodi SWcdFiliation;
        private SWUserControls.SWCodi SWcdSector;
        private SecureCoreInheritedControl.SWTextbox SWtxtSector;
        private SecureCoreInheritedControl.SWTextbox SWtxtSpecies;
        private SecureCoreInheritedControl.SWTextbox SWtxtFiliation;
        private SecureCoreInheritedControl.SWTextbox SWtxtPortPlanet1;
        private System.Windows.Forms.Label label11;
        private SWUserControls.ImageSelector isPlanet;
    }
}
