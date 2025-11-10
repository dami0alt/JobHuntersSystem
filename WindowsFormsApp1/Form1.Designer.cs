
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.swTextbox3 = new Secure_Core_Inherited_Control.SWTextbox();
            this.swTextbox2 = new Secure_Core_Inherited_Control.SWTextbox();
            this.swTextbox1 = new Secure_Core_Inherited_Control.SWTextbox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(372, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(372, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(372, 193);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 2;
            // 
            // swTextbox3
            // 
            this.swTextbox3.AllowedData = Secure_Core_Inherited_Control.DataType.Text;
            this.swTextbox3.DatabaseName = "";
            this.swTextbox3.Location = new System.Drawing.Point(162, 193);
            this.swTextbox3.Name = "swTextbox3";
            this.swTextbox3.NullSpace = true;
            this.swTextbox3.Size = new System.Drawing.Size(100, 22);
            this.swTextbox3.TabIndex = 5;
            // 
            // swTextbox2
            // 
            this.swTextbox2.AllowedData = Secure_Core_Inherited_Control.DataType.Number;
            this.swTextbox2.DatabaseName = "";
            this.swTextbox2.Location = new System.Drawing.Point(162, 119);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.NullSpace = true;
            this.swTextbox2.Size = new System.Drawing.Size(100, 22);
            this.swTextbox2.TabIndex = 4;
            // 
            // swTextbox1
            // 
            this.swTextbox1.AllowedData = Secure_Core_Inherited_Control.DataType.Code;
            this.swTextbox1.DatabaseName = "";
            this.swTextbox1.Location = new System.Drawing.Point(162, 51);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.NullSpace = true;
            this.swTextbox1.Size = new System.Drawing.Size(100, 22);
            this.swTextbox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.swTextbox3);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.swTextbox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private Secure_Core_Inherited_Control.SWTextbox swTextbox1;
        private Secure_Core_Inherited_Control.SWTextbox swTextbox2;
        private Secure_Core_Inherited_Control.SWTextbox swTextbox3;
    }
}

