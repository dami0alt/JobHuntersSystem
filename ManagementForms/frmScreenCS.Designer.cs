
namespace ManagementForms
{
    partial class frmScreenCS
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTableName = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pctBackGround = new System.Windows.Forms.PictureBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pctGif1 = new System.Windows.Forms.PictureBox();
            this.pctGif2 = new System.Windows.Forms.PictureBox();
            this.pnlHeaderLine = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGif1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGif2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(79)))), ((int)(((byte)(86)))));
            this.pnlHeader.Controls.Add(this.pnlHeaderLine);
            this.pnlHeader.Controls.Add(this.pctGif2);
            this.pnlHeader.Controls.Add(this.pctGif1);
            this.pnlHeader.Controls.Add(this.lblTableName);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(842, 51);
            this.pnlHeader.TabIndex = 4;
            // 
            // lblTableName
            // 
            this.lblTableName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTableName.BackColor = System.Drawing.Color.Transparent;
            this.lblTableName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lblTableName.Location = new System.Drawing.Point(178, 18);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(485, 25);
            this.lblTableName.TabIndex = 1;
            this.lblTableName.Text = "Table Name";
            this.lblTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvData
            // 
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvData.Location = new System.Drawing.Point(31, 335);
            this.dgvData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 62;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(780, 212);
            this.dgvData.TabIndex = 5;
            this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(661, 298);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 25);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(741, 298);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 25);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pctBackGround
            // 
            this.pctBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctBackGround.ImageLocation = "Multimedia/jpg/space.jpeg";
            this.pctBackGround.Location = new System.Drawing.Point(0, 0);
            this.pctBackGround.Name = "pctBackGround";
            this.pctBackGround.Size = new System.Drawing.Size(842, 584);
            this.pctBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBackGround.TabIndex = 11;
            this.pctBackGround.TabStop = false;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 574);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(842, 10);
            this.pnlFooter.TabIndex = 12;
            // 
            // pctGif1
            // 
            this.pctGif1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctGif1.ImageLocation = "Multimedia/gifs/Darth_Vader.gif";
            this.pctGif1.Location = new System.Drawing.Point(-18, -25);
            this.pctGif1.Name = "pctGif1";
            this.pctGif1.Size = new System.Drawing.Size(93, 93);
            this.pctGif1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctGif1.TabIndex = 2;
            this.pctGif1.TabStop = false;
            // 
            // pctGif2
            // 
            this.pctGif2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctGif2.ImageLocation = "Multimedia/gifs/Darth_Vader2.gif";
            this.pctGif2.Location = new System.Drawing.Point(717, -34);
            this.pctGif2.Name = "pctGif2";
            this.pctGif2.Size = new System.Drawing.Size(180, 106);
            this.pctGif2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctGif2.TabIndex = 3;
            this.pctGif2.TabStop = false;
            // 
            // pnlHeaderLine
            // 
            this.pnlHeaderLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeaderLine.BackColor = System.Drawing.Color.Silver;
            this.pnlHeaderLine.Location = new System.Drawing.Point(280, 10);
            this.pnlHeaderLine.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeaderLine.Name = "pnlHeaderLine";
            this.pnlHeaderLine.Size = new System.Drawing.Size(274, 5);
            this.pnlHeaderLine.TabIndex = 13;
            // 
            // frmScreenCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(842, 584);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pctBackGround);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmScreenCS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "      ";
            this.Load += new System.EventHandler(this.frmScreenCS_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmScreenCS_KeyDown);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGif1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGif2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        protected System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.PictureBox pctBackGround;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.PictureBox pctGif1;
        private System.Windows.Forms.PictureBox pctGif2;
        private System.Windows.Forms.Panel pnlHeaderLine;
    }
}