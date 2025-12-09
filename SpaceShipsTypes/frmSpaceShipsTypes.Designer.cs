
namespace SpaceShipsTypes
{
    partial class frmSpaceShipsTypes
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
            this.SWtxtDescType = new SecureCoreInheritedControl.SWTextbox();
            this.lblDescType = new System.Windows.Forms.Label();
            this.SWtxtTypeCode = new SecureCoreInheritedControl.SWTextbox();
            this.lblSpaceShipTypeCode = new System.Windows.Forms.Label();
            this.lblCodeCategory = new System.Windows.Forms.Label();
            this.SWtxtSpaceShipCategories = new SecureCoreInheritedControl.SWTextbox();
            this.SWcdCodeCategory = new SWUserControls.SWCodi();
            this.lblCodeFiliation = new System.Windows.Forms.Label();
            this.SWtxtidFiliation = new SecureCoreInheritedControl.SWTextbox();
            this.SWcdFiliationCode = new SWUserControls.SWCodi();
            this.SuspendLayout();
            // 
            // lblTableName
            // 
            this.lblTableName.Location = new System.Drawing.Point(2, 7);
            this.lblTableName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTableName.Size = new System.Drawing.Size(1194, 26);
            // 
            // SWtxtDescType
            // 
            this.SWtxtDescType.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtDescType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(194)))), ((int)(((byte)(204)))));
            this.SWtxtDescType.ControlID = null;
            this.SWtxtDescType.DatabaseName = "DescSpaceShipType";
            this.SWtxtDescType.IsForeignKey = false;
            this.SWtxtDescType.Location = new System.Drawing.Point(221, 122);
            this.SWtxtDescType.Name = "SWtxtDescType";
            this.SWtxtDescType.NullSpace = true;
            this.SWtxtDescType.Size = new System.Drawing.Size(171, 21);
            this.SWtxtDescType.TabIndex = 30;
            // 
            // lblDescType
            // 
            this.lblDescType.AutoSize = true;
            this.lblDescType.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescType.Location = new System.Drawing.Point(76, 122);
            this.lblDescType.Name = "lblDescType";
            this.lblDescType.Size = new System.Drawing.Size(130, 18);
            this.lblDescType.TabIndex = 45;
            this.lblDescType.Text = "Type Description";
            // 
            // SWtxtTypeCode
            // 
            this.SWtxtTypeCode.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtTypeCode.ControlID = null;
            this.SWtxtTypeCode.DatabaseName = "CodeSpaceShipType";
            this.SWtxtTypeCode.IsForeignKey = false;
            this.SWtxtTypeCode.Location = new System.Drawing.Point(221, 78);
            this.SWtxtTypeCode.Name = "SWtxtTypeCode";
            this.SWtxtTypeCode.NullSpace = true;
            this.SWtxtTypeCode.Size = new System.Drawing.Size(171, 21);
            this.SWtxtTypeCode.TabIndex = 29;
            // 
            // lblSpaceShipTypeCode
            // 
            this.lblSpaceShipTypeCode.AutoSize = true;
            this.lblSpaceShipTypeCode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpaceShipTypeCode.Location = new System.Drawing.Point(30, 78);
            this.lblSpaceShipTypeCode.Name = "lblSpaceShipTypeCode";
            this.lblSpaceShipTypeCode.Size = new System.Drawing.Size(176, 18);
            this.lblSpaceShipTypeCode.TabIndex = 43;
            this.lblSpaceShipTypeCode.Text = "Space Ship Type Code";
            // 
            // lblCodeCategory
            // 
            this.lblCodeCategory.AutoSize = true;
            this.lblCodeCategory.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeCategory.Location = new System.Drawing.Point(128, 213);
            this.lblCodeCategory.Name = "lblCodeCategory";
            this.lblCodeCategory.Size = new System.Drawing.Size(78, 18);
            this.lblCodeCategory.TabIndex = 40;
            this.lblCodeCategory.Text = "Category";
            // 
            // SWtxtSpaceShipCategories
            // 
            this.SWtxtSpaceShipCategories.AllowedData = SecureCoreInheritedControl.DataType.Number;
            this.SWtxtSpaceShipCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(194)))), ((int)(((byte)(204)))));
            this.SWtxtSpaceShipCategories.ControlID = "SWcdCodeCategory";
            this.SWtxtSpaceShipCategories.DatabaseName = "idSpaceShipCategory";
            this.SWtxtSpaceShipCategories.Enabled = false;
            this.SWtxtSpaceShipCategories.IsForeignKey = true;
            this.SWtxtSpaceShipCategories.Location = new System.Drawing.Point(559, 213);
            this.SWtxtSpaceShipCategories.Name = "SWtxtSpaceShipCategories";
            this.SWtxtSpaceShipCategories.NullSpace = false;
            this.SWtxtSpaceShipCategories.Size = new System.Drawing.Size(60, 21);
            this.SWtxtSpaceShipCategories.TabIndex = 34;
            this.SWtxtSpaceShipCategories.TabStop = false;
            // 
            // SWcdCodeCategory
            // 
            this.SWcdCodeCategory.ClasseCS = "SpaceShipCategories.dll";
            this.SWcdCodeCategory.ControlID = "SWcdCodeCategoryId";
            this.SWcdCodeCategory.FormCS = "SpaceShipCategories.frmSpaceShipCategoriesScreenCS";
            this.SWcdCodeCategory.Location = new System.Drawing.Point(213, 187);
            this.SWcdCodeCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SWcdCodeCategory.Name = "SWcdCodeCategory";
            this.SWcdCodeCategory.NomCodi = "CodeSpaceShipCategory";
            this.SWcdCodeCategory.NomDesc = "DescSpaceShipCategory";
            this.SWcdCodeCategory.NomId = "idSpaceShipCategory";
            this.SWcdCodeCategory.NomTaula = "SpaceShipCategories";
            this.SWcdCodeCategory.NullSpace = false;
            this.SWcdCodeCategory.Size = new System.Drawing.Size(340, 74);
            this.SWcdCodeCategory.TabIndex = 33;
            // 
            // lblCodeFiliation
            // 
            this.lblCodeFiliation.AutoSize = true;
            this.lblCodeFiliation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeFiliation.Location = new System.Drawing.Point(142, 166);
            this.lblCodeFiliation.Name = "lblCodeFiliation";
            this.lblCodeFiliation.Size = new System.Drawing.Size(64, 18);
            this.lblCodeFiliation.TabIndex = 36;
            this.lblCodeFiliation.Text = "Filiation";
            // 
            // SWtxtidFiliation
            // 
            this.SWtxtidFiliation.AllowedData = SecureCoreInheritedControl.DataType.Number;
            this.SWtxtidFiliation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(194)))), ((int)(((byte)(204)))));
            this.SWtxtidFiliation.ControlID = "SWcdFiliationCode";
            this.SWtxtidFiliation.DatabaseName = "idFiliation";
            this.SWtxtidFiliation.IsForeignKey = true;
            this.SWtxtidFiliation.Location = new System.Drawing.Point(559, 166);
            this.SWtxtidFiliation.Name = "SWtxtidFiliation";
            this.SWtxtidFiliation.NullSpace = false;
            this.SWtxtidFiliation.ShortcutsEnabled = false;
            this.SWtxtidFiliation.Size = new System.Drawing.Size(60, 21);
            this.SWtxtidFiliation.TabIndex = 32;
            this.SWtxtidFiliation.TabStop = false;
            // 
            // SWcdFiliationCode
            // 
            this.SWcdFiliationCode.ClasseCS = "Filiations.dll";
            this.SWcdFiliationCode.ControlID = "SWtxtidFiliation";
            this.SWcdFiliationCode.FormCS = "Filiations.frmFiliationsScreenCS";
            this.SWcdFiliationCode.Location = new System.Drawing.Point(214, 140);
            this.SWcdFiliationCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SWcdFiliationCode.Name = "SWcdFiliationCode";
            this.SWcdFiliationCode.NomCodi = "CodeFiliation";
            this.SWcdFiliationCode.NomDesc = "DescFiliations";
            this.SWcdFiliationCode.NomId = "idFiliation";
            this.SWcdFiliationCode.NomTaula = "Filiations";
            this.SWcdFiliationCode.NullSpace = false;
            this.SWcdFiliationCode.Size = new System.Drawing.Size(339, 60);
            this.SWcdFiliationCode.TabIndex = 31;
            // 
            // frmSpaceShipsTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(1201, 729);
            this.Controls.Add(this.SWtxtDescType);
            this.Controls.Add(this.lblDescType);
            this.Controls.Add(this.SWtxtTypeCode);
            this.Controls.Add(this.lblSpaceShipTypeCode);
            this.Controls.Add(this.lblCodeCategory);
            this.Controls.Add(this.SWtxtSpaceShipCategories);
            this.Controls.Add(this.SWcdCodeCategory);
            this.Controls.Add(this.lblCodeFiliation);
            this.Controls.Add(this.SWtxtidFiliation);
            this.Controls.Add(this.SWcdFiliationCode);
            this.MinimumSize = new System.Drawing.Size(1198, 739);
            this.Name = "frmSpaceShipsTypes";
            this.Controls.SetChildIndex(this.SWcdFiliationCode, 0);
            this.Controls.SetChildIndex(this.SWtxtidFiliation, 0);
            this.Controls.SetChildIndex(this.lblCodeFiliation, 0);
            this.Controls.SetChildIndex(this.SWcdCodeCategory, 0);
            this.Controls.SetChildIndex(this.SWtxtSpaceShipCategories, 0);
            this.Controls.SetChildIndex(this.lblCodeCategory, 0);
            this.Controls.SetChildIndex(this.lblSpaceShipTypeCode, 0);
            this.Controls.SetChildIndex(this.SWtxtTypeCode, 0);
            this.Controls.SetChildIndex(this.lblDescType, 0);
            this.Controls.SetChildIndex(this.SWtxtDescType, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SecureCoreInheritedControl.SWTextbox SWtxtDescType;
        private System.Windows.Forms.Label lblDescType;
        private SecureCoreInheritedControl.SWTextbox SWtxtTypeCode;
        private System.Windows.Forms.Label lblSpaceShipTypeCode;
        private System.Windows.Forms.Label lblCodeCategory;
        private SecureCoreInheritedControl.SWTextbox SWtxtSpaceShipCategories;
        private SWUserControls.SWCodi SWcdCodeCategory;
        private System.Windows.Forms.Label lblCodeFiliation;
        private SecureCoreInheritedControl.SWTextbox SWtxtidFiliation;
        private SWUserControls.SWCodi SWcdFiliationCode;
    }
}
