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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DlgLogin loginForm = new DlgLogin();
            DialogResult dl = loginForm.ShowDialog();
            if (dl != DialogResult.OK)
            {
                this.Close();
            }
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DlgListaSimple dls = new DlgListaSimple();

            if (dls.ShowDialog() == DialogResult.OK)
            {
                this.ctPrincipal.Text = dls.lbCoches.SelectedItem.ToString();
            }
            dls.Dispose();
        }

        private void casillaDeVerificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DlgCasillaVerificacion dcv = new DlgCasillaVerificacion();
            dcv.ShowDialog();
            dcv.Dispose();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DlgFotografía df = new DlgFotografía();
            df.ShowDialog();
        }
    }
}
