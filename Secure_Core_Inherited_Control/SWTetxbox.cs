using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;
using SWUserControls;
using System.Data;

namespace SecureCoreInheritedControl
{

    public enum DataType
    {
        Number,
        Text,
        Code,
        Rgb
    }

    public class SWTextbox : TextBox
    {
        private DataType _AllowedData = DataType.Text;
        private string _DatabaseName = "";
        private bool _NullSpace = true;
        private bool _IsValid = true;
        private bool _IsForeignKey = false;


        Color notNullColor = Color.FromArgb(168, 194, 204);
        Color defaultColor = Color.White;

        string rgbFormat= @"^([1]?[0-9]?[0-9]|2[0-4][0-9]|25[0-5]);" +
                "([1]?[0-9]?[0-9]|2[0-4][0-9]|25[0-5]);" +
                "([1]?[0-9]?[0-9]|2[0-4][0-9]|25[0-5])$";
        public DataType AllowedData
        {
            get { return _AllowedData; }
            set 
            { 
                _AllowedData = value;
            }
        }

        public string DatabaseName
        {
            get { return _DatabaseName; }
            set { _DatabaseName = value; }
        }

        public bool NullSpace
        {
            get { return _NullSpace; }
            set { _NullSpace = value;
                if (!_NullSpace)
                {
                    this.BackColor = notNullColor;
                }
            }
        }

        public bool IsValid
        {
            get { return _IsValid; }
            private set { _IsValid = value; }
        }

        public bool IsForeignKey
        {
            get { return _IsForeignKey; }
            set { _IsForeignKey = value; }
        }
        private string _ControlID;
        public string ControlID
        {
            get { return _ControlID; }
            set { _ControlID = value; }
        }

        public SWTextbox()
        {
            InitializeComponent();
            this.Enter += SWTextbox_Enter;
            this.Leave += SWTextbox_Leave;
            this.Validating += SWTextbox_Validating;
        }

        private void SWTextbox_Leave(object sender, EventArgs e)
        {
            if (!_NullSpace)
            {
                this.BackColor = notNullColor;
            }
            else
            {
                this.BackColor = defaultColor;
            }
        }

        private void SWTextbox_Enter(object sender, EventArgs e)
        {
            if (_IsValid)
            {
                this.BackColor = Color.LightYellow;
            }
        }

        private void SWTextbox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string text = this.Text.Trim();
            bool validation = true;
            
            if (!NullSpace && string.IsNullOrEmpty(text))
                validation = false;

            if (validation && AllowedData == DataType.Number && text.Length > 0)
            {
                validation = Regex.IsMatch(text, @"^\d+$");
            }

            if (validation && AllowedData == DataType.Code && text.Length > 0)
            {
                string pattern = @"^[AEIOU][A-Z]{3}-\d{2}[13579]$";
                validation = Regex.IsMatch(text, pattern);
            }

            if (validation && AllowedData == DataType.Text && text.Length > 0)
            {
                validation = Regex.IsMatch(text, @"^(?=.*\p{L})[a-zA-Z0-9\s\p{P}\p{S}\p{L}]+$");
            }

            if (validation && AllowedData == DataType.Rgb && text.Length > 0)
            {
                validation = Regex.IsMatch(text, rgbFormat);
            }

            _IsValid = validation;

            if (!_IsValid)
            {
                e.Cancel = true;
            }
            
        }
        public void SetId(string id)
        {
            this.Text = id;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SWTextbox
            // 
            this.TextChanged += new System.EventHandler(this.SWTextbox_TextChanged);
            this.ResumeLayout(false);

        }

        private void SWTextbox_TextChanged(object sender, EventArgs e)
        {
            string value = this.Text;

            if (_IsForeignKey)
            {
                Form parentForm = this.FindForm();
                foreach (Control ctrl in parentForm.Controls)
                {
                    
                    if (ctrl.Name == _ControlID)
                    {
                        if(ctrl is SWCodi)
                        {
                            DataSet ds = new DataSet();
                            ds = ((SWCodi)ctrl).GetData(value);
                            ((SWCodi)ctrl).SetSWCodiData(ds);
                        }
                        else if (ctrl is ImageSelector)
                        {
                            string path = this.Text;
                            ((ImageSelector)ctrl).SetPhoto(path);
                        }
                    }
                }
            }
            if (_AllowedData == DataType.Rgb)
            {
                Form parentForm = this.FindForm();
                foreach (Control ctrl in parentForm.Controls)
                {

                    if (ctrl.Name == _ControlID)
                    {
                        if (ctrl is SWColorPicker)
                        {
                            Boolean formatValidated = Regex.IsMatch(value, rgbFormat);
                            ((SWColorPicker)ctrl).SetColor(value,formatValidated);
                        }
                    }
                }
            }
        }
    }
}
