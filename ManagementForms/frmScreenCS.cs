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
using System.Runtime.InteropServices;

namespace ManagementForms
{
    public partial class frmScreenCS : Form
    {
        protected BaseDeDades db;
        protected string _tableName, _controlId, _formName;
        protected DataSet dts;

        private Cursor customCursor;
        #region cursor(Opcional)
        [DllImport("user32.dll")]
        public static extern IntPtr LoadCursorFromFile(string lpFileName);
        string cursorPath = "Multimedia/ani/Busy.ani";
        #endregion

        private int loadingStep = 0;

        Dictionary<string, string> searchParameters;

        public frmScreenCS()
        {
            InitializeComponent();
        }
        public frmScreenCS(string tableName, string formName, string controlId)
        {
            InitializeComponent();
            if (DesignMode) return;
            _tableName = tableName;
            _controlId = controlId;
            _formName = formName;

        }
        private void LoadAniCursor()
        {
            cursorPath = AppDomain.CurrentDomain.BaseDirectory + cursorPath;
            IntPtr hCursor = LoadCursorFromFile(cursorPath);
            if (hCursor != IntPtr.Zero)
            {
                customCursor = new Cursor(hCursor);
                this.Cursor = customCursor;
            }
            else
            {
                MessageBox.Show("The cursor couldn't be loaded","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        protected Dictionary<string, string> GetValues()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            
            foreach (Control ctrl in this.Controls)
            {
                if(ctrl is SWTextbox && !string.IsNullOrEmpty(ctrl.Text))
                {
                    keyValuePairs.Add(((SWTextbox)ctrl).DatabaseName, ctrl.Text);
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
            dgvData.ForeColor = Color.Black;
            dgvData.AllowUserToAddRows = false;

        }
        private void frmScreenCS_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            try
            {
                LoadAniCursor();
                db = new BaseDeDades();
                dts = new DataSet();

                dgvData.DataSource = null;
                ConfigurateDataGridView();
                lblTableName.Text = _tableName + " Search";
            }
            catch (System.Data.Common.DbException ex)
            {
                MessageBox.Show("ERROR: Could not connect to the database.Please check the connection.\n" +
                                    $"Details: {ex.Message}", "Error Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmScreenCS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                this.Close();
                e.Handled = true;
            }
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            foreach(Control ctrl in this.Controls)
            {
                if(ctrl is SWTextbox)
                {
                    ((SWTextbox)ctrl).Clear();
                }
            }
            dgvData.DataSource = null;
        }

        private void timerinfo_Tick(object sender, EventArgs e)
        {
            loadingStep++;

            // Actualiza el texto con puntos
            lblInfo.Text = "Loading" + new string('.', loadingStep % 5);

            if (loadingStep >= 4)
            {
                timerInfo.Stop();
                lblInfo.Visible = false;
                pctGif3.Visible = false;
                try
                {
                    dts = db.GeneraConsultaCerca(_tableName, searchParameters);
                    if (dts.Tables.Count > 0)
                    {
                        dgvData.DataSource = dts.Tables[0];
                        ConfigurateDataGridView();
                    }
                    else
                    {
                        dgvData.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error to search: {ex.Message}");
                }

                searchParameters.Clear();
            }
        }

        private void frmScreenCS_FormClosed(object sender, FormClosedEventArgs e)
        {
           foreach(Control ctrl in this.Controls)
            {
                if(ctrl is PictureBox)
                {
                    if (((PictureBox)ctrl).Image != null)
                    {

                        ((PictureBox)ctrl).Image.Dispose();
                        ((PictureBox)ctrl).Image = null;
                    }
                }
            }
            customCursor.Dispose();
            customCursor = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                searchParameters = GetValues();
                loadingStep = 0;
                lblInfo.Text = "Loading";
                lblInfo.Visible = true;
                pctGif3.Visible = true;
                timerInfo.Start();
            }
            catch (System.Data.Common.DbException ex)
            {
                MessageBox.Show("ERROR: Could not connect to the database.Please check the connection.\n" +
                                    $"Details: {ex.Message}", "Error Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
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
