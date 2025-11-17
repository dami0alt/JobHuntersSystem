
namespace ManagementForms
{
    partial class frmUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodeUser = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.SWtxtCodeUser = new SecureCoreInheritedControl.SWTextbox();
            this.SWtxtUserName = new SecureCoreInheritedControl.SWTextbox();
            this.SWtxtLogin = new SecureCoreInheritedControl.SWTextbox();
            this.SuspendLayout();
            // 
            // lblCodeUser
            // 
            this.lblCodeUser.AutoSize = true;
            this.lblCodeUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeUser.Location = new System.Drawing.Point(53, 119);
            this.lblCodeUser.Name = "lblCodeUser";
            this.lblCodeUser.Size = new System.Drawing.Size(85, 18);
            this.lblCodeUser.TabIndex = 4;
            this.lblCodeUser.Text = "Code User";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(50, 167);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(88, 18);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "User Name";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(90, 219);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(48, 18);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "Login";
            // 
            // SWtxtCodeUser
            // 
            this.SWtxtCodeUser.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtCodeUser.DatabaseName = "CodeUser";
            this.SWtxtCodeUser.IsForeignKey = false;
            this.SWtxtCodeUser.Location = new System.Drawing.Point(144, 116);
            this.SWtxtCodeUser.Name = "SWtxtCodeUser";
            this.SWtxtCodeUser.NullSpace = true;
            this.SWtxtCodeUser.Size = new System.Drawing.Size(193, 21);
            this.SWtxtCodeUser.TabIndex = 7;
            // 
            // SWtxtUserName
            // 
            this.SWtxtUserName.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtUserName.DatabaseName = "UserName";
            this.SWtxtUserName.IsForeignKey = false;
            this.SWtxtUserName.Location = new System.Drawing.Point(144, 167);
            this.SWtxtUserName.Name = "SWtxtUserName";
            this.SWtxtUserName.NullSpace = true;
            this.SWtxtUserName.Size = new System.Drawing.Size(193, 21);
            this.SWtxtUserName.TabIndex = 8;
            // 
            // SWtxtLogin
            // 
            this.SWtxtLogin.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.SWtxtLogin.DatabaseName = "Login";
            this.SWtxtLogin.IsForeignKey = false;
            this.SWtxtLogin.Location = new System.Drawing.Point(144, 219);
            this.SWtxtLogin.Name = "SWtxtLogin";
            this.SWtxtLogin.NullSpace = true;
            this.SWtxtLogin.Size = new System.Drawing.Size(193, 21);
            this.SWtxtLogin.TabIndex = 9;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 729);
            this.Controls.Add(this.SWtxtLogin);
            this.Controls.Add(this.SWtxtUserName);
            this.Controls.Add(this.SWtxtCodeUser);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblCodeUser);
            this.Name = "frmUsers";
            this.Text = "Users";
            this.Controls.SetChildIndex(this.lblCodeUser, 0);
            this.Controls.SetChildIndex(this.lblUserName, 0);
            this.Controls.SetChildIndex(this.lblLogin, 0);
            this.Controls.SetChildIndex(this.SWtxtCodeUser, 0);
            this.Controls.SetChildIndex(this.SWtxtUserName, 0);
            this.Controls.SetChildIndex(this.SWtxtLogin, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodeUser;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblLogin;
        private SecureCoreInheritedControl.SWTextbox SWtxtCodeUser;
        private SecureCoreInheritedControl.SWTextbox SWtxtUserName;
        private SecureCoreInheritedControl.SWTextbox SWtxtLogin;
    }
}