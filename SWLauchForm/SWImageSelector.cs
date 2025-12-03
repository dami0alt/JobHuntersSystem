using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace SWUserControls
{
    public partial class ImageSelector : UserControl
    {
        private string ctrlName;

        public string CtrlName
        {
            get { return ctrlName; }
            set { ctrlName = value; }
        }

        private string destinationPath;

        public string DestinationPath
        {
            get { return destinationPath; }
            set { destinationPath = value; }
        }


        public ImageSelector()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();


            ofd.Title = "Selecciona un archivo";
            ofd.Filter = "Image Files (*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG)|*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG|All files (*.*)|*.*";
            string ogFilePath;
            string appPath = destinationPath;


            if (ofd.ShowDialog() == DialogResult.OK)
            {

                ogFilePath = ofd.FileName;
                string FileName = Path.GetFileName(ogFilePath);
                appPath += FileName;

                if (!File.Exists(appPath))
                {
                    File.Copy(ogFilePath, appPath, false);
                }

                foreach (Control ctrl in this.Parent.Controls)
                {
                    if (ctrl.Name.Equals(ctrlName))
                    {
                        ctrl.Focus();
                        ctrl.Text = appPath;
                    }
                }
            }
        }
        public void SetPhoto(string path)
        {
            pbSelectedImage.ImageLocation = path;
        }
    }
}
