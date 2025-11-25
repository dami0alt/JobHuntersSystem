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
        Code
    }

    public class SWTextbox : TextBox
    {

        private DataType _AllowedData = DataType.Text;
        private string _DatabaseName = "";
        private bool _NullSpace = true;
        private Color _OriginalColor;
        private bool _IsValid = true;
        private bool _IsForeignKey = false;

        public DataType AllowedData
        {
            get { return _AllowedData; }
            set { _AllowedData = value; }
        }

        public string DatabaseName
        {
            get { return _DatabaseName; }
            set { _DatabaseName = value; }
        }

        public bool NullSpace
        {
            get { return _NullSpace; }
            set { _NullSpace = value; }
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
            _OriginalColor = this.BackColor;
            InitializeComponent();
            this.Enter += SWTextbox_Enter;
            this.Leave += SWTextbox_Leave;
            this.Validating += SWTextbox_Validating;
        }

        private void SWTextbox_Leave(object sender, EventArgs e)
        {
            this.BackColor = _OriginalColor;
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
                validation = Regex.IsMatch(text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]+$");
            }

            _IsValid = validation;

            if (!_IsValid)
            {
                e.Cancel = true;
            }
            
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
            Form parentForm = this.FindForm();

            if (_IsForeignKey)
            {
                foreach (Control ctrl in parentForm.Controls)
                {
                    if (ctrl.Name == _ControlID)    
                    {
                        DataSet ds = new DataSet();
                        ds = ((SWCodi)ctrl).GetDataSWTextbox(this.Text);
                        ((SWCodi)ctrl).SetSWCodiData(ds);
                    }
                }
            }
        }
    }
}
