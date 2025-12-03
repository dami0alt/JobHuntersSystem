
namespace MenuOption
{
    partial class frmMenuOptions
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
            this.SWtxtPicturePathMain = new SecureCoreInheritedControl.SWTextbox();
            this.SWtxtFormName = new SecureCoreInheritedControl.SWTextbox();
            this.SWtxtdllName = new SecureCoreInheritedControl.SWTextbox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblCodeUser = new System.Windows.Forms.Label();
            this.SWtxtPicturePathHover = new SecureCoreInheritedControl.SWTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.SWtxtFontColorHover = new SecureCoreInheritedControl.SWTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.SWtxtFontColorMain = new SecureCoreInheritedControl.SWTextbox();
            this.SWtxtBackColorHover = new SecureCoreInheritedControl.SWTextbox();
            this.SWtxtBackColorMain = new SecureCoreInheritedControl.SWTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SWtxtDescription = new SecureCoreInheritedControl.SWTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.SWtxtAccesLevel = new SecureCoreInheritedControl.SWTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.isIcon = new ImageSelector.ImageSelector();
            this.SuspendLayout();
            // 
            // lblTableName
            // 
            this.lblTableName.Size = new System.Drawing.Size(1592, 21);
            // 
            // SWtxtPicturePathMain
            // 
            this.SWtxtPicturePathMain.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtPicturePathMain.ControlID = null;
            this.SWtxtPicturePathMain.DatabaseName = "PicturePathMain";
            this.SWtxtPicturePathMain.IsForeignKey = false;
            this.SWtxtPicturePathMain.Location = new System.Drawing.Point(207, 323);
            this.SWtxtPicturePathMain.Name = "SWtxtPicturePathMain";
            this.SWtxtPicturePathMain.NullSpace = true;
            this.SWtxtPicturePathMain.Size = new System.Drawing.Size(456, 21);
            this.SWtxtPicturePathMain.TabIndex = 15;
            this.SWtxtPicturePathMain.TextChanged += new System.EventHandler(this.SWtxtPicturePathMain_TextChanged);
            // 
            // SWtxtFormName
            // 
            this.SWtxtFormName.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtFormName.ControlID = null;
            this.SWtxtFormName.DatabaseName = "FormName";
            this.SWtxtFormName.IsForeignKey = false;
            this.SWtxtFormName.Location = new System.Drawing.Point(207, 118);
            this.SWtxtFormName.Name = "SWtxtFormName";
            this.SWtxtFormName.NullSpace = true;
            this.SWtxtFormName.Size = new System.Drawing.Size(496, 21);
            this.SWtxtFormName.TabIndex = 14;
            // 
            // SWtxtdllName
            // 
            this.SWtxtdllName.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtdllName.ControlID = null;
            this.SWtxtdllName.DatabaseName = "dllName";
            this.SWtxtdllName.IsForeignKey = false;
            this.SWtxtdllName.Location = new System.Drawing.Point(207, 67);
            this.SWtxtdllName.Name = "SWtxtdllName";
            this.SWtxtdllName.NullSpace = true;
            this.SWtxtdllName.Size = new System.Drawing.Size(496, 21);
            this.SWtxtdllName.TabIndex = 13;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Enabled = false;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(77, 323);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(117, 18);
            this.lblLogin.TabIndex = 12;
            this.lblLogin.Text = "Main Icon Path";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(103, 119);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(93, 18);
            this.lblUserName.TabIndex = 11;
            this.lblUserName.Text = "Form Name";
            // 
            // lblCodeUser
            // 
            this.lblCodeUser.AutoSize = true;
            this.lblCodeUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeUser.Location = new System.Drawing.Point(117, 68);
            this.lblCodeUser.Name = "lblCodeUser";
            this.lblCodeUser.Size = new System.Drawing.Size(82, 18);
            this.lblCodeUser.TabIndex = 10;
            this.lblCodeUser.Text = "DLL Name";
            // 
            // SWtxtPicturePathHover
            // 
            this.SWtxtPicturePathHover.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtPicturePathHover.ControlID = null;
            this.SWtxtPicturePathHover.DatabaseName = "PicturePathHover";
            this.SWtxtPicturePathHover.IsForeignKey = false;
            this.SWtxtPicturePathHover.Location = new System.Drawing.Point(207, 168);
            this.SWtxtPicturePathHover.Name = "SWtxtPicturePathHover";
            this.SWtxtPicturePathHover.NullSpace = true;
            this.SWtxtPicturePathHover.Size = new System.Drawing.Size(496, 21);
            this.SWtxtPicturePathHover.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Hover Icon Path";
            // 
            // SWtxtFontColorHover
            // 
            this.SWtxtFontColorHover.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtFontColorHover.ControlID = null;
            this.SWtxtFontColorHover.DatabaseName = "FontColorHover";
            this.SWtxtFontColorHover.IsForeignKey = false;
            this.SWtxtFontColorHover.Location = new System.Drawing.Point(872, 217);
            this.SWtxtFontColorHover.Name = "SWtxtFontColorHover";
            this.SWtxtFontColorHover.NullSpace = true;
            this.SWtxtFontColorHover.Size = new System.Drawing.Size(117, 21);
            this.SWtxtFontColorHover.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(724, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Hover Font Color";
            // 
            // SWtxtFontColorMain
            // 
            this.SWtxtFontColorMain.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtFontColorMain.ControlID = null;
            this.SWtxtFontColorMain.DatabaseName = "FontColorMain";
            this.SWtxtFontColorMain.IsForeignKey = false;
            this.SWtxtFontColorMain.Location = new System.Drawing.Point(872, 168);
            this.SWtxtFontColorMain.Name = "SWtxtFontColorMain";
            this.SWtxtFontColorMain.NullSpace = true;
            this.SWtxtFontColorMain.Size = new System.Drawing.Size(117, 21);
            this.SWtxtFontColorMain.TabIndex = 25;
            // 
            // SWtxtBackColorHover
            // 
            this.SWtxtBackColorHover.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtBackColorHover.ControlID = null;
            this.SWtxtBackColorHover.DatabaseName = "BackColorHover";
            this.SWtxtBackColorHover.IsForeignKey = false;
            this.SWtxtBackColorHover.Location = new System.Drawing.Point(872, 115);
            this.SWtxtBackColorHover.Name = "SWtxtBackColorHover";
            this.SWtxtBackColorHover.NullSpace = true;
            this.SWtxtBackColorHover.Size = new System.Drawing.Size(117, 21);
            this.SWtxtBackColorHover.TabIndex = 24;
            // 
            // SWtxtBackColorMain
            // 
            this.SWtxtBackColorMain.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtBackColorMain.ControlID = null;
            this.SWtxtBackColorMain.DatabaseName = "BackColorMain";
            this.SWtxtBackColorMain.IsForeignKey = false;
            this.SWtxtBackColorMain.Location = new System.Drawing.Point(872, 65);
            this.SWtxtBackColorMain.Name = "SWtxtBackColorMain";
            this.SWtxtBackColorMain.NullSpace = true;
            this.SWtxtBackColorMain.Size = new System.Drawing.Size(117, 21);
            this.SWtxtBackColorMain.TabIndex = 23;
            this.SWtxtBackColorMain.Validating += new System.ComponentModel.CancelEventHandler(this.SWtxtBackColorMain_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(774, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Font Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(746, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Hover B.Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(797, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "B.Color";
            // 
            // SWtxtDescription
            // 
            this.SWtxtDescription.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtDescription.ControlID = null;
            this.SWtxtDescription.DatabaseName = "Description";
            this.SWtxtDescription.IsForeignKey = false;
            this.SWtxtDescription.Location = new System.Drawing.Point(207, 219);
            this.SWtxtDescription.Name = "SWtxtDescription";
            this.SWtxtDescription.NullSpace = true;
            this.SWtxtDescription.Size = new System.Drawing.Size(496, 21);
            this.SWtxtDescription.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "Description";
            // 
            // SWtxtAccesLevel
            // 
            this.SWtxtAccesLevel.AllowedData = SecureCoreInheritedControl.DataType.Number;
            this.SWtxtAccesLevel.ControlID = null;
            this.SWtxtAccesLevel.DatabaseName = "AccesLevel";
            this.SWtxtAccesLevel.IsForeignKey = false;
            this.SWtxtAccesLevel.Location = new System.Drawing.Point(207, 273);
            this.SWtxtAccesLevel.Name = "SWtxtAccesLevel";
            this.SWtxtAccesLevel.NullSpace = true;
            this.SWtxtAccesLevel.Size = new System.Drawing.Size(117, 21);
            this.SWtxtAccesLevel.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 18);
            this.label7.TabIndex = 30;
            this.label7.Text = "Access Level";
            // 
            // isIcon
            // 
            this.isIcon.CtrlName = "SWtxtPicturePathMain";
            this.isIcon.DestinationPath = "Multimedia/png/";
            this.isIcon.ImagePath = null;
            this.isIcon.Location = new System.Drawing.Point(695, 248);
            this.isIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isIcon.Name = "isIcon";
            this.isIcon.Size = new System.Drawing.Size(294, 100);
            this.isIcon.TabIndex = 32;
            // 
            // frmMenuOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(1201, 729);
            this.Controls.Add(this.isIcon);
            this.Controls.Add(this.SWtxtAccesLevel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SWtxtDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SWtxtFontColorHover);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SWtxtFontColorMain);
            this.Controls.Add(this.SWtxtBackColorHover);
            this.Controls.Add(this.SWtxtBackColorMain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SWtxtPicturePathHover);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SWtxtPicturePathMain);
            this.Controls.Add(this.SWtxtFormName);
            this.Controls.Add(this.SWtxtdllName);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblCodeUser);
            this.MinimumSize = new System.Drawing.Size(1067, 652);
            this.Name = "frmMenuOptions";
            this.Controls.SetChildIndex(this.lblCodeUser, 0);
            this.Controls.SetChildIndex(this.lblUserName, 0);
            this.Controls.SetChildIndex(this.lblLogin, 0);
            this.Controls.SetChildIndex(this.SWtxtdllName, 0);
            this.Controls.SetChildIndex(this.SWtxtFormName, 0);
            this.Controls.SetChildIndex(this.SWtxtPicturePathMain, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.SWtxtPicturePathHover, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.SWtxtBackColorMain, 0);
            this.Controls.SetChildIndex(this.SWtxtBackColorHover, 0);
            this.Controls.SetChildIndex(this.SWtxtFontColorMain, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.SWtxtFontColorHover, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.SWtxtDescription, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.SWtxtAccesLevel, 0);
            this.Controls.SetChildIndex(this.isIcon, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SecureCoreInheritedControl.SWTextbox SWtxtPicturePathMain;
        private SecureCoreInheritedControl.SWTextbox SWtxtFormName;
        private SecureCoreInheritedControl.SWTextbox SWtxtdllName;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblCodeUser;
        private SecureCoreInheritedControl.SWTextbox SWtxtPicturePathHover;
        private System.Windows.Forms.Label label3;
        private SecureCoreInheritedControl.SWTextbox SWtxtFontColorHover;
        private System.Windows.Forms.Label label1;
        private SecureCoreInheritedControl.SWTextbox SWtxtFontColorMain;
        private SecureCoreInheritedControl.SWTextbox SWtxtBackColorHover;
        private SecureCoreInheritedControl.SWTextbox SWtxtBackColorMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private SecureCoreInheritedControl.SWTextbox SWtxtDescription;
        private System.Windows.Forms.Label label6;
        private SecureCoreInheritedControl.SWTextbox SWtxtAccesLevel;
        private System.Windows.Forms.Label label7;
        private ImageSelector.ImageSelector isIcon;
    }
}
