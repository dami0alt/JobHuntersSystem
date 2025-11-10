
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
            this.lblOrg = new System.Windows.Forms.Label();
            this.lblClan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pgbSplash
            // 
            this.pgbSplash.Location = new System.Drawing.Point(97, 296);
            this.pgbSplash.Maximum = 101;
            this.pgbSplash.Name = "pgbSplash";
            this.pgbSplash.Size = new System.Drawing.Size(607, 41);
            this.pgbSplash.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbSplash.TabIndex = 0;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(143)))), ((int)(((byte)(82)))));
            this.lblProgress.Location = new System.Drawing.Point(375, 355);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(46, 28);
            this.lblProgress.TabIndex = 1;
            this.lblProgress.Text = "0%";
            // 
            // TimerSplash
            // 
            this.TimerSplash.Enabled = true;
            this.TimerSplash.Tick += new System.EventHandler(this.TimerSplash_Tick);
            // 
            // lblOrg
            // 
            this.lblOrg.AutoSize = true;
            this.lblOrg.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Bold);
            this.lblOrg.Location = new System.Drawing.Point(96, 117);
            this.lblOrg.Name = "lblOrg";
            this.lblOrg.Size = new System.Drawing.Size(592, 66);
            this.lblOrg.TabIndex = 2;
            this.lblOrg.Text = "SdS Software Factory";
            // 
            // lblClan
            // 
            this.lblClan.AutoSize = true;
            this.lblClan.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblClan.Location = new System.Drawing.Point(297, 241);
            this.lblClan.Name = "lblClan";
            this.lblClan.Size = new System.Drawing.Size(196, 38);
            this.lblClan.TabIndex = 3;
            this.lblClan.Text = "Job Hunters";
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(79)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblClan);
            this.Controls.Add(this.lblOrg);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.pgbSplash);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(143)))), ((int)(((byte)(82)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbSplash;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Timer TimerSplash;
        private System.Windows.Forms.Label lblOrg;
        private System.Windows.Forms.Label lblClan;
    }
}