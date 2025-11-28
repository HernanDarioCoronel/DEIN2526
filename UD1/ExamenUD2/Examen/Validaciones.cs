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
    public partial class Validaciones : Form
    {
        private static string validarFecha = @"\d{2}/\d{2}/\d{4}";
        //private static string validarNeumatico = @"\d{2}/\d{2}/\d{4}";

        public Validaciones()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {

        }
    }
}
