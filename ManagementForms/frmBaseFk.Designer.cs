
namespace ManagementForms
{
    partial class frmBasefk
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
            this.dgtData = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pnlHeader.Controls.Add(this.lblTableName);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1201, 43);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTableName
            // 
            this.lblTableName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTableName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblTableName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lblTableName.Location = new System.Drawing.Point(321, 9);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(559, 25);
            this.lblTableName.TabIndex = 0;
            this.lblTableName.Text = "Table Name";
            this.lblTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgtData
            // 
            this.dgtData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgtData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.dgtData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtData.Location = new System.Drawing.Point(50, 384);
            this.dgtData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgtData.Name = "dgtData";
            this.dgtData.ReadOnly = true;
            this.dgtData.Size = new System.Drawing.Size(1079, 313);
            this.dgtData.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.Location = new System.Drawing.Point(1042, 338);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 28);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreate.Location = new System.Drawing.Point(934, 338);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(87, 28);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // frmBasefk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(86)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1201, 729);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgtData);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1217, 768);
            this.Name = "frmBasefk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base";
            this.Load += new System.EventHandler(this.frmBase_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgtData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        protected System.Windows.Forms.DataGridView dgtData;
        protected System.Windows.Forms.Label lblTableName;
    }
}