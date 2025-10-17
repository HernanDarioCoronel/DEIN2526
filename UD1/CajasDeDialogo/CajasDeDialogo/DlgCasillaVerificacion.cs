using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajasDeDialogo
{
    public partial class DlgCasillaVerificacion : Form
    {
        bool mayus = false;
        public DlgCasillaVerificacion()
        {
            InitializeComponent();
        }

        private void DlgCasillaVerificacion_Load(object sender, EventArgs e)
        {

        }

        private void cbConverMayus_CheckedChanged(object sender, EventArgs e)
        {
            mayus = this.cbConverMayus.Checked;
            this.ChangeTextCase();
        }

        private void ChangeTextCase()
        {
            this.ctTexto.Text = mayus ? this.ctTexto.Text.ToUpper() : this.ctTexto.Text.ToLower();
        }
        
        private void ctTexto_KeyUp(object sender, KeyEventArgs e)
        {
            this.ChangeTextCase();
            ctTexto.SelectionStart = ctTexto.Text.Length;
        }
    }
}
