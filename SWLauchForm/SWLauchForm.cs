using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace SWUserControls
{
    public partial class SWLauchForm : UserControl
    {
        public SWLauchForm()
        {
            InitializeComponent();
            pnlMain.MouseEnter += new EventHandler(Control_MouseEnter);
            pnlMain.MouseLeave += new EventHandler(Control_MouseLeave);
            foreach (Control ctrl in pnlMain.Controls)
            {
                ctrl.MouseEnter += new EventHandler(Control_MouseEnter);
                ctrl.MouseLeave += new EventHandler(Control_MouseLeave);
            }
        }
        private string _Description = "Option";
        public string Description
        {
            get { return _Description; }
            set
            {
                _Description = value;
                this.lblOptionName.Text = value;
            }
        }
        private string _ClassName;
        public string ClassName
        {
            get { return _ClassName; }
            set { _ClassName = value; }
        }
        private string _FormName;
        public string FormName
        {
            get { return _FormName; }
            set { _FormName = value; }
        }
        private int _AccessLevel = 10;
        public int AccessLevel
        {
            get { return _AccessLevel; }
            set { _AccessLevel = value; }
        }
        private string _InitialImagePath;
        public string InitialImagePath
        {
            get { return _InitialImagePath; }
            set { string path = value;
                _InitialImagePath = AppDomain.CurrentDomain.BaseDirectory + path;
                pctOptionIcon.ImageLocation = _InitialImagePath;           
            }
        }
        private string _HoverImagePath;
        public string HoverImagePath
        {
            get { return _HoverImagePath; }
            set { string path = value;
                _HoverImagePath = AppDomain.CurrentDomain.BaseDirectory + path;  
            }
        }
        private int[] _HoverFontColor = new int[] { 0, 0, 0 };
        public string HoverFontColor
        {
            get {
                return string.Join(";", _HoverFontColor);
            }
            set {
                if (!string.IsNullOrEmpty(value))
                {
                    string[] rgb = value.Split(';');
                    _HoverFontColor = new int[rgb.Length];
                    //Cleaning
                    for (int i = 0; i < rgb.Length; i++)
                    {
                        _HoverFontColor[i] = int.Parse(rgb[i].Trim());
                    }
                }
            }
        }
        private int[] _HoverBackColor = new int[] { 244, 244, 244 };
        public string HoverBackColor
        {
            get
            {
                return string.Join(";", _HoverBackColor);
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    string[] rgb = value.Split(';');
                    _HoverBackColor = new int[rgb.Length];
                    //Cleaning
                    for (int i = 0; i < rgb.Length; i++)
                    {
                        _HoverBackColor[i] = int.Parse(rgb[i].Trim());
                    }
                }
            }
        }

        private void pnlMain_Click(object sender, EventArgs e)
        {
            if(_FormName != null || _ClassName != null)
            {
                Assembly assembly;
                assembly = Assembly.LoadFrom(_ClassName);
                Object dllBD;

                Type types;

                types = assembly.GetType(_FormName);

                dllBD = Activator.CreateInstance(types);

                ((Form)dllBD).Show();
            }
        }
        private void Control_MouseEnter(object sender, EventArgs e)
        {
            pctOptionIcon.ImageLocation = _HoverImagePath;
            this.BackColor = Color.FromArgb(_HoverBackColor[0], _HoverBackColor[1], _HoverBackColor[2]);
            this.ForeColor = Color.FromArgb(_HoverFontColor[0], _HoverFontColor[1], _HoverFontColor[2]);
        }
        private void Control_MouseLeave(object sender, EventArgs e)
        {
            pctOptionIcon.ImageLocation = _InitialImagePath;
            this.ForeColor = this.Parent.ForeColor;
            this.BackColor = this.Parent.BackColor;
        }
    }
}
