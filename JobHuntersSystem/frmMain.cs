using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHuntersSystem
{
    public partial class frmMain : Form
    {
        private int _AccessLevelUser = 80;
        public List<Dictionary<string, string>> Colors = new List<Dictionary<string, string>>
        {
            new Dictionary<string, string>
            {
                { "Descripcion", "Blue" },
                { "AccesLevel", "50" },
                { "ClassName", "Colors.dll" },
                { "NamespaceForm", "Colors.Blue" }
            },
            new Dictionary<string, string>
            {
                { "Descripcion", "Red" },
                { "AccesLevel", "80" },
                { "ClassName", "Colors.dll" },
                { "NamespaceForm", "Colors.Red" }
            },
            new Dictionary<string, string>
            {
                { "Descripcion", "Orange" },
                { "AccesLevel", "90" },
                { "ClassName", "Colors.dll" },
                { "NamespaceForm", "Colors.Orange" }
            },
            new Dictionary<string, string>
            {
                { "Descripcion", "Green" },
                { "AccesLevel", "20" },
                { "ClassName", "Colors.dll" },
                { "NamespaceForm", "Colors.Green" }
            }
        };


        public frmMain()
        {
            InitializeComponent();
            foreach(var item in Colors)
            {
                int AccessLevel = int.Parse(item["AccesLevel"]);
                if(_AccessLevelUser >= AccessLevel)
                {
                    flpOptions.Controls.Add(new SWUserControls.SWLauchForm
                    { 
                        Description = item["Descripcion"],
                        Class = item["ClassName"],
                        Form = item["NamespaceForm"]
                    });
                }
            }
        }

        private void swLauchForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
