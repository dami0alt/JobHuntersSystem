
namespace ManagementForms
{
    partial class frmUsers
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
            this.SWcdUserCategory = new SWUserControls.SWCodi();
            this.SWtxtUserCategoryId = new SecureCoreInheritedControl.SWTextbox();
            this.lblUserCategory = new System.Windows.Forms.Label();
            this.UserCategories = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SWcdUserCategory
            // 
            this.SWcdUserCategory.ControlID = "SWtxtUserCategoryId";
            this.SWcdUserCategory.Location = new System.Drawing.Point(180, 96);
            this.SWcdUserCategory.Name = "SWcdUserCategory";
            this.SWcdUserCategory.NomCodi = "CodeCategory";
            this.SWcdUserCategory.NomDesc = "DescCategory";
            this.SWcdUserCategory.NomId = "idUserCategory";
            this.SWcdUserCategory.NomTaula = "UserCategories";
            this.SWcdUserCategory.Size = new System.Drawing.Size(321, 62);
            this.SWcdUserCategory.TabIndex = 4;
            // 
            // SWtxtUserCategoryId
            // 
            this.SWtxtUserCategoryId.AllowedData = SecureCoreInheritedControl.DataType.Number;
            this.SWtxtUserCategoryId.ControlID = "SWcdUserCategory";
            this.SWtxtUserCategoryId.DatabaseName = "idUserCategory";
            this.SWtxtUserCategoryId.IsForeignKey = true;
            this.SWtxtUserCategoryId.Location = new System.Drawing.Point(517, 123);
            this.SWtxtUserCategoryId.Name = "SWtxtUserCategoryId";
            this.SWtxtUserCategoryId.NullSpace = true;
            this.SWtxtUserCategoryId.Size = new System.Drawing.Size(60, 21);
            this.SWtxtUserCategoryId.TabIndex = 5;
            // 
            // lblUserCategory
            // 
            this.lblUserCategory.AutoSize = true;
            this.lblUserCategory.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCategory.Location = new System.Drawing.Point(47, 123);
            this.lblUserCategory.Name = "lblUserCategory";
            this.lblUserCategory.Size = new System.Drawing.Size(0, 15);
            this.lblUserCategory.TabIndex = 6;
            // 
            // UserCategories
            // 
            this.UserCategories.AutoSize = true;
            this.UserCategories.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserCategories.Location = new System.Drawing.Point(53, 121);
            this.UserCategories.Name = "UserCategories";
            this.UserCategories.Size = new System.Drawing.Size(113, 18);
            this.UserCategories.TabIndex = 9;
            this.UserCategories.Text = "User Category";
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(1201, 729);
            this.Controls.Add(this.UserCategories);
            this.Controls.Add(this.lblUserCategory);
            this.Controls.Add(this.SWtxtUserCategoryId);
            this.Controls.Add(this.SWcdUserCategory);
            this.Name = "frmUsers";
            this.Controls.SetChildIndex(this.SWcdUserCategory, 0);
            this.Controls.SetChildIndex(this.SWtxtUserCategoryId, 0);
            this.Controls.SetChildIndex(this.lblUserCategory, 0);
            this.Controls.SetChildIndex(this.UserCategories, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SWUserControls.SWCodi SWcdUserCategory;
        private SecureCoreInheritedControl.SWTextbox SWtxtUserCategoryId;
        private System.Windows.Forms.Label lblUserCategory;
        private System.Windows.Forms.Label UserCategories;
    }
}
