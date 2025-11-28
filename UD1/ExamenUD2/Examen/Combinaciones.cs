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
    public partial class Combinaciones : Form
    {
        public Combinaciones()
        {
            InitializeComponent();
        }

        private void tbOrigen_KeyDown(object sender, KeyEventArgs e)
        {
            this.tbCaracter.Text = e.KeyCode != Keys.None ? e.KeyCode.ToString() : "";
            this.tbModificador.Text = e.Modifiers != Keys.None ? e.Modifiers.ToString() : "";
        }

        private void tbOrigen_KeyUp(object sender, KeyEventArgs e)
        {
            this.tbCaracter.Text = "";
            this.tbModificador.Text = "";
        }
    }
}
