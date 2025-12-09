
namespace Species
{
    partial class frmSpeciesScreenCS
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
            this.lblCodeSpecie = new System.Windows.Forms.Label();
            this.SWtxtCodeSpecie = new SecureCoreInheritedControl.SWTextbox();
            this.SWtxtDescSpecie = new SecureCoreInheritedControl.SWTextbox();
            this.lblDescUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCodeSpecie
            // 
            this.lblCodeSpecie.AutoSize = true;
            this.lblCodeSpecie.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeSpecie.Location = new System.Drawing.Point(57, 92);
            this.lblCodeSpecie.Name = "lblCodeSpecie";
            this.lblCodeSpecie.Size = new System.Drawing.Size(105, 20);
            this.lblCodeSpecie.TabIndex = 23;
            this.lblCodeSpecie.Text = "Specie Code";
            // 
            // SWtxtCodeSpecie
            // 
            this.SWtxtCodeSpecie.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtCodeSpecie.ControlID = null;
            this.SWtxtCodeSpecie.DatabaseName = "CodeSpecie";
            this.SWtxtCodeSpecie.IsForeignKey = false;
            this.SWtxtCodeSpecie.Location = new System.Drawing.Point(168, 93);
            this.SWtxtCodeSpecie.Name = "SWtxtCodeSpecie";
            this.SWtxtCodeSpecie.NullSpace = true;
            this.SWtxtCodeSpecie.Size = new System.Drawing.Size(133, 20);
            this.SWtxtCodeSpecie.TabIndex = 24;
            // 
            // SWtxtDescSpecie
            // 
            this.SWtxtDescSpecie.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtDescSpecie.ControlID = null;
            this.SWtxtDescSpecie.DatabaseName = "DescSpecie";
            this.SWtxtDescSpecie.IsForeignKey = false;
            this.SWtxtDescSpecie.Location = new System.Drawing.Point(168, 152);
            this.SWtxtDescSpecie.Name = "SWtxtDescSpecie";
            this.SWtxtDescSpecie.NullSpace = true;
            this.SWtxtDescSpecie.Size = new System.Drawing.Size(133, 20);
            this.SWtxtDescSpecie.TabIndex = 26;
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
            // frmSpeciesScreenCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(842, 584);
            this.Controls.Add(this.SWtxtDescSpecie);
            this.Controls.Add(this.lblDescUser);
            this.Controls.Add(this.SWtxtCodeSpecie);
            this.Controls.Add(this.lblCodeSpecie);
            this.Name = "frmSpeciesScreenCS";
            this.Controls.SetChildIndex(this.lblCodeSpecie, 0);
            this.Controls.SetChildIndex(this.SWtxtCodeSpecie, 0);
            this.Controls.SetChildIndex(this.lblDescUser, 0);
            this.Controls.SetChildIndex(this.SWtxtDescSpecie, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SecureCoreInheritedControl.SWTextbox swTextbox1;
        private SecureCoreInheritedControl.SWTextbox swTextbox2;
        private SecureCoreInheritedControl.SWTextbox swTextbox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodeSpecie;
        private SecureCoreInheritedControl.SWTextbox SWtxtCodeSpecie;
        private SecureCoreInheritedControl.SWTextbox SWtxtDescSpecie;
        private System.Windows.Forms.Label lblDescUser;
    }
}
