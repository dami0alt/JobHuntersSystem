
namespace UserRanks
{
    partial class frmUserRanks
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
            this.SWtxtDescRank = new SecureCoreInheritedControl.SWTextbox();
            this.SWtxtCodeRank = new SecureCoreInheritedControl.SWTextbox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCodeRank = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTableName
            // 
            this.lblTableName.Location = new System.Drawing.Point(352, 7);
            this.lblTableName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTableName.Size = new System.Drawing.Size(496, 28);
            // 
            // SWtxtDescRank
            // 
            this.SWtxtDescRank.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtDescRank.BackColor = System.Drawing.Color.White;
            this.SWtxtDescRank.ControlID = null;
            this.SWtxtDescRank.DatabaseName = "DescRank";
            this.SWtxtDescRank.IsForeignKey = false;
            this.SWtxtDescRank.Location = new System.Drawing.Point(155, 167);
            this.SWtxtDescRank.MaxLength = 50;
            this.SWtxtDescRank.Name = "SWtxtDescRank";
            this.SWtxtDescRank.NullSpace = true;
            this.SWtxtDescRank.Size = new System.Drawing.Size(193, 21);
            this.SWtxtDescRank.TabIndex = 12;
            // 
            // SWtxtCodeRank
            // 
            this.SWtxtCodeRank.AllowedData = SecureCoreInheritedControl.DataType.Code;
            this.SWtxtCodeRank.BackColor = System.Drawing.Color.White;
            this.SWtxtCodeRank.ControlID = "";
            this.SWtxtCodeRank.DatabaseName = "CodeRank";
            this.SWtxtCodeRank.IsForeignKey = false;
            this.SWtxtCodeRank.Location = new System.Drawing.Point(155, 116);
            this.SWtxtCodeRank.MaxLength = 12;
            this.SWtxtCodeRank.Name = "SWtxtCodeRank";
            this.SWtxtCodeRank.NullSpace = true;
            this.SWtxtCodeRank.Size = new System.Drawing.Size(193, 21);
            this.SWtxtCodeRank.TabIndex = 11;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(49, 167);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(91, 18);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Description";
            // 
            // lblCodeRank
            // 
            this.lblCodeRank.AutoSize = true;
            this.lblCodeRank.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeRank.Location = new System.Drawing.Point(53, 119);
            this.lblCodeRank.Name = "lblCodeRank";
            this.lblCodeRank.Size = new System.Drawing.Size(91, 18);
            this.lblCodeRank.TabIndex = 9;
            this.lblCodeRank.Text = "Code Rank";
            // 
            // frmUserRanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(1201, 729);
            this.Controls.Add(this.SWtxtDescRank);
            this.Controls.Add(this.SWtxtCodeRank);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCodeRank);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.MinimumSize = new System.Drawing.Size(855, 590);
            this.Name = "frmUserRanks";
            this.Controls.SetChildIndex(this.lblCodeRank, 0);
            this.Controls.SetChildIndex(this.lblDescription, 0);
            this.Controls.SetChildIndex(this.SWtxtCodeRank, 0);
            this.Controls.SetChildIndex(this.SWtxtDescRank, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SecureCoreInheritedControl.SWTextbox SWtxtDescRank;
        private SecureCoreInheritedControl.SWTextbox SWtxtCodeRank;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCodeRank;
    }
}
