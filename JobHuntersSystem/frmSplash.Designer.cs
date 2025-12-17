
namespace JobHuntersSystem
{
    partial class frmSplash
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
            this.pgbSplash = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.TimerSplash = new System.Windows.Forms.Timer(this.components);
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pctRectangle = new System.Windows.Forms.PictureBox();
            this.lblSystem = new System.Windows.Forms.Label();
            this.lblJobHunters = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblInformation = new System.Windows.Forms.Label();
            this.lblDots = new System.Windows.Forms.Label();
            this.pctBackGround = new System.Windows.Forms.PictureBox();
            this.pctAstronauta = new System.Windows.Forms.PictureBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pctControls = new System.Windows.Forms.PictureBox();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRectangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAstronauta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctControls)).BeginInit();
            this.SuspendLayout();
            // 
            // pgbSplash
            // 
            this.pgbSplash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbSplash.Location = new System.Drawing.Point(0, 488);
            this.pgbSplash.MarqueeAnimationSpeed = 700;
            this.pgbSplash.Maximum = 500;
            this.pgbSplash.Name = "pgbSplash";
            this.pgbSplash.Size = new System.Drawing.Size(958, 15);
            this.pgbSplash.TabIndex = 0;
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(164)))), ((int)(((byte)(69)))));
            this.lblProgress.Location = new System.Drawing.Point(864, 448);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(74, 29);
            this.lblProgress.TabIndex = 1;
            this.lblProgress.Text = "0%";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TimerSplash
            // 
            this.TimerSplash.Enabled = true;
            this.TimerSplash.Interval = 10;
            this.TimerSplash.Tick += new System.EventHandler(this.TimerSplash_Tick);
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.pctRectangle);
            this.pnlTitle.Controls.Add(this.lblSystem);
            this.pnlTitle.Controls.Add(this.lblJobHunters);
            this.pnlTitle.Location = new System.Drawing.Point(310, 203);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(486, 95);
            this.pnlTitle.TabIndex = 11;
            // 
            // pctRectangle
            // 
            this.pctRectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(164)))), ((int)(((byte)(69)))));
            this.pctRectangle.Location = new System.Drawing.Point(104, 71);
            this.pctRectangle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctRectangle.Name = "pctRectangle";
            this.pctRectangle.Size = new System.Drawing.Size(358, 8);
            this.pctRectangle.TabIndex = 10;
            this.pctRectangle.TabStop = false;
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystem.ForeColor = System.Drawing.Color.White;
            this.lblSystem.Location = new System.Drawing.Point(314, 11);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(184, 55);
            this.lblSystem.TabIndex = 9;
            this.lblSystem.Text = "System ";
            // 
            // lblJobHunters
            // 
            this.lblJobHunters.AutoSize = true;
            this.lblJobHunters.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobHunters.ForeColor = System.Drawing.Color.White;
            this.lblJobHunters.Location = new System.Drawing.Point(2, 2);
            this.lblJobHunters.Name = "lblJobHunters";
            this.lblJobHunters.Size = new System.Drawing.Size(330, 66);
            this.lblJobHunters.TabIndex = 8;
            this.lblJobHunters.Text = "JobHunters";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(25)))));
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(952, 15);
            this.pnlHeader.TabIndex = 15;
            // 
            // lblInformation
            // 
            this.lblInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInformation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.ForeColor = System.Drawing.Color.White;
            this.lblInformation.Location = new System.Drawing.Point(464, 449);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(378, 32);
            this.lblInformation.TabIndex = 16;
            this.lblInformation.Text = "info";
            this.lblInformation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDots
            // 
            this.lblDots.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDots.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDots.ForeColor = System.Drawing.Color.White;
            this.lblDots.Location = new System.Drawing.Point(836, 449);
            this.lblDots.Name = "lblDots";
            this.lblDots.Size = new System.Drawing.Size(34, 32);
            this.lblDots.TabIndex = 17;
            this.lblDots.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pctBackGround
            // 
            this.pctBackGround.BackColor = System.Drawing.Color.Black;
            this.pctBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctBackGround.ImageLocation = "Multimedia/jpg/space.jpg";
            this.pctBackGround.Location = new System.Drawing.Point(0, 0);
            this.pctBackGround.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctBackGround.Name = "pctBackGround";
            this.pctBackGround.Size = new System.Drawing.Size(952, 494);
            this.pctBackGround.TabIndex = 18;
            this.pctBackGround.TabStop = false;
            // 
            // pctAstronauta
            // 
            this.pctAstronauta.BackColor = System.Drawing.Color.Black;
            this.pctAstronauta.ImageLocation = "Multimedia/gifs/Astronauta.gif";
            this.pctAstronauta.Location = new System.Drawing.Point(-28, 369);
            this.pctAstronauta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctAstronauta.Name = "pctAstronauta";
            this.pctAstronauta.Size = new System.Drawing.Size(146, 145);
            this.pctAstronauta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAstronauta.TabIndex = 34;
            this.pctAstronauta.TabStop = false;
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.Black;
            this.pctLogo.ImageLocation = "Multimedia/ControlIcons/Banner.png";
            this.pctLogo.Location = new System.Drawing.Point(154, 177);
            this.pctLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(177, 145);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 35;
            this.pctLogo.TabStop = false;
            // 
            // pctControls
            // 
            this.pctControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pctControls.BackColor = System.Drawing.Color.Black;
            this.pctControls.ImageLocation = "Multimedia/jpg/SpaceshipIn.jpg";
            this.pctControls.Location = new System.Drawing.Point(0, 6);
            this.pctControls.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctControls.Name = "pctControls";
            this.pctControls.Size = new System.Drawing.Size(952, 57);
            this.pctControls.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctControls.TabIndex = 36;
            this.pctControls.TabStop = false;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(952, 494);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pctControls);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.pgbSplash);
            this.Controls.Add(this.pctAstronauta);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.lblDots);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.pctBackGround);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(143)))), ((int)(((byte)(82)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplash";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSplash_KeyDown);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRectangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAstronauta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctControls)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbSplash;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Timer TimerSplash;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.PictureBox pctRectangle;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.Label lblJobHunters;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Label lblDots;
        private System.Windows.Forms.PictureBox pctBackGround;
        private System.Windows.Forms.PictureBox pctAstronauta;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.PictureBox pctControls;
    }
}