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
        public DataSet GetDataSWCodi()
        {
            DataSet _ds = new DataSet();
            string code = txtCode.Text;
            string query = $"SELECT {_NomDesc},{_NomId} FROM {_NomTaula} WHERE {_NomCodi}='{code}'";
            _ds = dbManagement.PortarPerConsulta(query);
            return _ds;
        }
        public DataSet GetDataSWTextbox(string idString)
        {
            DataSet _ds = new DataSet();
            if(int.TryParse(idString,out int id))
            {
                string query = $"SELECT {_NomDesc},{_NomCodi} FROM {_NomTaula} WHERE {_NomId}='{id}'";
                _ds = dbManagement.PortarPerConsulta(query);
            }
            return _ds;
        }

        private void SetSWTextboxData()
        {
            Form parentForm = this.FindForm();
            foreach(Control ctrl in parentForm.Controls)
            {
                if (ctrl.Name == _ControlID)
                {
                    ctrl.Text = ds.Tables[0].Rows[0][_NomId].ToString();
                }
            }
        }
        public void SetSWCodiData(DataSet _ds)
        {
            if (_ds != null && _ds.Tables.Count > 0 && _ds.Tables[0].Rows.Count > 0)
            {
                this.txtCode.Text = _ds.Tables[0].Rows[0][_NomCodi].ToString();
                this.txtDescription.Text = _ds.Tables[0].Rows[0][_NomDesc].ToString();

            }
            else
            {
                this.txtDescription.Text = "Unknown";
                this.txtCode.Clear();
            }
           
        }
        private void Validacodi(object sender, CancelEventArgs e)
        {
            ds = GetDataSWCodi();
            if (ds.Tables[0].Rows.Count > 0 && !string.IsNullOrEmpty(txtCode.Text))
            {
                txtDescription.Text = ds.Tables[0].Rows[0][_NomDesc].ToString();
                SetSWTextboxData();
            }
            else
            {
                txtDescription.Text = "Unknown Data";
                e.Cancel = true;
            }
        }
        private void SWCodi_Load(object sender, EventArgs e)
        {
            dbManagement = new BaseDeDades();
        }
    }
}
