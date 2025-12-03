
namespace ManagementForms
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
            this.lblTableName.Size = new System.Drawing.Size(5620, 25);
            // 
            // SWtxtDescRank
            // 
            this.SWtxtDescRank.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtDescRank.ControlID = null;
            this.SWtxtDescRank.DatabaseName = "DescRank";
            this.SWtxtDescRank.IsForeignKey = false;
            this.SWtxtDescRank.Location = new System.Drawing.Point(221, 219);
            this.SWtxtDescRank.Margin = new System.Windows.Forms.Padding(4);
            this.SWtxtDescRank.Name = "SWtxtDescRank";
            this.SWtxtDescRank.NullSpace = true;
            this.SWtxtDescRank.Size = new System.Drawing.Size(274, 28);
            this.SWtxtDescRank.TabIndex = 12;
            // 
            // SWtxtCodeRank
            // 
            this.SWtxtCodeRank.AllowedData = SecureCoreInheritedControl.DataType.Code;
            this.SWtxtCodeRank.ControlID = "";
            this.SWtxtCodeRank.DatabaseName = "CodeRank";
            this.SWtxtCodeRank.IsForeignKey = false;
            this.SWtxtCodeRank.Location = new System.Drawing.Point(221, 152);
            this.SWtxtCodeRank.Margin = new System.Windows.Forms.Padding(4);
            this.SWtxtCodeRank.Name = "SWtxtCodeRank";
            this.SWtxtCodeRank.NullSpace = true;
            this.SWtxtCodeRank.Size = new System.Drawing.Size(274, 28);
            this.SWtxtCodeRank.TabIndex = 11;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(70, 219);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(138, 27);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Description";
            // 
            // lblCodeRank
            // 
            this.lblCodeRank.AutoSize = true;
            this.lblCodeRank.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeRank.Location = new System.Drawing.Point(76, 156);
            this.lblCodeRank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodeRank.Name = "lblCodeRank";
            this.lblCodeRank.Size = new System.Drawing.Size(136, 27);
            this.lblCodeRank.TabIndex = 9;
            this.lblCodeRank.Text = "Code Rank";
            // 
            // frmUserRanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.ClientSize = new System.Drawing.Size(1716, 957);
            this.Controls.Add(this.SWtxtDescRank);
            this.Controls.Add(this.SWtxtCodeRank);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCodeRank);
            this.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.MinimumSize = new System.Drawing.Size(1215, 762);
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
