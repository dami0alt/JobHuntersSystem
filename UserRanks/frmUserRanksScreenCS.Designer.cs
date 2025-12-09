
namespace UserRanks
{
    partial class frmUserRanksScreenCS
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
            this.lblCodeRank = new System.Windows.Forms.Label();
            this.SWtxtCodeUser = new SecureCoreInheritedControl.SWTextbox();
            this.SWtxtDescCategory = new SecureCoreInheritedControl.SWTextbox();
            this.lblDescUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCodeRank
            // 
            this.lblCodeRank.AutoSize = true;
            this.lblCodeRank.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeRank.Location = new System.Drawing.Point(75, 92);
            this.lblCodeRank.Name = "lblCodeRank";
            this.lblCodeRank.Size = new System.Drawing.Size(91, 20);
            this.lblCodeRank.TabIndex = 23;
            this.lblCodeRank.Text = "Rank Code";
            // 
            // SWtxtCodeUser
            // 
            this.SWtxtCodeUser.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtCodeUser.ControlID = null;
            this.SWtxtCodeUser.DatabaseName = "CodeRank";
            this.SWtxtCodeUser.IsForeignKey = false;
            this.SWtxtCodeUser.Location = new System.Drawing.Point(168, 93);
            this.SWtxtCodeUser.Name = "SWtxtCodeUser";
            this.SWtxtCodeUser.NullSpace = true;
            this.SWtxtCodeUser.Size = new System.Drawing.Size(133, 20);
            this.SWtxtCodeUser.TabIndex = 24;
            // 
            // SWtxtDescCategory
            // 
            this.SWtxtDescCategory.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtDescCategory.ControlID = null;
            this.SWtxtDescCategory.DatabaseName = "DescRank";
            this.SWtxtDescCategory.IsForeignKey = false;
            this.SWtxtDescCategory.Location = new System.Drawing.Point(168, 152);
            this.SWtxtDescCategory.Name = "SWtxtDescCategory";
            this.SWtxtDescCategory.NullSpace = true;
            this.SWtxtDescCategory.Size = new System.Drawing.Size(133, 20);
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
            // frmUserRanksScreenCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(842, 584);
            this.Controls.Add(this.SWtxtDescCategory);
            this.Controls.Add(this.lblDescUser);
            this.Controls.Add(this.SWtxtCodeUser);
            this.Controls.Add(this.lblCodeRank);
            this.Name = "frmUserRanksScreenCS";
            this.Controls.SetChildIndex(this.lblCodeRank, 0);
            this.Controls.SetChildIndex(this.SWtxtCodeUser, 0);
            this.Controls.SetChildIndex(this.lblDescUser, 0);
            this.Controls.SetChildIndex(this.SWtxtDescCategory, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SecureCoreInheritedControl.SWTextbox swTextbox1;
        private SecureCoreInheritedControl.SWTextbox swTextbox2;
        private SecureCoreInheritedControl.SWTextbox swTextbox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodeRank;
        private SecureCoreInheritedControl.SWTextbox SWtxtCodeUser;
        private SecureCoreInheritedControl.SWTextbox SWtxtDescCategory;
        private System.Windows.Forms.Label lblDescUser;
    }
}
