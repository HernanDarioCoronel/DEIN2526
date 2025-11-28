using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class TraspasoDatos : Form
    {
        public TraspasoDatos()
        {
            InitializeComponent();
        }

        private void btnTraspaso_Click(object sender, EventArgs e)
        {
            fPrincipal owner = this.Owner as fPrincipal;
            owner.tbDestino.Text = this.tbOrigen.Text;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
