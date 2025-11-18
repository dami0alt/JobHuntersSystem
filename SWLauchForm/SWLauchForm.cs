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
        }
        Object dllBD;
        Type types;
        #region Properties
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
        #endregion
        private void LoadDll()
        {
            if (_FormName != null || _ClassName != null)
            {
                Assembly assembly;
                assembly = Assembly.LoadFrom(_ClassName);

                types = assembly.GetType(_FormName);
                dllBD = Activator.CreateInstance(types);
            }
        }
        private void LoadFormByDll()
        {
            Form parentForm = this.FindForm();
            foreach (Control ctrl in parentForm.Controls)
            {
                if (ctrl is Panel && ((Panel)ctrl).Name == "pnlMain")
                {
                    ((Form)dllBD).TopLevel = false;

                    ((Form)dllBD).FormBorderStyle = FormBorderStyle.None;

                    ctrl.Controls.Add(((Form)dllBD));
                    ((Form)dllBD).Dock = DockStyle.Fill;
                    ((Form)dllBD).BringToFront();
                    ((Form)dllBD).Show();
                }
            }
        }

        #region Events
        //Evento Load: del control suscribiremos nuestros controles a los eventos de "MouseEnter y "MouseLeave"
        private void SWLauchForm_Load(object sender, EventArgs e)
        {
            pnlMain.MouseEnter += new EventHandler(Control_MouseEnter);
            pnlMain.MouseLeave += new EventHandler(Control_MouseLeave);
            pnlMain.Click += new EventHandler(Control_Click);
            foreach (Control ctrl in pnlMain.Controls)
            {
                ctrl.MouseEnter += new EventHandler(Control_MouseEnter);
                ctrl.MouseLeave += new EventHandler(Control_MouseLeave);
                ctrl.Click += new EventHandler(Control_Click);
            }
        }
        //Evento Click: Cuando se haga click sobre cualquier parte del control, este abrira un frm mediante "Reflection"
        private void Control_Click(object sender, EventArgs e)
        {
            Boolean exist = false;
            LoadDll();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == types)
                {
                    exist = true;
                    frm.BringToFront();
                }
            }
            if (!exist)
            {
                LoadFormByDll();
            }
        }
        //Eventos de diseño:...
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
        #endregion
    }
}
