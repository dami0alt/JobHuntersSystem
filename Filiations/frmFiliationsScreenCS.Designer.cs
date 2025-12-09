
namespace Filiations
{
    partial class frmFiliationsScreenCS
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
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.SWtxtDescFiliations = new SecureCoreInheritedControl.SWTextbox();
            this.SWtxtCodeFiliation = new SecureCoreInheritedControl.SWTextbox();
            this.SuspendLayout();
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(65, 160);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(91, 20);
            this.lblDesc.TabIndex = 39;
            this.lblDesc.Text = "Description";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(48, 115);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(108, 20);
            this.lblCode.TabIndex = 38;
            this.lblCode.Text = "Code Filiation";
            // 
            // SWtxtDescFiliations
            // 
            this.SWtxtDescFiliations.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtDescFiliations.ControlID = null;
            this.SWtxtDescFiliations.DatabaseName = "DescFiliations";
            this.SWtxtDescFiliations.IsForeignKey = false;
            this.SWtxtDescFiliations.Location = new System.Drawing.Point(183, 162);
            this.SWtxtDescFiliations.Name = "SWtxtDescFiliations";
            this.SWtxtDescFiliations.NullSpace = true;
            this.SWtxtDescFiliations.Size = new System.Drawing.Size(162, 20);
            this.SWtxtDescFiliations.TabIndex = 37;
            // 
            // SWtxtCodeFiliation
            // 
            this.SWtxtCodeFiliation.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtCodeFiliation.ControlID = null;
            this.SWtxtCodeFiliation.DatabaseName = "CodeFiliation";
            this.SWtxtCodeFiliation.IsForeignKey = false;
            this.SWtxtCodeFiliation.Location = new System.Drawing.Point(183, 115);
            this.SWtxtCodeFiliation.Name = "SWtxtCodeFiliation";
            this.SWtxtCodeFiliation.NullSpace = true;
            this.SWtxtCodeFiliation.Size = new System.Drawing.Size(162, 20);
            this.SWtxtCodeFiliation.TabIndex = 36;
            // 
            // frmFiliationsScreenCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(842, 584);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.SWtxtDescFiliations);
            this.Controls.Add(this.SWtxtCodeFiliation);
            this.Name = "frmFiliationsScreenCS";
            this.Controls.SetChildIndex(this.SWtxtCodeFiliation, 0);
            this.Controls.SetChildIndex(this.SWtxtDescFiliations, 0);
            this.Controls.SetChildIndex(this.lblCode, 0);
            this.Controls.SetChildIndex(this.lblDesc, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblCode;
        private SecureCoreInheritedControl.SWTextbox SWtxtDescFiliations;
        private SecureCoreInheritedControl.SWTextbox SWtxtCodeFiliation;
    }
}
