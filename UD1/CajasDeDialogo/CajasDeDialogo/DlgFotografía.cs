using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajasDeDialogo
{
    public partial class DlgFotografía : Form
    {
        public DlgFotografía()
        {
            InitializeComponent();
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog DlgAbrir = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Filter = "Archivos de imagen (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png|Todos los archivos (*.*)|*.*",
                FilterIndex = 1,
                Title = "Seleccionar fotografía"
            };
            if(DlgAbrir.ShowDialog() == DialogResult.OK)
            {
                using (var stream = new FileStream(DlgAbrir.FileName, FileMode.Open, FileAccess.Read))
                {
                    pbFotografia.Image = Image.FromStream(stream);
                }
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }
    }
}
