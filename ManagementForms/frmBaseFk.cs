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
using SecureCoreInheritedControl;

namespace ManagementForms
{
    public partial class frmBasefk : Form
    {
        protected string _tableName;
        protected List<string> _FkTableNames;

        BaseDeDades dbManager;
        Boolean _isNew = false;
        Boolean _creationMode = false;
        public frmBasefk()
        {
            InitializeComponent();
        }

        protected DataSet ds;
        private void GetTableData()
        {
            //Primero, obtenemos los datos de la tabla maestra
            ds = dbManager.PortarTaula(_tableName);

            //Cargamos DataTables a nuestro DataSet por cada elemento de nuestra lista
            if(_FkTableNames.Count > 0)
            {
                string query = "";
                foreach (var table in _FkTableNames)
                {
                    query = $"SELECT * FROM {table}";
                    ds = dbManager.AfegirDataTable(query,ds);
                }
            }
        }

        private void BindControls()
        {
            foreach (Control ctrl in this.Controls)
            {
                if(ctrl is SWTextbox && ((SWTextbox)ctrl).DataBindings.Count == 0)
                {
                    ctrl.DataBindings.Add("Text", ds.Tables[0], ((SWTextbox)ctrl).DatabaseName);
                    ctrl.Validated += new EventHandler(this.SWTextbox_Validated);
                }
            }
        }
        private void UnbindControls()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is SWTextbox && ((SWTextbox)ctrl).DataBindings.Count > 0)
                {
                    ctrl.DataBindings.Clear();
                    ((SWTextbox)ctrl).Text = "";
                    ctrl.Validated -= new EventHandler(this.SWTextbox_Validated);
                }
            }
        }
        private void UpdateRegisters()
        {
            string query = $"SELECT * FROM {_tableName}";
            if (_isNew)
            {
                NewRegister();
                _creationMode = false;
                _isNew = false;

                btnCreate.Text = "Create";
                btnCreate.ForeColor = Color.FromArgb(38, 38, 38);
            }
            else
            {
                UnbindControls();
            }

            dbManager.Actualitzar(query, ds);

            ds = dbManager.PortarTaula(_tableName);

            timerInfo.Start();
            lblInfo.ForeColor = Color.LightGreen;
            lblInfo.Visible = true;
            lblInfo.Text = "Registers Updated !!";

            BindControls();
            dgtData.DataSource = ds.Tables[0];
        }
        protected virtual void NewRegister()
        {
            DataRow row; 
            row = ds.Tables[0].NewRow();

            foreach (Control ctrl in this.Controls)
            {
                if(ctrl is SWTextbox)
                {
                    string value = ctrl.Text;
                  
                    if (string.IsNullOrEmpty(value))
                    {
                        if (((SWTextbox)ctrl).NullSpace)
                        {
                            row[((SWTextbox)ctrl).DatabaseName] = DBNull.Value;
                        }
                        else
                        {
                            lblInfo.Visible = true;
                            throw new ArgumentException($"The required fields are empty, please verify...");
                        }
                    }
                    else
                    {
                        row[((SWTextbox)ctrl).DatabaseName] = value;
                    }
                }
            }
            ds.Tables[0].Rows.Add(row);     
        }
    
        protected virtual void ConfigurateDataGridView()
        {
            foreach (DataGridViewColumn col in dgtData.Columns)
            {
                if (col.Name.ToLower().Substring(0, 2) == "id")
                {
                    col.Visible = false;
                }
            }
            //Setup 
            dgtData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgtData.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            dgtData.DefaultCellStyle.Font = new Font("Century Gothic", 9);
            dgtData.DefaultCellStyle.BackColor = Color.White;
            dgtData.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgtData.AllowUserToAddRows = false;
            //dgtData.RowHeadersVisible = false;

        }
        private void frmBase_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            dbManager = new BaseDeDades();

            GetTableData();

            BindControls();
            dgtData.DataSource = ds.Tables[0];
            ConfigurateDataGridView();
            lblTableName.Text = _tableName;
        }
        private void SWTextbox_Validated(object sender, EventArgs e)
        {
            ((SWTextbox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }
     
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!_creationMode)
            {
                UnbindControls();
                _creationMode = true;
                _isNew = true;

                btnCreate.Text = "Cancel";
                btnCreate.ForeColor = Color.Red;
            }
            else
            {
                BindControls();
                _creationMode = false;
                _isNew = false;

                btnCreate.Text = "Create";
                btnCreate.ForeColor = Color.FromArgb(38,38,38);
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateRegisters();
            }catch(Exception ex)
            {
                timerInfo.Start();
                lblInfo.ForeColor = Color.LightSalmon;
                lblInfo.Text = ex.Message;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerInfo_Tick(object sender, EventArgs e)
        {
            timerInfo.Stop();
            lblInfo.Visible = false;
            timerInfo.Dispose();
        }
    }
}
