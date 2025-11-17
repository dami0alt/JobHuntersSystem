
namespace JobHuntersSystem
{
    partial class frmMain
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.flpOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPanelTool = new System.Windows.Forms.Panel();
            this.pctExtender = new System.Windows.Forms.PictureBox();
            this.pnlRectangleTop = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblRoleUser = new System.Windows.Forms.Label();
            this.pctProfileImage = new System.Windows.Forms.PictureBox();
            this.pnlUserInformation = new System.Windows.Forms.Panel();
            this.pnlRectangleLeft = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.pnlPanelTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctExtender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctProfileImage)).BeginInit();
            this.pnlUserInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pnlHeader.Controls.Add(this.lblSystemName);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(143)))), ((int)(((byte)(82)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1440, 29);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(164)))), ((int)(((byte)(69)))));
            this.lblSystemName.Location = new System.Drawing.Point(695, 5);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(50, 19);
            this.lblSystemName.TabIndex = 5;
            this.lblSystemName.Text = "Home";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(659, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 29);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.pnlOptions.Controls.Add(this.flpOptions);
            this.pnlOptions.Controls.Add(this.pnlPanelTool);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(164)))), ((int)(((byte)(69)))));
            this.pnlOptions.Location = new System.Drawing.Point(0, 29);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(236, 852);
            this.pnlOptions.TabIndex = 1;
            // 
            // flpOptions
            // 
            this.flpOptions.AutoScroll = true;
            this.flpOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.flpOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpOptions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flpOptions.Location = new System.Drawing.Point(0, 74);
            this.flpOptions.Name = "flpOptions";
            this.flpOptions.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.flpOptions.Size = new System.Drawing.Size(236, 778);
            this.flpOptions.TabIndex = 5;
            this.flpOptions.WrapContents = false;
            // 
            // pnlPanelTool
            // 
            this.pnlPanelTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pnlPanelTool.Controls.Add(this.pctExtender);
            this.pnlPanelTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPanelTool.Location = new System.Drawing.Point(0, 0);
            this.pnlPanelTool.Name = "pnlPanelTool";
            this.pnlPanelTool.Size = new System.Drawing.Size(236, 74);
            this.pnlPanelTool.TabIndex = 6;
            // 
            // pctExtender
            // 
            this.pctExtender.ImageLocation = "Multimedia/png/Cross.png";
            this.pctExtender.Location = new System.Drawing.Point(20, 22);
            this.pctExtender.Name = "pctExtender";
            this.pctExtender.Size = new System.Drawing.Size(30, 30);
            this.pctExtender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctExtender.TabIndex = 0;
            this.pctExtender.TabStop = false;
            // 
            // pnlRectangleTop
            // 
            this.pnlRectangleTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.pnlRectangleTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRectangleTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(143)))), ((int)(((byte)(82)))));
            this.pnlRectangleTop.Location = new System.Drawing.Point(236, 103);
            this.pnlRectangleTop.Name = "pnlRectangleTop";
            this.pnlRectangleTop.Size = new System.Drawing.Size(1204, 10);
            this.pnlRectangleTop.TabIndex = 5;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(896, 19);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(225, 18);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "UserName";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRoleUser
            // 
            this.lblRoleUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoleUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleUser.ForeColor = System.Drawing.Color.White;
            this.lblRoleUser.Location = new System.Drawing.Point(899, 36);
            this.lblRoleUser.Name = "lblRoleUser";
            this.lblRoleUser.Size = new System.Drawing.Size(222, 20);
            this.lblRoleUser.TabIndex = 2;
            this.lblRoleUser.Text = "Role";
            this.lblRoleUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pctProfileImage
            // 
            this.pctProfileImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctProfileImage.ImageLocation = "";
            this.pctProfileImage.Location = new System.Drawing.Point(1128, 13);
            this.pctProfileImage.Name = "pctProfileImage";
            this.pctProfileImage.Size = new System.Drawing.Size(50, 50);
            this.pctProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctProfileImage.TabIndex = 3;
            this.pctProfileImage.TabStop = false;
            // 
            // pnlUserInformation
            // 
            this.pnlUserInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlUserInformation.Controls.Add(this.pctProfileImage);
            this.pnlUserInformation.Controls.Add(this.lblRoleUser);
            this.pnlUserInformation.Controls.Add(this.lblUserName);
            this.pnlUserInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(164)))), ((int)(((byte)(69)))));
            this.pnlUserInformation.Location = new System.Drawing.Point(236, 29);
            this.pnlUserInformation.Name = "pnlUserInformation";
            this.pnlUserInformation.Size = new System.Drawing.Size(1204, 74);
            this.pnlUserInformation.TabIndex = 3;
            // 
            // pnlRectangleLeft
            // 
            this.pnlRectangleLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(48)))));
            this.pnlRectangleLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRectangleLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(143)))), ((int)(((byte)(82)))));
            this.pnlRectangleLeft.Location = new System.Drawing.Point(236, 113);
            this.pnlRectangleLeft.Name = "pnlRectangleLeft";
            this.pnlRectangleLeft.Size = new System.Drawing.Size(11, 768);
            this.pnlRectangleLeft.TabIndex = 6;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(247, 113);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1193, 768);
            this.pnlMain.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(86)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1440, 881);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlRectangleLeft);
            this.Controls.Add(this.pnlRectangleTop);
            this.Controls.Add(this.pnlUserInformation);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlOptions.ResumeLayout(false);
            this.pnlPanelTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctExtender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctProfileImage)).EndInit();
            this.pnlUserInformation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.FlowLayoutPanel flpOptions;
        private System.Windows.Forms.Panel pnlPanelTool;
        private System.Windows.Forms.Panel pnlRectangleTop;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblRoleUser;
        private System.Windows.Forms.PictureBox pctProfileImage;
        private System.Windows.Forms.Panel pnlUserInformation;
        private System.Windows.Forms.PictureBox pctExtender;
        private System.Windows.Forms.Panel pnlRectangleLeft;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Panel pnlMain;
    }
}