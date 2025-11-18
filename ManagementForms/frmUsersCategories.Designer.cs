
namespace ManagementForms
{
    partial class frmUsersCategories
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
            this.swTextbox2 = new SecureCoreInheritedControl.SWTextbox();
            this.swTextbox3 = new SecureCoreInheritedControl.SWTextbox();
            this.swTextbox4 = new SecureCoreInheritedControl.SWTextbox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // swTextbox2
            // 
            this.swTextbox2.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.swTextbox2.DatabaseName = "CodeCategory";
            this.swTextbox2.IsForeignKey = false;
            this.swTextbox2.Location = new System.Drawing.Point(181, 122);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.NullSpace = true;
            this.swTextbox2.Size = new System.Drawing.Size(223, 21);
            this.swTextbox2.TabIndex = 5;
            this.swTextbox2.Tag = "CodeCategory";
            // 
            // swTextbox3
            // 
            this.swTextbox3.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.swTextbox3.DatabaseName = "DescCategory";
            this.swTextbox3.IsForeignKey = false;
            this.swTextbox3.Location = new System.Drawing.Point(181, 163);
            this.swTextbox3.Name = "swTextbox3";
            this.swTextbox3.NullSpace = true;
            this.swTextbox3.Size = new System.Drawing.Size(223, 21);
            this.swTextbox3.TabIndex = 6;
            this.swTextbox3.Tag = "DescCategory";
            // 
            // swTextbox4
            // 
            this.swTextbox4.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.swTextbox4.DatabaseName = "AccessLevel";
            this.swTextbox4.IsForeignKey = false;
            this.swTextbox4.Location = new System.Drawing.Point(181, 205);
            this.swTextbox4.Name = "swTextbox4";
            this.swTextbox4.NullSpace = true;
            this.swTextbox4.Size = new System.Drawing.Size(223, 21);
            this.swTextbox4.TabIndex = 7;
            this.swTextbox4.Tag = "AccessLevel";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(70, 205);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(98, 18);
            this.lblLevel.TabIndex = 10;
            this.lblLevel.Text = "Acces Level";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(73, 164);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(95, 18);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Description:";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(40, 123);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(124, 18);
            this.lblCode.TabIndex = 8;
            this.lblCode.Text = "Code Category";
            // 
            // frmUsersCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(1201, 729);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.swTextbox4);
            this.Controls.Add(this.swTextbox3);
            this.Controls.Add(this.swTextbox2);
            this.MinimumSize = new System.Drawing.Size(1211, 768);
            this.Name = "frmUsersCategories";
            this.Controls.SetChildIndex(this.swTextbox2, 0);
            this.Controls.SetChildIndex(this.swTextbox3, 0);
            this.Controls.SetChildIndex(this.swTextbox4, 0);
            this.Controls.SetChildIndex(this.lblCode, 0);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.lblLevel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SecureCoreInheritedControl.SWTextbox swTextbox2;
        private SecureCoreInheritedControl.SWTextbox swTextbox3;
        private SecureCoreInheritedControl.SWTextbox swTextbox4;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
    }
}
