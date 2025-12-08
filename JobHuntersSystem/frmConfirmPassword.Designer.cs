
namespace JobHuntersSystem
{
    partial class frmConfirmPassword
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfirmPassword));
            this.btnConfirmPassword = new System.Windows.Forms.Button();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pctRectangle = new System.Windows.Forms.PictureBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.pctBackground = new System.Windows.Forms.PictureBox();
            this.lblInformation = new System.Windows.Forms.Label();
            this.lblSecurity = new System.Windows.Forms.Label();
            this.pnlProtection = new System.Windows.Forms.Panel();
            this.timerInfo = new System.Windows.Forms.Timer(this.components);
            this.pnlSecurityLevel = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRectangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBackground)).BeginInit();
            this.pnlProtection.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmPassword
            // 
            this.btnConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmPassword.Location = new System.Drawing.Point(509, 269);
            this.btnConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmPassword.Name = "btnConfirmPassword";
            this.btnConfirmPassword.Size = new System.Drawing.Size(80, 24);
            this.btnConfirmPassword.TabIndex = 10;
            this.btnConfirmPassword.Text = "Done";
            this.btnConfirmPassword.UseVisualStyleBackColor = true;
            this.btnConfirmPassword.Click += new System.EventHandler(this.btnConfirmPassword_Click);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(179, 223);
            this.lblConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(154, 19);
            this.lblConfirmPassword.TabIndex = 9;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(244, 184);
            this.lblNewPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(86, 19);
            this.lblNewPassword.TabIndex = 8;
            this.lblNewPassword.Text = "Password:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(347, 223);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(242, 20);
            this.txtConfirmPassword.TabIndex = 7;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(347, 184);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(242, 20);
            this.txtNewPassword.TabIndex = 6;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(9)))), ((int)(((byte)(13)))));
            this.pnlMain.Controls.Add(this.pnlProtection);
            this.pnlMain.Controls.Add(this.lblSecurity);
            this.pnlMain.Controls.Add(this.lblInformation);
            this.pnlMain.Controls.Add(this.pnlTitle);
            this.pnlMain.Controls.Add(this.btnConfirmPassword);
            this.pnlMain.Controls.Add(this.lblConfirmPassword);
            this.pnlMain.Controls.Add(this.lblNewPassword);
            this.pnlMain.Controls.Add(this.txtConfirmPassword);
            this.pnlMain.Controls.Add(this.txtNewPassword);
            this.pnlMain.Controls.Add(this.pctBackground);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(722, 403);
            this.pnlMain.TabIndex = 11;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.pctRectangle);
            this.pnlTitle.Controls.Add(this.lblPassword);
            this.pnlTitle.Controls.Add(this.lblChange);
            this.pnlTitle.Location = new System.Drawing.Point(105, 91);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(301, 62);
            this.pnlTitle.TabIndex = 11;
            // 
            // pctRectangle
            // 
            this.pctRectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(143)))), ((int)(((byte)(82)))));
            this.pctRectangle.Location = new System.Drawing.Point(49, 46);
            this.pctRectangle.Name = "pctRectangle";
            this.pctRectangle.Size = new System.Drawing.Size(239, 5);
            this.pctRectangle.TabIndex = 10;
            this.pctRectangle.TabStop = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(155, 7);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(146, 36);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.Color.White;
            this.lblChange.Location = new System.Drawing.Point(2, 1);
            this.lblChange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(165, 44);
            this.lblChange.TabIndex = 8;
            this.lblChange.Text = "Change";
            // 
            // pctBackground
            // 
            this.pctBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctBackground.Image = ((System.Drawing.Image)(resources.GetObject("pctBackground.Image")));
            this.pctBackground.ImageLocation = "Multimedia/png/SpaceshipBk.png";
            this.pctBackground.Location = new System.Drawing.Point(0, 0);
            this.pctBackground.Name = "pctBackground";
            this.pctBackground.Size = new System.Drawing.Size(722, 403);
            this.pctBackground.TabIndex = 12;
            this.pctBackground.TabStop = false;
            // 
            // lblInformation
            // 
            this.lblInformation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.ForeColor = System.Drawing.Color.White;
            this.lblInformation.Location = new System.Drawing.Point(183, 271);
            this.lblInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(322, 19);
            this.lblInformation.TabIndex = 13;
            this.lblInformation.Text = "Confirm Password:";
            this.lblInformation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblInformation.Visible = false;
            // 
            // lblSecurity
            // 
            this.lblSecurity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurity.ForeColor = System.Drawing.Color.White;
            this.lblSecurity.Location = new System.Drawing.Point(345, 160);
            this.lblSecurity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSecurity.Name = "lblSecurity";
            this.lblSecurity.Size = new System.Drawing.Size(113, 19);
            this.lblSecurity.TabIndex = 14;
            this.lblSecurity.Text = "Protection Level";
            this.lblSecurity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlProtection
            // 
            this.pnlProtection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlProtection.Controls.Add(this.pnlSecurityLevel);
            this.pnlProtection.Location = new System.Drawing.Point(461, 164);
            this.pnlProtection.Name = "pnlProtection";
            this.pnlProtection.Size = new System.Drawing.Size(128, 10);
            this.pnlProtection.TabIndex = 15;
            // 
            // timerInfo
            // 
            this.timerInfo.Interval = 1500;
            this.timerInfo.Tick += new System.EventHandler(this.timerInfo_Tick);
            // 
            // pnlSecurityLevel
            // 
            this.pnlSecurityLevel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSecurityLevel.Location = new System.Drawing.Point(0, 0);
            this.pnlSecurityLevel.Name = "pnlSecurityLevel";
            this.pnlSecurityLevel.Size = new System.Drawing.Size(128, 10);
            this.pnlSecurityLevel.TabIndex = 0;
            // 
            // frmConfirmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(722, 403);
            this.Controls.Add(this.pnlMain);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(143)))), ((int)(((byte)(82)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmConfirmPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConfirmPassword";
            this.TopMost = true;
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRectangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBackground)).EndInit();
            this.pnlProtection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.PictureBox pctRectangle;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.PictureBox pctBackground;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Panel pnlProtection;
        private System.Windows.Forms.Label lblSecurity;
        private System.Windows.Forms.Timer timerInfo;
        private System.Windows.Forms.Panel pnlSecurityLevel;
    }
}