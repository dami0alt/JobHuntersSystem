
namespace Planets
{
    partial class frmPlanetsScreenCS
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
            this.lblCodePlanet = new System.Windows.Forms.Label();
            this.SWtxtCodeUser = new SecureCoreInheritedControl.SWTextbox();
            this.SWtxtDescCategory = new SecureCoreInheritedControl.SWTextbox();
            this.lblDescUser = new System.Windows.Forms.Label();
            this.SWtxtLong = new SecureCoreInheritedControl.SWTextbox();
            this.lblLong = new System.Windows.Forms.Label();
            this.SWtxtLat = new SecureCoreInheritedControl.SWTextbox();
            this.lblLat = new System.Windows.Forms.Label();
            this.SWtxtParsecs = new SecureCoreInheritedControl.SWTextbox();
            this.lblParsecs = new System.Windows.Forms.Label();
            this.SWtxtIpPlanet = new SecureCoreInheritedControl.SWTextbox();
            this.lblIpPlanet = new System.Windows.Forms.Label();
            this.SWtxtPortPlanet1 = new SecureCoreInheritedControl.SWTextbox();
            this.SWPortPlanet = new SecureCoreInheritedControl.SWTextbox();
            this.lblPortPlanet = new System.Windows.Forms.Label();
            this.lblPortPlanet1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCodePlanet
            // 
            this.lblCodePlanet.AutoSize = true;
            this.lblCodePlanet.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodePlanet.Location = new System.Drawing.Point(63, 92);
            this.lblCodePlanet.Name = "lblCodePlanet";
            this.lblCodePlanet.Size = new System.Drawing.Size(105, 20);
            this.lblCodePlanet.TabIndex = 23;
            this.lblCodePlanet.Text = "Planet Code ";
            // 
            // SWtxtCodeUser
            // 
            this.SWtxtCodeUser.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtCodeUser.ControlID = null;
            this.SWtxtCodeUser.DatabaseName = "CodePlanet";
            this.SWtxtCodeUser.IsForeignKey = false;
            this.SWtxtCodeUser.Location = new System.Drawing.Point(168, 93);
            this.SWtxtCodeUser.Name = "SWtxtCodeUser";
            this.SWtxtCodeUser.NullSpace = true;
            this.SWtxtCodeUser.Size = new System.Drawing.Size(83, 20);
            this.SWtxtCodeUser.TabIndex = 24;
            // 
            // SWtxtDescCategory
            // 
            this.SWtxtDescCategory.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtDescCategory.ControlID = null;
            this.SWtxtDescCategory.DatabaseName = "DescPlanet";
            this.SWtxtDescCategory.IsForeignKey = false;
            this.SWtxtDescCategory.Location = new System.Drawing.Point(168, 152);
            this.SWtxtDescCategory.Name = "SWtxtDescCategory";
            this.SWtxtDescCategory.NullSpace = true;
            this.SWtxtDescCategory.Size = new System.Drawing.Size(145, 20);
            this.SWtxtDescCategory.TabIndex = 26;
            // 
            // lblDescUser
            // 
            this.lblDescUser.AutoSize = true;
            this.lblDescUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescUser.Location = new System.Drawing.Point(71, 151);
            this.lblDescUser.Name = "lblDescUser";
            this.lblDescUser.Size = new System.Drawing.Size(91, 20);
            this.lblDescUser.TabIndex = 25;
            this.lblDescUser.Text = "Description";
            // 
            // SWtxtLong
            // 
            this.SWtxtLong.AllowedData = SecureCoreInheritedControl.DataType.Number;
            this.SWtxtLong.ControlID = null;
            this.SWtxtLong.DatabaseName = "long";
            this.SWtxtLong.IsForeignKey = false;
            this.SWtxtLong.Location = new System.Drawing.Point(168, 212);
            this.SWtxtLong.Name = "SWtxtLong";
            this.SWtxtLong.NullSpace = true;
            this.SWtxtLong.Size = new System.Drawing.Size(83, 20);
            this.SWtxtLong.TabIndex = 28;
            // 
            // lblLong
            // 
            this.lblLong.AutoSize = true;
            this.lblLong.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLong.Location = new System.Drawing.Point(118, 210);
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(45, 20);
            this.lblLong.TabIndex = 27;
            this.lblLong.Text = "Long";
            // 
            // SWtxtLat
            // 
            this.SWtxtLat.AllowedData = SecureCoreInheritedControl.DataType.Number;
            this.SWtxtLat.ControlID = null;
            this.SWtxtLat.DatabaseName = "lat";
            this.SWtxtLat.IsForeignKey = false;
            this.SWtxtLat.Location = new System.Drawing.Point(416, 92);
            this.SWtxtLat.Name = "SWtxtLat";
            this.SWtxtLat.NullSpace = true;
            this.SWtxtLat.Size = new System.Drawing.Size(83, 20);
            this.SWtxtLat.TabIndex = 33;
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLat.Location = new System.Drawing.Point(379, 92);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(31, 20);
            this.lblLat.TabIndex = 32;
            this.lblLat.Text = "Lat";
            // 
            // SWtxtParsecs
            // 
            this.SWtxtParsecs.AllowedData = SecureCoreInheritedControl.DataType.Number;
            this.SWtxtParsecs.ControlID = null;
            this.SWtxtParsecs.DatabaseName = "parsecs";
            this.SWtxtParsecs.IsForeignKey = false;
            this.SWtxtParsecs.Location = new System.Drawing.Point(416, 151);
            this.SWtxtParsecs.Name = "SWtxtParsecs";
            this.SWtxtParsecs.NullSpace = true;
            this.SWtxtParsecs.Size = new System.Drawing.Size(83, 20);
            this.SWtxtParsecs.TabIndex = 35;
            // 
            // lblParsecs
            // 
            this.lblParsecs.AutoSize = true;
            this.lblParsecs.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParsecs.Location = new System.Drawing.Point(345, 149);
            this.lblParsecs.Name = "lblParsecs";
            this.lblParsecs.Size = new System.Drawing.Size(65, 20);
            this.lblParsecs.TabIndex = 34;
            this.lblParsecs.Text = "Parsecs";
            // 
            // SWtxtIpPlanet
            // 
            this.SWtxtIpPlanet.AllowedData = SecureCoreInheritedControl.DataType.Path;
            this.SWtxtIpPlanet.ControlID = null;
            this.SWtxtIpPlanet.DatabaseName = "IPPlanet";
            this.SWtxtIpPlanet.IsForeignKey = false;
            this.SWtxtIpPlanet.Location = new System.Drawing.Point(416, 210);
            this.SWtxtIpPlanet.Name = "SWtxtIpPlanet";
            this.SWtxtIpPlanet.NullSpace = true;
            this.SWtxtIpPlanet.Size = new System.Drawing.Size(83, 20);
            this.SWtxtIpPlanet.TabIndex = 37;
            // 
            // lblIpPlanet
            // 
            this.lblIpPlanet.AutoSize = true;
            this.lblIpPlanet.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIpPlanet.Location = new System.Drawing.Point(337, 208);
            this.lblIpPlanet.Name = "lblIpPlanet";
            this.lblIpPlanet.Size = new System.Drawing.Size(73, 20);
            this.lblIpPlanet.TabIndex = 36;
            this.lblIpPlanet.Text = "IP Planet";
            // 
            // SWtxtPortPlanet1
            // 
            this.SWtxtPortPlanet1.AllowedData = SecureCoreInheritedControl.DataType.Number;
            this.SWtxtPortPlanet1.ControlID = null;
            this.SWtxtPortPlanet1.DatabaseName = "PortPlanet1";
            this.SWtxtPortPlanet1.IsForeignKey = false;
            this.SWtxtPortPlanet1.Location = new System.Drawing.Point(640, 151);
            this.SWtxtPortPlanet1.Name = "SWtxtPortPlanet1";
            this.SWtxtPortPlanet1.NullSpace = true;
            this.SWtxtPortPlanet1.Size = new System.Drawing.Size(83, 20);
            this.SWtxtPortPlanet1.TabIndex = 41;
            // 
            // SWPortPlanet
            // 
            this.SWPortPlanet.AllowedData = SecureCoreInheritedControl.DataType.Number;
            this.SWPortPlanet.ControlID = null;
            this.SWPortPlanet.DatabaseName = "PortPlanet";
            this.SWPortPlanet.IsForeignKey = false;
            this.SWPortPlanet.Location = new System.Drawing.Point(640, 92);
            this.SWPortPlanet.Name = "SWPortPlanet";
            this.SWPortPlanet.NullSpace = true;
            this.SWPortPlanet.Size = new System.Drawing.Size(83, 20);
            this.SWPortPlanet.TabIndex = 39;
            // 
            // lblPortPlanet
            // 
            this.lblPortPlanet.AutoSize = true;
            this.lblPortPlanet.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortPlanet.Location = new System.Drawing.Point(546, 90);
            this.lblPortPlanet.Name = "lblPortPlanet";
            this.lblPortPlanet.Size = new System.Drawing.Size(88, 20);
            this.lblPortPlanet.TabIndex = 38;
            this.lblPortPlanet.Text = "Planet Port";
            // 
            // lblPortPlanet1
            // 
            this.lblPortPlanet1.AutoSize = true;
            this.lblPortPlanet1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortPlanet1.Location = new System.Drawing.Point(534, 151);
            this.lblPortPlanet1.Name = "lblPortPlanet1";
            this.lblPortPlanet1.Size = new System.Drawing.Size(100, 20);
            this.lblPortPlanet1.TabIndex = 42;
            this.lblPortPlanet1.Text = "Planet Port 1";
            // 
            // frmPlanetsScreenCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(842, 584);
            this.Controls.Add(this.lblPortPlanet1);
            this.Controls.Add(this.SWtxtPortPlanet1);
            this.Controls.Add(this.SWPortPlanet);
            this.Controls.Add(this.lblPortPlanet);
            this.Controls.Add(this.SWtxtIpPlanet);
            this.Controls.Add(this.lblIpPlanet);
            this.Controls.Add(this.SWtxtParsecs);
            this.Controls.Add(this.lblParsecs);
            this.Controls.Add(this.SWtxtLat);
            this.Controls.Add(this.lblLat);
            this.Controls.Add(this.SWtxtLong);
            this.Controls.Add(this.lblLong);
            this.Controls.Add(this.SWtxtDescCategory);
            this.Controls.Add(this.lblDescUser);
            this.Controls.Add(this.SWtxtCodeUser);
            this.Controls.Add(this.lblCodePlanet);
            this.Name = "frmPlanetsScreenCS";
            this.Controls.SetChildIndex(this.lblCodePlanet, 0);
            this.Controls.SetChildIndex(this.SWtxtCodeUser, 0);
            this.Controls.SetChildIndex(this.lblDescUser, 0);
            this.Controls.SetChildIndex(this.SWtxtDescCategory, 0);
            this.Controls.SetChildIndex(this.lblLong, 0);
            this.Controls.SetChildIndex(this.SWtxtLong, 0);
            this.Controls.SetChildIndex(this.lblLat, 0);
            this.Controls.SetChildIndex(this.SWtxtLat, 0);
            this.Controls.SetChildIndex(this.lblParsecs, 0);
            this.Controls.SetChildIndex(this.SWtxtParsecs, 0);
            this.Controls.SetChildIndex(this.lblIpPlanet, 0);
            this.Controls.SetChildIndex(this.SWtxtIpPlanet, 0);
            this.Controls.SetChildIndex(this.lblPortPlanet, 0);
            this.Controls.SetChildIndex(this.SWPortPlanet, 0);
            this.Controls.SetChildIndex(this.SWtxtPortPlanet1, 0);
            this.Controls.SetChildIndex(this.lblPortPlanet1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SecureCoreInheritedControl.SWTextbox swTextbox1;
        private SecureCoreInheritedControl.SWTextbox swTextbox2;
        private SecureCoreInheritedControl.SWTextbox swTextbox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodePlanet;
        private SecureCoreInheritedControl.SWTextbox SWtxtCodeUser;
        private SecureCoreInheritedControl.SWTextbox SWtxtDescCategory;
        private System.Windows.Forms.Label lblDescUser;
        private SecureCoreInheritedControl.SWTextbox SWtxtLong;
        private System.Windows.Forms.Label lblLong;
        private SecureCoreInheritedControl.SWTextbox SWtxtLat;
        private System.Windows.Forms.Label lblLat;
        private SecureCoreInheritedControl.SWTextbox SWtxtParsecs;
        private System.Windows.Forms.Label lblParsecs;
        private SecureCoreInheritedControl.SWTextbox SWtxtIpPlanet;
        private System.Windows.Forms.Label lblIpPlanet;
        private SecureCoreInheritedControl.SWTextbox SWtxtPortPlanet1;
        private SecureCoreInheritedControl.SWTextbox SWPortPlanet;
        private System.Windows.Forms.Label lblPortPlanet;
        private System.Windows.Forms.Label lblPortPlanet1;
    }
}
