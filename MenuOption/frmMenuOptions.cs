using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MenuOption
{
    public partial class frmMenuOptions : ManagementForms.frmBase
    {
        private string _tableName = "UserOptions";

        public frmMenuOptions()
        {
            InitializeComponent();
            base._tableName = _tableName;

        }
        protected override void GetData()
        {
            base.GetData();
            dts.Tables[0].DefaultView.Sort = "RenderingOrder ASC";
        }
        protected override void ConfigurateDataGridView()
        {
            base.ConfigurateDataGridView();

            dgtData.Columns["RenderingOrder"].HeaderText = "Rendering Order";
            dgtData.Columns["dllName"].HeaderText = "DLL Name";
            dgtData.Columns["FormName"].HeaderText = "Form Name";
            dgtData.Columns["PicturePathMain"].HeaderText = "Main Icon Path";
            dgtData.Columns["PicturePathHover"].HeaderText = "Hover Icon Path";
            dgtData.Columns["BackColorMain"].HeaderText = "Background Color";
            dgtData.Columns["BackColorHover"].HeaderText = "Hover Background Color";
            dgtData.Columns["FontColorMain"].HeaderText = "Font Color";
            dgtData.Columns["FontColorHover"].HeaderText = "Hover Font Color";
            dgtData.Columns["Description"].HeaderText = "Description";
            dgtData.Columns["AccesLevel"].HeaderText = "Access Level";

            dgtData.Columns["idControl"].Visible = false;
        }
        protected override void NewRegister()
        {
          
            base.NewRegister();
            if (string.IsNullOrEmpty(SWtxtRenderingOrder.Text))
            {
                List<int> ListOrders = new List<int>();
                foreach (DataRow row in dts.Tables[0].Rows)
                {
                    if (int.TryParse(row["RenderingOrder"].ToString(), out int order))
                    {
                        ListOrders.Add(order);
                    }
                }
                int renderingOrderSeted = 1;
                if (ListOrders.Count > 0)
                {
                    ListOrders.Sort();

                    renderingOrderSeted = ListOrders[ListOrders.Count - 1] + 1;
                }

                int index = dts.Tables[0].Rows.Count - 1;
                dts.Tables[0].Rows[index]["RenderingOrder"] = renderingOrderSeted;
            }
        }
        private void SWtxtRenderingOrder_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(SWtxtRenderingOrder.Text))
            {
                List<int> List = new List<int>();
                foreach (DataRow row in dts.Tables[0].Rows)
                {
                    int order = Convert.ToInt32(row["RenderingOrder"]);
                    List.Add(order);
                }
                List.Sort();
                int renderingOrderSeted = List[List.Count - 1] + 1;
                SWtxtRenderingOrder.Text = renderingOrderSeted.ToString();
            }
        }
    }
}
