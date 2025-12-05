
namespace SpaceShipCategories
{
    partial class frmSpaceShipCategoriesScreenCS
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
            this.SWtxtSpaceShipCategories = new SecureCoreInheritedControl.SWTextbox();
            this.SWtxtDescCategory = new SecureCoreInheritedControl.SWTextbox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SWtxtSpaceShipCategories
            // 
            this.SWtxtSpaceShipCategories.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtSpaceShipCategories.ControlID = null;
            this.SWtxtSpaceShipCategories.DatabaseName = "CodeSpaceShipCategory";
            this.SWtxtSpaceShipCategories.IsForeignKey = false;
            this.SWtxtSpaceShipCategories.Location = new System.Drawing.Point(192, 97);
            this.SWtxtSpaceShipCategories.Name = "SWtxtSpaceShipCategories";
            this.SWtxtSpaceShipCategories.NullSpace = true;
            this.SWtxtSpaceShipCategories.Size = new System.Drawing.Size(162, 20);
            this.SWtxtSpaceShipCategories.TabIndex = 32;
            // 
            // SWtxtDescCategory
            // 
            this.SWtxtDescCategory.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtDescCategory.ControlID = null;
            this.SWtxtDescCategory.DatabaseName = "DescSpaceShipCategory";
            this.SWtxtDescCategory.IsForeignKey = false;
            this.SWtxtDescCategory.Location = new System.Drawing.Point(192, 144);
            this.SWtxtDescCategory.Name = "SWtxtDescCategory";
            this.SWtxtDescCategory.NullSpace = true;
            this.SWtxtDescCategory.Size = new System.Drawing.Size(162, 20);
            this.SWtxtDescCategory.TabIndex = 33;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(57, 97);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(125, 20);
            this.lblCode.TabIndex = 34;
            this.lblCode.Text = "Code Category";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(74, 142);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(91, 20);
            this.lblDesc.TabIndex = 35;
            this.lblDesc.Text = "Description";
            // 
            // frmSpaceShipCategoriesScreenCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(842, 584);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.SWtxtDescCategory);
            this.Controls.Add(this.SWtxtSpaceShipCategories);
            this.Name = "frmSpaceShipCategoriesScreenCS";
            this.Controls.SetChildIndex(this.SWtxtSpaceShipCategories, 0);
            this.Controls.SetChildIndex(this.SWtxtDescCategory, 0);
            this.Controls.SetChildIndex(this.lblCode, 0);
            this.Controls.SetChildIndex(this.lblDesc, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SecureCoreInheritedControl.SWTextbox SWtxtSpaceShipCategories;
        private SecureCoreInheritedControl.SWTextbox SWtxtDescCategory;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblDesc;
    }
}
