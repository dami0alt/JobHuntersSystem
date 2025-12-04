
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
            this.label2 = new System.Windows.Forms.Label();
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
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SWcdFiliation = new SWUserControls.SWCodi();
            this.SWcdSector = new SWUserControls.SWCodi();
            this.SWtxtSpecie = new SecureCoreInheritedControl.SWTextbox();
            this.SWtxtSpecies = new SecureCoreInheritedControl.SWTextbox();
            this.SWtxtFiliation = new SecureCoreInheritedControl.SWTextbox();
            this.SWtxtPortPlanet1 = new SecureCoreInheritedControl.SWTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.isPlanet = new SWUserControls.ImageSelector();
            this.SuspendLayout();
            // 
            // lblTableName
            // 
            this.lblTableName.Location = new System.Drawing.Point(110, 9);
            this.lblTableName.Size = new System.Drawing.Size(1019, 25);
            // 
            // SWtxtCodePlanet
            // 
            this.SWtxtCodePlanet.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtCodePlanet.BackColor = System.Drawing.SystemColors.Window;
            this.SWtxtCodePlanet.ControlID = null;
            this.SWtxtCodePlanet.DatabaseName = "CodePlanet";
            this.SWtxtCodePlanet.IsForeignKey = false;
            this.SWtxtCodePlanet.Location = new System.Drawing.Point(160, 76);
            this.SWtxtCodePlanet.Name = "SWtxtCodePlanet";
            this.SWtxtCodePlanet.NullSpace = true;
            this.SWtxtCodePlanet.Size = new System.Drawing.Size(157, 21);
            this.SWtxtCodePlanet.TabIndex = 21;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(55, 79);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(99, 18);
            this.lblUserName.TabIndex = 22;
            this.lblUserName.Text = "\tPlanet Code";
            // 
            // SWtxtDescPlanet
            // 
            this.SWtxtDescPlanet.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtDescPlanet.BackColor = System.Drawing.SystemColors.Window;
            this.SWtxtDescPlanet.ControlID = null;
            this.SWtxtDescPlanet.DatabaseName = "DescPlanet";
            this.SWtxtDescPlanet.IsForeignKey = false;
            this.SWtxtDescPlanet.Location = new System.Drawing.Point(160, 120);
            this.SWtxtDescPlanet.Name = "SWtxtDescPlanet";
            this.SWtxtDescPlanet.NullSpace = true;
            this.SWtxtDescPlanet.Size = new System.Drawing.Size(157, 21);
            this.SWtxtDescPlanet.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "\tPlanet Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(624, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Sector";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Longitude";
            // 
            // SWtxtPlanetPicture
            // 
            this.SWtxtPlanetPicture.AllowedData = SecureCoreInheritedControl.DataType.Path;
            this.SWtxtPlanetPicture.BackColor = System.Drawing.SystemColors.Window;
            this.SWtxtPlanetPicture.ControlID = "isPlanet";
            this.SWtxtPlanetPicture.DatabaseName = "PlanetPicture";
            this.SWtxtPlanetPicture.IsForeignKey = false;
            this.SWtxtPlanetPicture.Location = new System.Drawing.Point(160, 274);
            this.SWtxtPlanetPicture.Name = "SWtxtPlanetPicture";
            this.SWtxtPlanetPicture.NullSpace = true;
            this.SWtxtPlanetPicture.Size = new System.Drawing.Size(663, 21);
            this.SWtxtPlanetPicture.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "\tPlanet Image";
            // 
            // SWtxtparsecs
            // 
            this.SWtxtparsecs.AllowedData = SecureCoreInheritedControl.DataType.Number;
            this.SWtxtparsecs.BackColor = System.Drawing.SystemColors.Window;
            this.SWtxtparsecs.ControlID = null;
            this.SWtxtparsecs.DatabaseName = "parsecs";
            this.SWtxtparsecs.IsForeignKey = false;
            this.SWtxtparsecs.Location = new System.Drawing.Point(474, 76);
            this.SWtxtparsecs.Name = "SWtxtparsecs";
            this.SWtxtparsecs.NullSpace = true;
            this.SWtxtparsecs.Size = new System.Drawing.Size(132, 21);
            this.SWtxtparsecs.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(328, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 18);
            this.label6.TabIndex = 32;
            this.label6.Text = "Distance (Parsecs)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(88, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 30;
            this.label7.Text = "Latitude";
            // 
            // SWtxtPortPlanet
            // 
            this.SWtxtPortPlanet.AllowedData = SecureCoreInheritedControl.DataType.Number;
            this.SWtxtPortPlanet.BackColor = System.Drawing.SystemColors.Window;
            this.SWtxtPortPlanet.ControlID = null;
            this.SWtxtPortPlanet.DatabaseName = "PortPlanet";
            this.SWtxtPortPlanet.IsForeignKey = false;
            this.SWtxtPortPlanet.Location = new System.Drawing.Point(474, 167);
            this.SWtxtPortPlanet.Name = "SWtxtPortPlanet";
            this.SWtxtPortPlanet.NullSpace = true;
            this.SWtxtPortPlanet.Size = new System.Drawing.Size(132, 21);
            this.SWtxtPortPlanet.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(384, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 18);
            this.label9.TabIndex = 40;
            this.label9.Text = "\tPlanet Port";
            // 
            // SWtxtIPPlanet
            // 
            this.SWtxtIPPlanet.AllowedData = SecureCoreInheritedControl.DataType.Path;
            this.SWtxtIPPlanet.BackColor = System.Drawing.SystemColors.Window;
            this.SWtxtIPPlanet.ControlID = null;
            this.SWtxtIPPlanet.DatabaseName = "IPPlanet";
            this.SWtxtIPPlanet.IsForeignKey = false;
            this.SWtxtIPPlanet.Location = new System.Drawing.Point(474, 120);
            this.SWtxtIPPlanet.Name = "SWtxtIPPlanet";
            this.SWtxtIPPlanet.NullSpace = true;
            this.SWtxtIPPlanet.Size = new System.Drawing.Size(132, 21);
            this.SWtxtIPPlanet.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(337, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 18);
            this.label10.TabIndex = 38;
            this.label10.Text = "\tPlanet IP Address";
            // 
            // SWtxtlong
            // 
            this.SWtxtlong.AllowedData = SecureCoreInheritedControl.DataType.Number;
            this.SWtxtlong.BackColor = System.Drawing.SystemColors.Window;
            this.SWtxtlong.ControlID = null;
            this.SWtxtlong.DatabaseName = "long";
            this.SWtxtlong.IsForeignKey = false;
            this.SWtxtlong.Location = new System.Drawing.Point(160, 167);
            this.SWtxtlong.Name = "SWtxtlong";
            this.SWtxtlong.NullSpace = true;
            this.SWtxtlong.Size = new System.Drawing.Size(157, 21);
            this.SWtxtlong.TabIndex = 27;
            // 
            // SWtxtlat
            // 
            this.SWtxtlat.AllowedData = SecureCoreInheritedControl.DataType.Number;
            this.SWtxtlat.BackColor = System.Drawing.SystemColors.Window;
            this.SWtxtlat.ControlID = null;
            this.SWtxtlat.DatabaseName = "lat";
            this.SWtxtlat.IsForeignKey = false;
            this.SWtxtlat.Location = new System.Drawing.Point(160, 219);
            this.SWtxtlat.Name = "SWtxtlat";
            this.SWtxtlat.NullSpace = true;
            this.SWtxtlat.Size = new System.Drawing.Size(157, 21);
            this.SWtxtlat.TabIndex = 29;
            // 
            // SWcdSpecies
            // 
            this.SWcdSpecies.ClasseCS = null;
            this.SWcdSpecies.ControlID = "SWtxtSpecies";
            this.SWcdSpecies.FormCS = null;
            this.SWcdSpecies.Location = new System.Drawing.Point(685, 94);
            this.SWcdSpecies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SWcdSpecies.Name = "SWcdSpecies";
            this.SWcdSpecies.NomCodi = "CodeSpecie";
            this.SWcdSpecies.NomDesc = "DescSpecie";
            this.SWcdSpecies.NomId = "idSpecie";
            this.SWcdSpecies.NomTaula = "Species";
            this.SWcdSpecies.NullSpace = false;
            this.SWcdSpecies.Size = new System.Drawing.Size(376, 49);
            this.SWcdSpecies.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(624, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 46;
            this.label5.Text = "Sector";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(624, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 18);
            this.label8.TabIndex = 47;
            this.label8.Text = "Sector";
            // 
            // SWcdFiliation
            // 
            this.SWcdFiliation.ClasseCS = null;
            this.SWcdFiliation.ControlID = "SWtxtFiliation";
            this.SWcdFiliation.FormCS = null;
            this.SWcdFiliation.Location = new System.Drawing.Point(685, 139);
            this.SWcdFiliation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SWcdFiliation.Name = "SWcdFiliation";
            this.SWcdFiliation.NomCodi = "CodeFiliation";
            this.SWcdFiliation.NomDesc = "DescFiliations";
            this.SWcdFiliation.NomId = "idFiliation";
            this.SWcdFiliation.NomTaula = "Filiations";
            this.SWcdFiliation.NullSpace = false;
            this.SWcdFiliation.Size = new System.Drawing.Size(376, 49);
            this.SWcdFiliation.TabIndex = 48;
            // 
            // SWcdSector
            // 
            this.SWcdSector.ClasseCS = null;
            this.SWcdSector.ControlID = "SWtxtPlanet";
            this.SWcdSector.FormCS = null;
            this.SWcdSector.Location = new System.Drawing.Point(685, 49);
            this.SWcdSector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SWcdSector.Name = "SWcdSector";
            this.SWcdSector.NomCodi = "CodeSector";
            this.SWcdSector.NomDesc = "DescSector";
            this.SWcdSector.NomId = "idSector";
            this.SWcdSector.NomTaula = "Sectors";
            this.SWcdSector.NullSpace = false;
            this.SWcdSector.Size = new System.Drawing.Size(376, 48);
            this.SWcdSector.TabIndex = 49;
            // 
            // SWtxtSpecie
            // 
            this.SWtxtSpecie.AllowedData = SecureCoreInheritedControl.DataType.Number;
            this.SWtxtSpecie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(194)))), ((int)(((byte)(204)))));
            this.SWtxtSpecie.ControlID = "SWcdSector";
            this.SWtxtSpecie.DatabaseName = "idSector";
            this.SWtxtSpecie.IsForeignKey = true;
            this.SWtxtSpecie.Location = new System.Drawing.Point(1067, 73);
            this.SWtxtSpecie.Name = "SWtxtSpecie";
            this.SWtxtSpecie.NullSpace = false;
            this.SWtxtSpecie.Size = new System.Drawing.Size(60, 21);
            this.SWtxtSpecie.TabIndex = 50;
            // 
            // SWtxtSpecies
            // 
            this.SWtxtSpecies.AllowedData = SecureCoreInheritedControl.DataType.Number;
            this.SWtxtSpecies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(194)))), ((int)(((byte)(204)))));
            this.SWtxtSpecies.ControlID = "SWcdSpecies";
            this.SWtxtSpecies.DatabaseName = "idNatives";
            this.SWtxtSpecies.IsForeignKey = true;
            this.SWtxtSpecies.Location = new System.Drawing.Point(1067, 117);
            this.SWtxtSpecies.Name = "SWtxtSpecies";
            this.SWtxtSpecies.NullSpace = false;
            this.SWtxtSpecies.Size = new System.Drawing.Size(60, 21);
            this.SWtxtSpecies.TabIndex = 51;
            // 
            // SWtxtFiliation
            // 
            this.SWtxtFiliation.AllowedData = SecureCoreInheritedControl.DataType.Number;
            this.SWtxtFiliation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(194)))), ((int)(((byte)(204)))));
            this.SWtxtFiliation.ControlID = "SWcdFiliation";
            this.SWtxtFiliation.DatabaseName = "idFiliation";
            this.SWtxtFiliation.IsForeignKey = true;
            this.SWtxtFiliation.Location = new System.Drawing.Point(1067, 164);
            this.SWtxtFiliation.Name = "SWtxtFiliation";
            this.SWtxtFiliation.NullSpace = false;
            this.SWtxtFiliation.Size = new System.Drawing.Size(60, 21);
            this.SWtxtFiliation.TabIndex = 52;
            // 
            // SWtxtPortPlanet1
            // 
            this.SWtxtPortPlanet1.AllowedData = SecureCoreInheritedControl.DataType.Number;
            this.SWtxtPortPlanet1.BackColor = System.Drawing.SystemColors.Window;
            this.SWtxtPortPlanet1.ControlID = null;
            this.SWtxtPortPlanet1.DatabaseName = "PortPlanet";
            this.SWtxtPortPlanet1.IsForeignKey = false;
            this.SWtxtPortPlanet1.Location = new System.Drawing.Point(474, 219);
            this.SWtxtPortPlanet1.Name = "SWtxtPortPlanet1";
            this.SWtxtPortPlanet1.NullSpace = true;
            this.SWtxtPortPlanet1.Size = new System.Drawing.Size(132, 21);
            this.SWtxtPortPlanet1.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(371, 219);
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
            this.isPlanet.Location = new System.Drawing.Point(831, 199);
            this.isPlanet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.isPlanet.Name = "isPlanet";
            this.isPlanet.Size = new System.Drawing.Size(298, 105);
            this.isPlanet.TabIndex = 56;
            // 
            // frmPlanets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(1224, 729);
            this.Controls.Add(this.isPlanet);
            this.Controls.Add(this.SWtxtPortPlanet1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SWtxtFiliation);
            this.Controls.Add(this.SWtxtSpecies);
            this.Controls.Add(this.SWtxtSpecie);
            this.Controls.Add(this.SWcdSector);
            this.Controls.Add(this.SWcdFiliation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SWcdSpecies);
            this.Controls.Add(this.SWtxtPortPlanet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SWtxtIPPlanet);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SWtxtPlanetPicture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SWtxtparsecs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SWtxtlat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SWtxtlong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SWtxtDescPlanet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SWtxtCodePlanet);
            this.Controls.Add(this.lblUserName);
            this.Name = "frmPlanets";
            this.Load += new System.EventHandler(this.frmPlanets_Load);
            this.Controls.SetChildIndex(this.lblUserName, 0);
            this.Controls.SetChildIndex(this.SWtxtCodePlanet, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.SWtxtDescPlanet, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.SWtxtlong, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.SWtxtlat, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.SWtxtparsecs, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.SWtxtPlanetPicture, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.SWtxtIPPlanet, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.SWtxtPortPlanet, 0);
            this.Controls.SetChildIndex(this.SWcdSpecies, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.SWcdFiliation, 0);
            this.Controls.SetChildIndex(this.SWcdSector, 0);
            this.Controls.SetChildIndex(this.SWtxtSpecie, 0);
            this.Controls.SetChildIndex(this.SWtxtSpecies, 0);
            this.Controls.SetChildIndex(this.SWtxtFiliation, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.SWtxtPortPlanet1, 0);
            this.Controls.SetChildIndex(this.isPlanet, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SecureCoreInheritedControl.SWTextbox SWtxtCodePlanet;
        private System.Windows.Forms.Label lblUserName;
        private SecureCoreInheritedControl.SWTextbox SWtxtDescPlanet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private SWUserControls.SWCodi SWcdFiliation;
        private SWUserControls.SWCodi SWcdSector;
        private SecureCoreInheritedControl.SWTextbox SWtxtSpecie;
        private SecureCoreInheritedControl.SWTextbox SWtxtSpecies;
        private SecureCoreInheritedControl.SWTextbox SWtxtFiliation;
        private SecureCoreInheritedControl.SWTextbox SWtxtPortPlanet1;
        private System.Windows.Forms.Label label11;
        private SWUserControls.ImageSelector isPlanet;
    }
}
