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
        protected string _tableName, _controlId, _formName;
        protected DataSet dts;
        protected SWTextbox txt = new SWTextbox();
        public frmScreenCS(string tableName, string formName, string controlId)
        {
            InitializeComponent();
            _tableName = tableName;
            _controlId = controlId;
            _formName = formName;

        }
        protected Dictionary<string, string> GetValues()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            
            foreach (Control ctrl in this.Controls)
            {
                if(ctrl is SWTextbox && !string.IsNullOrEmpty(txt.Text))
                {
                    keyValuePairs.Add(txt.DatabaseName, txt.Text);
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
        private void frmScreenCS_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            db = new BaseDeDades();
            dts = new DataSet();

            dgvData.DataSource = null;
            ConfigurateDataGridView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmScreenCS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                this.Close();
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> searchParameters = GetValues();
            try
            {
                dts = db.GeneraConsultaCerca(_tableName, searchParameters);
                if(dts.Tables.Count > 0)
                {
                    dgvData.DataSource = dts.Tables[0];
                    ConfigurateDataGridView();
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
            searchParameters.Clear();
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string idSelected = dgvData.Rows[e.RowIndex].Cells[0].Value.ToString();

                foreach (Form frm in Application.OpenForms)
                {                        
                    if (frm.Name == _formName)
                    {
                        foreach (Control ctrl in frm.Controls)
                        {
                            if(ctrl.Name == _controlId)
                            {
                                ((SWTextbox)ctrl).SetId(idSelected);
                            }
                        }
                        break;
                    }                   
                }               
                this.Close();
            }
        }
    }
}
