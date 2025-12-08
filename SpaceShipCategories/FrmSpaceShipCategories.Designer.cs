
namespace SpaceShipCategories
{
    partial class FrmSpaceShipCategories
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
            this.swTextbox1 = new SecureCoreInheritedControl.SWTextbox();
            this.swTextbox2 = new SecureCoreInheritedControl.SWTextbox();
            this.lblCodeShip = new System.Windows.Forms.Label();
            this.lblDescShip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTableName
            // 
            this.lblTableName.Size = new System.Drawing.Size(468, 25);
            // 
            // swTextbox1
            // 
            this.swTextbox1.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.swTextbox1.ControlID = null;
            this.swTextbox1.DatabaseName = "CodeSpaceShipCategory";
            this.swTextbox1.IsForeignKey = false;
            this.swTextbox1.Location = new System.Drawing.Point(194, 195);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.NullSpace = true;
            this.swTextbox1.Size = new System.Drawing.Size(222, 24);
            this.swTextbox1.TabIndex = 6;
            this.swTextbox1.Tag = "CodeSpaceShipCategory";
            // 
            // swTextbox2
            // 
            this.swTextbox2.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.swTextbox2.ControlID = null;
            this.swTextbox2.DatabaseName = "DescSpaceShipCategory";
            this.swTextbox2.IsForeignKey = false;
            this.swTextbox2.Location = new System.Drawing.Point(194, 253);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.NullSpace = true;
            this.swTextbox2.Size = new System.Drawing.Size(222, 24);
            this.swTextbox2.TabIndex = 7;
            this.swTextbox2.Tag = "DescSpaceShipCategory";
            // 
            // lblCodeShip
            // 
            this.lblCodeShip.AutoSize = true;
            this.lblCodeShip.Location = new System.Drawing.Point(66, 198);
            this.lblCodeShip.Name = "lblCodeShip";
            this.lblCodeShip.Size = new System.Drawing.Size(122, 19);
            this.lblCodeShip.TabIndex = 8;
            this.lblCodeShip.Text = "SpaceShipCode";
            // 
            // lblDescShip
            // 
            this.lblDescShip.AutoSize = true;
            this.lblDescShip.Location = new System.Drawing.Point(72, 256);
            this.lblDescShip.Name = "lblDescShip";
            this.lblDescShip.Size = new System.Drawing.Size(116, 19);
            this.lblDescShip.TabIndex = 9;
            this.lblDescShip.Text = "SpaceShipDesc";
            // 
            // FrmSpaceShipCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 721);
            this.Controls.Add(this.lblDescShip);
            this.Controls.Add(this.lblCodeShip);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.swTextbox1);
            this.Name = "FrmSpaceShipCategories";
            this.Text = "FrmSpaceShipCategories";
            this.Controls.SetChildIndex(this.swTextbox1, 0);
            this.Controls.SetChildIndex(this.swTextbox2, 0);
            this.Controls.SetChildIndex(this.lblCodeShip, 0);
            this.Controls.SetChildIndex(this.lblDescShip, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SecureCoreInheritedControl.SWTextbox swTextbox1;
        private SecureCoreInheritedControl.SWTextbox swTextbox2;
        private System.Windows.Forms.Label lblCodeShip;
        private System.Windows.Forms.Label lblDescShip;
    }
}