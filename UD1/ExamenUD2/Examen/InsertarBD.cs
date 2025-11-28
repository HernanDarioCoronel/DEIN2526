using System;
using System.Windows.Forms;
using bd001_Manter01;

namespace Examen
{
    public partial class InsertarBD : Form
    {
        clsBD database;
        public InsertarBD()
        {
            InitializeComponent();
            this.database = new clsBD(Properties.Settings.Default.VehiculosConnectionString);
        }

        private void InsertarBD_Load(object sender, EventArgs e)
        {
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.tbMatricula.Text.Length < 1 || this.tbModelo.Text.Length < 1 || this.tbAño.Text.Length < 1 || this.tbMarca.Text.Length < 1)
            {
                MessageBox.Show("Se deben llenar todos los campos");
                return;
            }
            string query = String.Format("INSERT INTO Automoviles (matricula, marca, modelo, año) VALUES ('{0}', '{1}', '{2}', {3})",
                this.tbMatricula.Text,
                this.tbMarca.Text,
                this.tbModelo.Text,
                this.tbAño.Text
                );
            try
            {
                this.database.abrirBD();
                this.database.operacionsNonSelect(query);
                this.database.cerrarBD();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
