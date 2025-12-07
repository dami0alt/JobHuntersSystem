
namespace JobHuntersSystem
{
    partial class frmLogin
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pbPass = new System.Windows.Forms.PictureBox();
            this.lblJobHunters = new System.Windows.Forms.Label();
            this.lblSystem = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pctRectangle = new System.Windows.Forms.PictureBox();
            this.lblBody = new System.Windows.Forms.Label();
            this.pnlCredentials = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblCongratulations = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlRectangle = new System.Windows.Forms.Panel();
            this.pnlMessage = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pctGif3 = new System.Windows.Forms.PictureBox();
            this.pctBackGround = new System.Windows.Forms.PictureBox();
            this.timerRedirection = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).BeginInit();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRectangle)).BeginInit();
            this.pnlCredentials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctGif3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(114, 14);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(160, 20);
            this.txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(114, 58);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(160, 20);
            this.txtPass.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(13, 14);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(88, 21);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Username";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(20, 55);
            this.lblPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(82, 21);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(205, 104);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(69, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(127, 104);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(69, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Black;
            this.lblMessage.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Salmon;
            this.lblMessage.Location = new System.Drawing.Point(35, 32);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(338, 33);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbPass
            // 
            this.pbPass.Location = new System.Drawing.Point(281, 53);
            this.pbPass.Name = "pbPass";
            this.pbPass.Size = new System.Drawing.Size(28, 29);
            this.pbPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPass.TabIndex = 7;
            this.pbPass.TabStop = false;
            this.pbPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPass_MouseDown);
            this.pbPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPass_MouseUp);
            // 
            // lblJobHunters
            // 
            this.lblJobHunters.AutoSize = true;
            this.lblJobHunters.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobHunters.ForeColor = System.Drawing.Color.White;
            this.lblJobHunters.Location = new System.Drawing.Point(1, 1);
            this.lblJobHunters.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJobHunters.Name = "lblJobHunters";
            this.lblJobHunters.Size = new System.Drawing.Size(218, 44);
            this.lblJobHunters.TabIndex = 8;
            this.lblJobHunters.Text = "JobHunters";
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystem.ForeColor = System.Drawing.Color.White;
            this.lblSystem.Location = new System.Drawing.Point(209, 7);
            this.lblSystem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(118, 36);
            this.lblSystem.TabIndex = 9;
            this.lblSystem.Text = "System ";
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.pctRectangle);
            this.pnlTitle.Controls.Add(this.lblSystem);
            this.pnlTitle.Controls.Add(this.lblJobHunters);
            this.pnlTitle.Location = new System.Drawing.Point(17, 17);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(324, 62);
            this.pnlTitle.TabIndex = 10;
            // 
            // pctRectangle
            // 
            this.pctRectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.pctRectangle.Location = new System.Drawing.Point(69, 46);
            this.pctRectangle.Name = "pctRectangle";
            this.pctRectangle.Size = new System.Drawing.Size(239, 5);
            this.pctRectangle.TabIndex = 10;
            this.pctRectangle.TabStop = false;
            // 
            // lblBody
            // 
            this.lblBody.BackColor = System.Drawing.Color.Black;
            this.lblBody.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBody.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(164)))), ((int)(((byte)(69)))));
            this.lblBody.Location = new System.Drawing.Point(37, 47);
            this.lblBody.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(335, 134);
            this.lblBody.TabIndex = 11;
            this.lblBody.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCredentials
            // 
            this.pnlCredentials.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCredentials.Controls.Add(this.pbPass);
            this.pnlCredentials.Controls.Add(this.btnExit);
            this.pnlCredentials.Controls.Add(this.btnLogin);
            this.pnlCredentials.Controls.Add(this.lblPass);
            this.pnlCredentials.Controls.Add(this.lblUser);
            this.pnlCredentials.Controls.Add(this.txtPass);
            this.pnlCredentials.Controls.Add(this.txtUser);
            this.pnlCredentials.Controls.Add(this.pictureBox1);
            this.pnlCredentials.Location = new System.Drawing.Point(88, 85);
            this.pnlCredentials.Name = "pnlCredentials";
            this.pnlCredentials.Size = new System.Drawing.Size(312, 165);
            this.pnlCredentials.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "Multimedia/gifs/Arturito.gif";
            this.pictureBox1.Location = new System.Drawing.Point(-2, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlFooter.Controls.Add(this.lblCongratulations);
            this.pnlFooter.Controls.Add(this.lblFooter);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 515);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(409, 22);
            this.pnlFooter.TabIndex = 13;
            // 
            // lblCongratulations
            // 
            this.lblCongratulations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCongratulations.AutoSize = true;
            this.lblCongratulations.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongratulations.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCongratulations.Location = new System.Drawing.Point(3, 3);
            this.lblCongratulations.Name = "lblCongratulations";
            this.lblCongratulations.Size = new System.Drawing.Size(144, 16);
            this.lblCongratulations.TabIndex = 1;
            this.lblCongratulations.Text = "Made with ♡ for D.M.M.A";
            // 
            // lblFooter
            // 
            this.lblFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.ForeColor = System.Drawing.Color.Gray;
            this.lblFooter.Location = new System.Drawing.Point(275, 3);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(132, 16);
            this.lblFooter.TabIndex = 0;
            this.lblFooter.Text = "© JobHunterSystem S.L.";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(409, 22);
            this.pnlHeader.TabIndex = 14;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlCredentials);
            this.pnlMain.Controls.Add(this.pnlTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 22);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(409, 258);
            this.pnlMain.TabIndex = 15;
            // 
            // pnlRectangle
            // 
            this.pnlRectangle.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlRectangle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRectangle.Location = new System.Drawing.Point(0, 280);
            this.pnlRectangle.Name = "pnlRectangle";
            this.pnlRectangle.Size = new System.Drawing.Size(409, 9);
            this.pnlRectangle.TabIndex = 16;
            // 
            // pnlMessage
            // 
            this.pnlMessage.Controls.Add(this.lblMessage);
            this.pnlMessage.Controls.Add(this.lblBody);
            this.pnlMessage.Controls.Add(this.lblInfo);
            this.pnlMessage.Controls.Add(this.pctGif3);
            this.pnlMessage.Controls.Add(this.pctBackGround);
            this.pnlMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMessage.Location = new System.Drawing.Point(0, 289);
            this.pnlMessage.Name = "pnlMessage";
            this.pnlMessage.Size = new System.Drawing.Size(409, 226);
            this.pnlMessage.TabIndex = 17;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Black;
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblInfo.Location = new System.Drawing.Point(207, 201);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(134, 23);
            this.lblInfo.TabIndex = 33;
            this.lblInfo.Text = "Redirecting in";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInfo.Visible = false;
            // 
            // pctGif3
            // 
            this.pctGif3.BackColor = System.Drawing.Color.Black;
            this.pctGif3.ImageLocation = "Multimedia/gifs/Robot.gif";
            this.pctGif3.Location = new System.Drawing.Point(324, 169);
            this.pctGif3.Name = "pctGif3";
            this.pctGif3.Size = new System.Drawing.Size(66, 67);
            this.pctGif3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctGif3.TabIndex = 32;
            this.pctGif3.TabStop = false;
            this.pctGif3.Visible = false;
            // 
            // pctBackGround
            // 
            this.pctBackGround.BackColor = System.Drawing.Color.Black;
            this.pctBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctBackGround.ImageLocation = "Multimedia/jpg/space.jpg";
            this.pctBackGround.Location = new System.Drawing.Point(0, 0);
            this.pctBackGround.Name = "pctBackGround";
            this.pctBackGround.Size = new System.Drawing.Size(409, 226);
            this.pctBackGround.TabIndex = 12;
            this.pctBackGround.TabStop = false;
            // 
            // timerRedirection
            // 
            this.timerRedirection.Interval = 333;
            this.timerRedirection.Tick += new System.EventHandler(this.timerRedirection_Tick);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(409, 537);
            this.Controls.Add(this.pnlMessage);
            this.Controls.Add(this.pnlRectangle);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFooter);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(164)))), ((int)(((byte)(69)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRectangle)).EndInit();
            this.pnlCredentials.ResumeLayout(false);
            this.pnlCredentials.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctGif3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBackGround)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pbPass;
        private System.Windows.Forms.Label lblJobHunters;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.PictureBox pctRectangle;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.Panel pnlCredentials;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblCongratulations;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlRectangle;
        private System.Windows.Forms.Panel pnlMessage;
        private System.Windows.Forms.PictureBox pctBackGround;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pctGif3;
        public System.Windows.Forms.Timer timerRedirection;
    }
}