using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Secure_Core_Inherited_Control
{

    public enum TipusDada
    {
        Numero,
        Text,
        Codi
    }

    public class SWTextbox : TextBox
    {

        private TipusDada _DadaPermesa = TipusDada.Text;
        private string _NomCampBBDD = "";
        private bool _PermetVuit = true;
        private Color _ColorOriginal;
        private Color _ColorError = Color.Red;
        private bool _EsValid = true;

        public TipusDada DadaPermesa
        {
            get { return _DadaPermesa; }
            set { _DadaPermesa = value; }
        }

        public string NomCampBBDD
        {
            get { return _NomCampBBDD; }
            set { _NomCampBBDD = value; }
        }

        public bool PermetVuit
        {
            get { return _PermetVuit; }
            set { _PermetVuit = value; }
        }

        public bool EsValid
        {
            get { return _EsValid; }
            private set { _EsValid = value; }
        }

        public SWTextbox()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.Enter += new System.EventHandler(this.SWTextbox_Enter);
            this.Leave += new System.EventHandler(this.SWTextbox_Leave);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.SWTextbox_Validating);

            this.ResumeLayout(false);

        }

        private void SWTextbox_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.LightYellow;
        }

        private void SWTextbox_Enter(object sender, EventArgs e)
        {
            if (_EsValid)
            {
                this.BackColor = _ColorOriginal;
            }
        }

        private void SWTextbox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string text = this.Text.Trim();
            bool Validacio = true;

            if (!PermetVuit && text == string.Empty)
            {
                Validacio = false;
            }

            if (Validacio && DadaPermesa == TipusDada.Numero)
            {
                bool coincideix = Regex.IsMatch(text, @"^\d+$");
                if (!coincideix && text.Length > 0)
                {
                    Validacio = false;
                }
            }

            if (Validacio && DadaPermesa == TipusDada.Codi)
            {
                string patro = @"^[AEIOU][A-Z]{3}-\d{2}[13579]$";
                bool coincideix = Regex.IsMatch(text, patro);
                if (!coincideix && text.Length > 0)
                {
                    Validacio = false;
                }
            }

            _EsValid = Validacio;
            if (!Validacio)
            {
                this.BackColor = _ColorError;
                e.Cancel = true;
            }
            else
            {
                this.BackColor = _ColorOriginal;
            }
        }
    }
}
