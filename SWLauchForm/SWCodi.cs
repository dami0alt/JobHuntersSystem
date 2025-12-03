using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentesDeAcceso;
using System.Reflection;

namespace SWUserControls
{
    public partial class SWCodi : UserControl
    {
        public SWCodi()
        {
            InitializeComponent();
            txtCode.Validating += new CancelEventHandler(Validacodi);
        }
        BaseDeDades dbManagement;
        DataSet ds;

        Object dllBD;
        Type types;

        private bool isValidated=true;
        string codeValidated;
        string descValidated;

        Color notNullColor = Color.FromArgb(168, 194, 204);
        Color defaultColor = Color.White;
        Color ErrorColor = Color.LightSalmon;

        #region public properties
        private string _NomTaula;
        public string NomTaula
        {
            get { return _NomTaula; }
            set { _NomTaula = value; }
        }
        private string _NomCodi;
        public string NomCodi
        {
            get { return _NomCodi; }
            set { _NomCodi = value; }
        }
        private string _NomDesc;
        public string NomDesc
        {
            get { return _NomDesc; }
            set { _NomDesc = value; }
        }
        private string _NomId;
        public string NomId
        {
            get { return _NomId; }
            set { _NomId = value; }
        }
        private string _ControlID; 
        public string ControlID
        {
            get { return _ControlID; }
            set { _ControlID = value; }
        }
        private bool _NullSpace = true;

        //[Category("Comportamiento")]
        //[Description("Si está en true, permite valores nulls")]
        public bool NullSpace
        {
            get { return _NullSpace; }
            set { _NullSpace = value;
                if (!_NullSpace)
                {
                    txtCode.BackColor = notNullColor;
                }
            }
        }
        private string _FormCS;
        public string FormCS
        {
            get { return _FormCS; }
            set { _FormCS = value;}
        }
        private string _ClasseCS;
        public string ClasseCS
        {
            get { return _ClasseCS; }
            set { _ClasseCS = value; }
        }

        #endregion
        public DataSet GetData()
        {
            DataSet _ds = new DataSet();
            string code = txtCode.Text;
            string query = $"SELECT {_NomDesc},{_NomId},{_NomCodi}  FROM {_NomTaula} WHERE {_NomCodi}='{code}'";
            _ds = dbManagement.PortarPerConsulta(query);
            return _ds;
        }
        //get data by Id
        public DataSet GetData(string idString)
        {
            DataSet _ds = new DataSet();
            if(int.TryParse(idString,out int id))
            {
                string query = $"SELECT {_NomDesc},{_NomCodi},{_NomId} FROM {_NomTaula} WHERE {_NomId}='{id}'";
                _ds = dbManagement.PortarPerConsulta(query);
            }
            return _ds;
        }

        private void SetSWTextboxData(DataSet ds)
        {
            string id = string.Empty;

            if (!string.IsNullOrEmpty(codeValidated))
            {
                id = ds.Tables[0].Rows[0][_NomId].ToString();
            }

            Form parentForm = this.FindForm();
            foreach (Control ctrl in parentForm.Controls)
            {
                if (ctrl.Name == _ControlID)
                {
                    ctrl.Text = id;
                }
            }
            
        }
        public void SetSWCodiData(DataSet _ds)
        {
            if (_ds != null && _ds.Tables.Count > 0 && _ds.Tables[0].Rows.Count > 0)
            {
                this.txtCode.Text = _ds.Tables[0].Rows[0][_NomCodi].ToString();
                this.txtDescription.Text = _ds.Tables[0].Rows[0][_NomDesc].ToString();

                codeValidated= this.txtCode.Text;
                descValidated= this.txtDescription.Text;
            }
            else
            {
                txtCode.Text = string.Empty;
                txtDescription.Text = "Unknown Data";
            }
           
        }
        private void obreCS()
        {
            if (_FormCS != null || _ClasseCS != null)
            {
                Form frm = this.FindForm();
                string frmName = frm.Name;
                string ControlId = this.txtCode.Name;
                Assembly assembly;
                Object[] args = { _NomTaula, frmName, _ControlID};

                assembly = Assembly.LoadFrom(_ClasseCS);

                types = assembly.GetType(_FormCS);
                dllBD = Activator.CreateInstance(types, args);

                ((Form)dllBD).TopLevel = true;
                ((Form)dllBD).FormBorderStyle = FormBorderStyle.None;
                ((Form)dllBD).Show();
            }
        }
        private void Validacodi(object sender, CancelEventArgs e) 
        {
            if (!isValidated)
            {
                isValidated = true;
                txtCode.Text = codeValidated;
                txtDescription.Text = descValidated;

                if (NullSpace)
                {
                    txtCode.BackColor = defaultColor;
                    txtDescription.BackColor = defaultColor;
                }
                else
                {
                    txtCode.BackColor = notNullColor;
                    txtDescription.BackColor = defaultColor;
                }
                e.Cancel = true;
            }
            else
            {
                if (string.IsNullOrEmpty(txtCode.Text))
                {
                    if (!_NullSpace)
                    {
                        isValidated = false;

                        txtCode.BackColor = ErrorColor;
                        txtDescription.BackColor = ErrorColor;

                        txtDescription.Text = "Required Data";
                        this.txtCode.Focus();
                    }
                    else
                    {
                        isValidated = true;
                        codeValidated = string.Empty;
                        descValidated = "Unknown Data";

                        txtDescription.Text = descValidated;
                        txtCode.Text = codeValidated;
                        SetSWTextboxData(ds);
                    }
                }
                else
                {
                    ds = GetData();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        isValidated = true;
                        SetSWCodiData(ds);
                        SetSWTextboxData(ds);

                        txtCode.Text = codeValidated;
                        txtDescription.Text = descValidated;
                    }
                    else
                    {
                        isValidated = false;
                        txtDescription.Text = "Unknown Data - Wrong Code";

                        txtCode.BackColor = ErrorColor;
                        txtDescription.BackColor = ErrorColor;
                        this.txtCode.Focus();
                    }
                }
            }
        }
        private void SWCodi_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            dbManagement = new BaseDeDades();
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F2)
                {
                    obreCS();
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
