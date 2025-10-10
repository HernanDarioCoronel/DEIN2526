using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextEditor.Utils;

namespace TextEditor
{
    public partial class formEditor : Form
    {
        public formEditor()
        {
            InitializeComponent();

            this.btbarPegar.Enabled = Clipboard.ContainsText();

            Bitmap iconSalir = IconExtractor.GetShellIcon(131).ToBitmap();
            Bitmap iconFuente = IconExtractor.GetShellIcon(133).ToBitmap();
            Bitmap iconTam = IconExtractor.GetShellIcon(295).ToBitmap();
            Bitmap iconCortar = IconExtractor.GetShellIcon(259).ToBitmap();
            Bitmap iconCopiar = IconExtractor.GetShellIcon(134).ToBitmap();
            Bitmap iconPegar = IconExtractor.GetShellIcon(260).ToBitmap();
            Bitmap iconDeshacer = IconExtractor.GetShellIcon(295).ToBitmap();

            this.btbatCortar.Image = iconCortar;
            this.edicionCortar.Image = iconCortar;
            this.btbarCopiar.Image = iconCopiar;
            this.edicionCopiar.Image = iconCopiar;
            this.btbarPegar.Image = iconPegar;
            this.edicionPegar.Image = iconPegar;
            this.edicionDeshacer.Image = iconDeshacer;

            this.archivoSalir.Image = iconSalir;

            this.opcionesFuente.Image = iconFuente;
        }

        private void archivoSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edicionDeshacer_Click(object sender, EventArgs e)
        {
            ctEditor.Undo();
        }

        private void edicionCortar_Click(object sender, EventArgs e)
        {
            ctEditor.Cut();
        }

        private void edicionCopiar_Click(object sender, EventArgs e)
        {
            ctEditor.Copy();
        }

        private void edicionPegar_Click(object sender, EventArgs e)
        {
            ctEditor.Paste();
        }

        private void menuEdicion_DropDownOpening(object sender, EventArgs e)
        {
            this.edicionPegar.Enabled = Clipboard.ContainsText();
        }

        private void formEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.C) || e.KeyData == (Keys.Control | Keys.X))
            {
                this.btbarPegar.Enabled = Clipboard.ContainsText();
            }
        }

        private void opFuCourierNew_Click(object sender, EventArgs e)
        {
            this.ctEditor.Font = new Font("Courier new", ctEditor.Font.Size, ctEditor.Font.Style);
        }

        private void opFuArial_Click(object sender, EventArgs e)
        {
            this.ctEditor.Font = new Font("Arial", ctEditor.Font.Size, ctEditor.Font.Style);
        }

        private void opFuPredeterminada_Click(object sender, EventArgs e)
        {
            this.ctEditor.Font = new Font(SystemFonts.DefaultFont.FontFamily, ctEditor.Font.Size, ctEditor.Font.Style);
        }

        private void opTam16_Click(object sender, EventArgs e)
        {
            this.ctEditor.Font = new Font(ctEditor.Font.FontFamily, 16, ctEditor.Font.Style);
        }

        private void opTam24_Click(object sender, EventArgs e)
        {
            this.ctEditor.Font = new Font(ctEditor.Font.FontFamily, 24, ctEditor.Font.Style);
        }

        private void OpTam2Predeterminado_Click(object sender, EventArgs e)
        {
            this.ctEditor.Font = new Font(ctEditor.Font.FontFamily, SystemFonts.DefaultFont.Size, ctEditor.Font.Style);
        }
    }
}
