namespace ImageSelector
{
    partial class ImageSelector
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.pbSelectedImage = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedImage)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(3, 49);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(158, 23);
            this.btnSelectImage.TabIndex = 0;
            this.btnSelectImage.Text = "Select File";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // pbSelectedImage
            // 
            this.pbSelectedImage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbSelectedImage.Location = new System.Drawing.Point(10, 10);
            this.pbSelectedImage.Margin = new System.Windows.Forms.Padding(10);
            this.pbSelectedImage.Name = "pbSelectedImage";
            this.pbSelectedImage.Size = new System.Drawing.Size(60, 60);
            this.pbSelectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSelectedImage.TabIndex = 1;
            this.pbSelectedImage.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel1.Controls.Add(this.pbSelectedImage);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(192, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(80, 80);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // ImageSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnSelectImage);
            this.Name = "ImageSelector";
            this.Size = new System.Drawing.Size(275, 90);
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedImage)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.PictureBox pbSelectedImage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
