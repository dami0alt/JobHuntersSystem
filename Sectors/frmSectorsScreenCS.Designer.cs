
namespace Sectors
{
    partial class frmSectorsScreenCS
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
            this.SWtxtDescSector = new SecureCoreInheritedControl.SWTextbox();
            this.SWtxtCodeSectors = new SecureCoreInheritedControl.SWTextbox();
            this.SuspendLayout();
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(65, 137);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(91, 20);
            this.lblDesc.TabIndex = 39;
            this.lblDesc.Text = "Description";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(48, 92);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(102, 20);
            this.lblCode.TabIndex = 38;
            this.lblCode.Text = "Code Sector";
            // 
            // SWtxtDescSector
            // 
            this.SWtxtDescSector.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtDescSector.ControlID = null;
            this.SWtxtDescSector.DatabaseName = "DescSector";
            this.SWtxtDescSector.IsForeignKey = false;
            this.SWtxtDescSector.Location = new System.Drawing.Point(183, 139);
            this.SWtxtDescSector.Name = "SWtxtDescSector";
            this.SWtxtDescSector.NullSpace = true;
            this.SWtxtDescSector.Size = new System.Drawing.Size(162, 20);
            this.SWtxtDescSector.TabIndex = 37;
            // 
            // SWtxtCodeSectors
            // 
            this.SWtxtCodeSectors.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtCodeSectors.ControlID = null;
            this.SWtxtCodeSectors.DatabaseName = "CodeSector";
            this.SWtxtCodeSectors.IsForeignKey = false;
            this.SWtxtCodeSectors.Location = new System.Drawing.Point(183, 92);
            this.SWtxtCodeSectors.Name = "SWtxtCodeSectors";
            this.SWtxtCodeSectors.NullSpace = true;
            this.SWtxtCodeSectors.Size = new System.Drawing.Size(162, 20);
            this.SWtxtCodeSectors.TabIndex = 36;
            // 
            // frmSectorsScreenCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(842, 584);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.SWtxtDescSector);
            this.Controls.Add(this.SWtxtCodeSectors);
            this.Name = "frmSectorsScreenCS";
            this.Controls.SetChildIndex(this.SWtxtCodeSectors, 0);
            this.Controls.SetChildIndex(this.SWtxtDescSector, 0);
            this.Controls.SetChildIndex(this.lblCode, 0);
            this.Controls.SetChildIndex(this.lblDesc, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblCode;
        private SecureCoreInheritedControl.SWTextbox SWtxtDescSector;
        private SecureCoreInheritedControl.SWTextbox SWtxtCodeSectors;
    }
}
