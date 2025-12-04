using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SecureCoreInheritedControl
{
    public class SWColorPicker: PictureBox
    {

        Color colorSelected;

        string rgbFormat = @"^([1]?[0-9]?[0-9]|2[0-4][0-9]|25[0-5]);" +
                "([1]?[0-9]?[0-9]|2[0-4][0-9]|25[0-5]);" +
                "([1]?[0-9]?[0-9]|2[0-4][0-9]|25[0-5])$";

        private string _ControlID;
        public string ControlID
        {
            get { return _ControlID; }
            set { _ControlID = value; }
        }
        public SWColorPicker()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // SWColorPicker
            // 
            this.Click += new System.EventHandler(this.SWColorPicker_Click);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
        public void SetColor(string value,Boolean formatValidated)
        {
            if (formatValidated)
            {
                string[] rgbFormat = value.Split(';');
                int[] RGB = new int[rgbFormat.Length];
                //Cleaning
                for (int i = 0; i < rgbFormat.Length; i++)
                {
                    RGB[i] = int.Parse(rgbFormat[i].Trim());
                }
                Color colorPicked = Color.FromArgb(RGB[0], RGB[1], RGB[2]);
                this.BackColor = colorPicked;
            }
            else
            {
                this.BackColor = Color.Silver;
            }
         
        }
        private void SetSWTextboxRgb()
        {
            string rgbFormat = $"{colorSelected.R};{colorSelected.G};{colorSelected.B}";
            Form parentForm = this.FindForm();
            foreach (Control ctrl in parentForm.Controls)
            {
                if (ctrl.Name == _ControlID)
                {
                    ctrl.Text = rgbFormat;
                    if (ctrl.DataBindings.Count > 0)
                    {
                        ctrl.DataBindings[0].BindingManagerBase.EndCurrentEdit();
                    }
                }
            }
        }
        private void SWColorPicker_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                dlg.Color = this.BackColor;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    colorSelected = dlg.Color;
                    SetSWTextboxRgb();
                    this.BackColor = colorSelected;
                }
            }

        }
    }
}
