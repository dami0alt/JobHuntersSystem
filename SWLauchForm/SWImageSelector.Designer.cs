
namespace SWUserControls
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
            this.pbSelectedImage = new System.Windows.Forms.PictureBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.pnlEdge = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedImage)).BeginInit();
            this.pnlEdge.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbSelectedImage
            // 
            this.pbSelectedImage.Location = new System.Drawing.Point(7, 7);
            this.pbSelectedImage.Margin = new System.Windows.Forms.Padding(10);
            this.pbSelectedImage.Name = "pbSelectedImage";
            this.pbSelectedImage.Size = new System.Drawing.Size(65, 65);
            this.pbSelectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSelectedImage.TabIndex = 0;
            this.pbSelectedImage.TabStop = false;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(9, 58);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(145, 23);
            this.btnSelectImage.TabIndex = 2;
            this.btnSelectImage.Text = "Select Image";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click_1);
            // 
            // pnlEdge
            // 
            this.pnlEdge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlEdge.Controls.Add(this.pbSelectedImage);
            this.pnlEdge.Location = new System.Drawing.Point(171, 2);
            this.pnlEdge.Name = "pnlEdge";
            this.pnlEdge.Size = new System.Drawing.Size(81, 79);
            this.pnlEdge.TabIndex = 3;
            // 
            // ImageSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlEdge);
            this.Controls.Add(this.btnSelectImage);
            this.Name = "ImageSelector";
            this.Size = new System.Drawing.Size(253, 82);
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedImage)).EndInit();
            this.pnlEdge.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSelectedImage;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Panel pnlEdge;
    }
}
