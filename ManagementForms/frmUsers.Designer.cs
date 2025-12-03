
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
            this.lblUserRank = new System.Windows.Forms.Label();
            this.SWtxtUserRank = new SecureCoreInheritedControl.SWTextbox();
            this.SWcdUserRank = new SWUserControls.SWCodi();
            this.lblPlanet = new System.Windows.Forms.Label();
            this.SWtxtPlanet = new SecureCoreInheritedControl.SWTextbox();
            this.SWcdPlanet = new SWUserControls.SWCodi();
            this.lblSpecie = new System.Windows.Forms.Label();
            this.SWtxtSpecie = new SecureCoreInheritedControl.SWTextbox();
            this.SWcdSpecie = new SWUserControls.SWCodi();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.SWtxtUserName = new SecureCoreInheritedControl.SWTextbox();
            this.SWtxtUserCode = new SecureCoreInheritedControl.SWTextbox();
            this.lblUserCode = new System.Windows.Forms.Label();
            this.SWtxtLogin = new SecureCoreInheritedControl.SWTextbox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTableName
            // 
            this.lblTableName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTableName.Size = new System.Drawing.Size(432, 25);
            // 
            // SWcdUserCategory
            // 
            this.SWcdUserCategory.ClasseCS = null;
            this.SWcdUserCategory.ControlID = "SWtxtUserCategoryId";
            this.SWcdUserCategory.FormCS = null;
            this.SWcdUserCategory.Location = new System.Drawing.Point(168, 186);
            this.SWcdUserCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SWcdUserCategory.Name = "SWcdUserCategory";
            this.SWcdUserCategory.NomCodi = "CodeCategory";
            this.SWcdUserCategory.NomDesc = "DescCategory";
            this.SWcdUserCategory.NomId = "idUserCategory";
            this.SWcdUserCategory.NomTaula = "UserCategories";
            this.SWcdUserCategory.NullSpace = false;
            this.SWcdUserCategory.Size = new System.Drawing.Size(339, 60);
            this.SWcdUserCategory.TabIndex = 4;
            // 
            // SWtxtUserCategoryId
            // 
            this.SWtxtUserCategoryId.AllowedData = SecureCoreInheritedControl.DataType.Number;
            this.SWtxtUserCategoryId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(194)))), ((int)(((byte)(204)))));
            this.SWtxtUserCategoryId.ControlID = "SWcdUserCategory";
            this.SWtxtUserCategoryId.DatabaseName = "idUserCategory";
            this.SWtxtUserCategoryId.IsForeignKey = true;
            this.SWtxtUserCategoryId.Location = new System.Drawing.Point(513, 212);
            this.SWtxtUserCategoryId.Name = "SWtxtUserCategoryId";
            this.SWtxtUserCategoryId.NullSpace = false;
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
            this.UserCategories.Location = new System.Drawing.Point(49, 211);
            this.UserCategories.Name = "UserCategories";
            this.UserCategories.Size = new System.Drawing.Size(113, 18);
            this.UserCategories.TabIndex = 9;
            this.UserCategories.Text = "User Category";
            // 
            // lblUserRank
            // 
            this.lblUserRank.AutoSize = true;
            this.lblUserRank.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRank.Location = new System.Drawing.Point(82, 259);
            this.lblUserRank.Name = "lblUserRank";
            this.lblUserRank.Size = new System.Drawing.Size(80, 18);
            this.lblUserRank.TabIndex = 12;
            this.lblUserRank.Text = "User Rank";
            // 
            // SWtxtUserRank
            // 
            this.SWtxtUserRank.AllowedData = SecureCoreInheritedControl.DataType.Number;
            this.SWtxtUserRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(194)))), ((int)(((byte)(204)))));
            this.SWtxtUserRank.ControlID = "SWcdUserRank";
            this.SWtxtUserRank.DatabaseName = "idUserRank";
            this.SWtxtUserRank.IsForeignKey = true;
            this.SWtxtUserRank.Location = new System.Drawing.Point(513, 259);
            this.SWtxtUserRank.Name = "SWtxtUserRank";
            this.SWtxtUserRank.NullSpace = false;
            this.SWtxtUserRank.Size = new System.Drawing.Size(60, 21);
            this.SWtxtUserRank.TabIndex = 7;
            // 
            // SWcdUserRank
            // 
            this.SWcdUserRank.ClasseCS = "ManagementForms.dll";
            this.SWcdUserRank.ControlID = "SWtxtUserRank";
            this.SWcdUserRank.FormCS = "ManagementForms.frmUsers";
            this.SWcdUserRank.Location = new System.Drawing.Point(167, 233);
            this.SWcdUserRank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SWcdUserRank.Name = "SWcdUserRank";
            this.SWcdUserRank.NomCodi = "CodeRank";
            this.SWcdUserRank.NomDesc = "DescRank";
            this.SWcdUserRank.NomId = "idUserRank";
            this.SWcdUserRank.NomTaula = "UserRanks";
            this.SWcdUserRank.NullSpace = false;
            this.SWcdUserRank.Size = new System.Drawing.Size(340, 74);
            this.SWcdUserRank.TabIndex = 6;
            // 
            // lblPlanet
            // 
            this.lblPlanet.AutoSize = true;
            this.lblPlanet.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanet.Location = new System.Drawing.Point(109, 307);
            this.lblPlanet.Name = "lblPlanet";
            this.lblPlanet.Size = new System.Drawing.Size(53, 18);
            this.lblPlanet.TabIndex = 15;
            this.lblPlanet.Text = "Planet";
            // 
            // SWtxtPlanet
            // 
            this.SWtxtPlanet.AllowedData = SecureCoreInheritedControl.DataType.Number;
            this.SWtxtPlanet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(194)))), ((int)(((byte)(204)))));
            this.SWtxtPlanet.ControlID = "SWcdPlanet";
            this.SWtxtPlanet.DatabaseName = "idPlanet";
            this.SWtxtPlanet.IsForeignKey = true;
            this.SWtxtPlanet.Location = new System.Drawing.Point(513, 307);
            this.SWtxtPlanet.Name = "SWtxtPlanet";
            this.SWtxtPlanet.NullSpace = false;
            this.SWtxtPlanet.Size = new System.Drawing.Size(60, 21);
            this.SWtxtPlanet.TabIndex = 9;
            // 
            // SWcdPlanet
            // 
            this.SWcdPlanet.ClasseCS = null;
            this.SWcdPlanet.ControlID = "SWtxtPlanet";
            this.SWcdPlanet.FormCS = null;
            this.SWcdPlanet.Location = new System.Drawing.Point(168, 280);
            this.SWcdPlanet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SWcdPlanet.Name = "SWcdPlanet";
            this.SWcdPlanet.NomCodi = "CodePlanet";
            this.SWcdPlanet.NomDesc = "DescPlanet";
            this.SWcdPlanet.NomId = "idPlanet";
            this.SWcdPlanet.NomTaula = "Planets";
            this.SWcdPlanet.NullSpace = false;
            this.SWcdPlanet.Size = new System.Drawing.Size(339, 60);
            this.SWcdPlanet.TabIndex = 8;
            // 
            // lblSpecie
            // 
            this.lblSpecie.AutoSize = true;
            this.lblSpecie.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecie.Location = new System.Drawing.Point(600, 74);
            this.lblSpecie.Name = "lblSpecie";
            this.lblSpecie.Size = new System.Drawing.Size(60, 18);
            this.lblSpecie.TabIndex = 18;
            this.lblSpecie.Text = "Specie";
            // 
            // SWtxtSpecie
            // 
            this.SWtxtSpecie.AllowedData = SecureCoreInheritedControl.DataType.Number;
            this.SWtxtSpecie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(194)))), ((int)(((byte)(204)))));
            this.SWtxtSpecie.ControlID = "SWcdSpecie";
            this.SWtxtSpecie.DatabaseName = "idSpecie";
            this.SWtxtSpecie.IsForeignKey = true;
            this.SWtxtSpecie.Location = new System.Drawing.Point(1004, 75);
            this.SWtxtSpecie.Name = "SWtxtSpecie";
            this.SWtxtSpecie.NullSpace = false;
            this.SWtxtSpecie.Size = new System.Drawing.Size(60, 21);
            this.SWtxtSpecie.TabIndex = 11;
            // 
            // SWcdSpecie
            // 
            this.SWcdSpecie.ClasseCS = null;
            this.SWcdSpecie.ControlID = "SWtxtSpecie";
            this.SWcdSpecie.FormCS = null;
            this.SWcdSpecie.Location = new System.Drawing.Point(657, 49);
            this.SWcdSpecie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SWcdSpecie.Name = "SWcdSpecie";
            this.SWcdSpecie.NomCodi = "CodeSpecie";
            this.SWcdSpecie.NomDesc = "DescSpecie";
            this.SWcdSpecie.NomId = "idSpecie";
            this.SWcdSpecie.NomTaula = "Species";
            this.SWcdSpecie.NullSpace = false;
            this.SWcdSpecie.Size = new System.Drawing.Size(340, 78);
            this.SWcdSpecie.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(1389, 32);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 0);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(72, 70);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(88, 18);
            this.lblUserName.TabIndex = 20;
            this.lblUserName.Text = "User Name";
            // 
            // SWtxtUserName
            // 
            this.SWtxtUserName.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtUserName.BackColor = System.Drawing.SystemColors.Window;
            this.SWtxtUserName.ControlID = null;
            this.SWtxtUserName.DatabaseName = "UserName";
            this.SWtxtUserName.IsForeignKey = false;
            this.SWtxtUserName.Location = new System.Drawing.Point(174, 70);
            this.SWtxtUserName.Name = "SWtxtUserName";
            this.SWtxtUserName.NullSpace = true;
            this.SWtxtUserName.Size = new System.Drawing.Size(171, 21);
            this.SWtxtUserName.TabIndex = 1;
            // 
            // SWtxtUserCode
            // 
            this.SWtxtUserCode.AllowedData = SecureCoreInheritedControl.DataType.Code;
            this.SWtxtUserCode.ControlID = null;
            this.SWtxtUserCode.DatabaseName = "CodeUser";
            this.SWtxtUserCode.IsForeignKey = false;
            this.SWtxtUserCode.Location = new System.Drawing.Point(174, 118);
            this.SWtxtUserCode.Name = "SWtxtUserCode";
            this.SWtxtUserCode.NullSpace = true;
            this.SWtxtUserCode.Size = new System.Drawing.Size(171, 21);
            this.SWtxtUserCode.TabIndex = 2;
            // 
            // lblUserCode
            // 
            this.lblUserCode.AutoSize = true;
            this.lblUserCode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCode.Location = new System.Drawing.Point(72, 118);
            this.lblUserCode.Name = "lblUserCode";
            this.lblUserCode.Size = new System.Drawing.Size(85, 18);
            this.lblUserCode.TabIndex = 22;
            this.lblUserCode.Text = "User Code";
            // 
            // SWtxtLogin
            // 
            this.SWtxtLogin.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(194)))), ((int)(((byte)(204)))));
            this.SWtxtLogin.ControlID = null;
            this.SWtxtLogin.DatabaseName = "Login";
            this.SWtxtLogin.IsForeignKey = false;
            this.SWtxtLogin.Location = new System.Drawing.Point(174, 166);
            this.SWtxtLogin.Name = "SWtxtLogin";
            this.SWtxtLogin.NullSpace = false;
            this.SWtxtLogin.Size = new System.Drawing.Size(171, 21);
            this.SWtxtLogin.TabIndex = 3;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(109, 166);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(48, 18);
            this.lblLogin.TabIndex = 24;
            this.lblLogin.Text = "Login";
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(1201, 729);
            this.Controls.Add(this.SWtxtLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.SWtxtUserCode);
            this.Controls.Add(this.lblUserCode);
            this.Controls.Add(this.SWtxtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.SWcdPlanet);
            this.Controls.Add(this.lblSpecie);
            this.Controls.Add(this.SWtxtSpecie);
            this.Controls.Add(this.SWcdSpecie);
            this.Controls.Add(this.lblPlanet);
            this.Controls.Add(this.SWtxtPlanet);
            this.Controls.Add(this.lblUserRank);
            this.Controls.Add(this.SWtxtUserRank);
            this.Controls.Add(this.SWcdUserRank);
            this.Controls.Add(this.UserCategories);
            this.Controls.Add(this.lblUserCategory);
            this.Controls.Add(this.SWtxtUserCategoryId);
            this.Controls.Add(this.SWcdUserCategory);
            this.MinimumSize = new System.Drawing.Size(782, 558);
            this.Name = "frmUsers";
            this.Controls.SetChildIndex(this.SWcdUserCategory, 0);
            this.Controls.SetChildIndex(this.SWtxtUserCategoryId, 0);
            this.Controls.SetChildIndex(this.lblUserCategory, 0);
            this.Controls.SetChildIndex(this.UserCategories, 0);
            this.Controls.SetChildIndex(this.SWcdUserRank, 0);
            this.Controls.SetChildIndex(this.SWtxtUserRank, 0);
            this.Controls.SetChildIndex(this.lblUserRank, 0);
            this.Controls.SetChildIndex(this.SWtxtPlanet, 0);
            this.Controls.SetChildIndex(this.lblPlanet, 0);
            this.Controls.SetChildIndex(this.SWcdSpecie, 0);
            this.Controls.SetChildIndex(this.SWtxtSpecie, 0);
            this.Controls.SetChildIndex(this.lblSpecie, 0);
            this.Controls.SetChildIndex(this.SWcdPlanet, 0);
            this.Controls.SetChildIndex(this.lblUserName, 0);
            this.Controls.SetChildIndex(this.SWtxtUserName, 0);
            this.Controls.SetChildIndex(this.lblUserCode, 0);
            this.Controls.SetChildIndex(this.SWtxtUserCode, 0);
            this.Controls.SetChildIndex(this.lblLogin, 0);
            this.Controls.SetChildIndex(this.SWtxtLogin, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SWUserControls.SWCodi SWcdUserCategory;
        private SecureCoreInheritedControl.SWTextbox SWtxtUserCategoryId;
        private System.Windows.Forms.Label lblUserCategory;
        private System.Windows.Forms.Label UserCategories;
        private System.Windows.Forms.Label lblUserRank;
        private SecureCoreInheritedControl.SWTextbox SWtxtUserRank;
        private SWUserControls.SWCodi SWcdUserRank;
        private System.Windows.Forms.Label lblPlanet;
        private SecureCoreInheritedControl.SWTextbox SWtxtPlanet;
        private SWUserControls.SWCodi SWcdPlanet;
        private System.Windows.Forms.Label lblSpecie;
        private SecureCoreInheritedControl.SWTextbox SWtxtSpecie;
        private SWUserControls.SWCodi SWcdSpecie;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblUserName;
        private SecureCoreInheritedControl.SWTextbox SWtxtUserName;
        private SecureCoreInheritedControl.SWTextbox SWtxtUserCode;
        private System.Windows.Forms.Label lblUserCode;
        private SecureCoreInheritedControl.SWTextbox SWtxtLogin;
        private System.Windows.Forms.Label lblLogin;
    }
}
