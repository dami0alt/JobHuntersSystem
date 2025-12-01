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
    public partial class frmScreenCS : Form
    {
        protected BaseDeDades db;
        protected string _tableName;
        protected DataSet dts;

        public string IdSelected { get; set; }
        public frmScreenCS(string tableName)
        {
            InitializeComponent();
            _tableName = tableName;
        }
        protected Dictionary<string, string> GetValues()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

            foreach (Control ctrl in this.Controls)
            {
                if(ctrl is SWTextbox swc && !string.IsNullOrEmpty(swc.Text))
                {
                    keyValuePairs.Add(swc.DatabaseName, swc.Text);
                }                                
            }
            return keyValuePairs;
        }
        protected virtual void ConfigurateDataGridView()
        {
            foreach (DataGridViewColumn col in dgvData.Columns)
            {
                if (col.Name.ToLower().Substring(0, 2) == "id")
                {
                    col.Visible = false;
                }
            }
            //Setup 
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgvData.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            dgvData.DefaultCellStyle.Font = new Font("Century Gothic", 9);
            dgvData.DefaultCellStyle.BackColor = Color.White;
            dgvData.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            dgvData.AllowUserToAddRows = false;

        }
        private void BindControls()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is SWTextbox && ((SWTextbox)ctrl).DataBindings.Count == 0)
                {
                    ctrl.DataBindings.Add("Text", dts.Tables[0], ((SWTextbox)ctrl).DatabaseName);
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
        private void SWCodi_Validated(object sender, EventArgs e)
        {
            ((SWTextbox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }
        private void frmScreenCS_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            db = new BaseDeDades();
            dts = new DataSet();

            BindControls();
            dgvData.DataSource = null;
            ConfigurateDataGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> searchParameters = GetValues();
            UnbindControls();
            try
            {
                dts = db.GeneraConsultaCerca(_tableName, searchParameters);
                if(dts.Tables.Count > 0)
                {
                    dgvData.DataSource = dts.Tables[0];
                    ConfigurateDataGridView();
                    BindControls();
                }
                else
                {
                    dgvData.DataSource = null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error to search: {ex.Message}");
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                IdSelected
                this.Close();
            }

        }
    }
}
