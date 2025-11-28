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
    public partial class fPrincipal : Form
    {
        private static string readyStatus = "Listo";
        private static string pwdStatus = "Chequeo contraseña";
        TraspasoDatos traspasoForm;
        public fPrincipal()
        {
            InitializeComponent();
            this.toolStripStatusLabel1.Text = readyStatus;
            traspasoForm = new TraspasoDatos();
            traspasoForm.Owner = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbDestino_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            traspasoForm.tbDestino.Text = this.tbOrigen.Text;
            traspasoForm.Show();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = pwdStatus;

        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = readyStatus;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (this.tbContraseña.Text == Properties.Resources.password)
            {
                this.label2.BackColor = Color.Green;
            }
            else
            {
                this.label2.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Combinaciones combinaciones = new Combinaciones();
            combinaciones.ShowDialog();
        }

        private void basesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarBD insertar = new InsertarBD();
            insertar.ShowDialog();
        }

        private void btnCargaFichero_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofl = new OpenFileDialog();
            ofl.InitialDirectory = @"C:\Users\cor___her\Documents\";
            ofl.DefaultExt = ".bmp, .jpg, .png";
            ofl.Filter = "Bitmap (.bmp)|*.bmp | jpeg (.jpg)|.jpg | png (.png)|*.png | Todos los archivos|*";
            ofl.ShowDialog();
            this.tbRuta.Text = ofl.FileName;
        }

        private void btnExpReg_Click(object sender, EventArgs e)
        {
            Validaciones validaciones = new Validaciones();

            validaciones.ShowDialog();
        }
    }
}
