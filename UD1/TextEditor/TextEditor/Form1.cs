using System;
using System.Drawing;
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
            this.setLabelDesc(sender as Control);
            this.Close();
        }

        private void edicionDeshacer_Click(object sender, EventArgs e)
        {
            this.setLabelDesc(sender as Control);
            ctEditor.Undo();
        }

        private void edicionCortar_Click(object sender, EventArgs e)
        {
            this.setLabelDesc(sender as Control);
            ctEditor.Cut();
        }

        private void edicionCopiar_Click(object sender, EventArgs e)
        {
            this.setLabelDesc(sender as Control);
            ctEditor.Copy();
        }

        private void edicionPegar_Click(object sender, EventArgs e)
        {
            this.setLabelDesc(sender as Control);
            ctEditor.Paste();
        }

        private void menuEdicion_DropDownOpening(object sender, EventArgs e)
        {
            this.setLabelDesc(sender as Control);
            this.edicionPegar.Enabled = Clipboard.ContainsText();
            this.edicionCopiar.Enabled = this.ctEditor.SelectionLength > 0;
            this.edicionCortar.Enabled = this.ctEditor.SelectionLength > 0;
        }

        private void formEditor_KeyDown(object sender, KeyEventArgs e)
        {
            this.setLabelDesc(sender as Control);
            if (e.KeyData == (Keys.Control | Keys.C) || e.KeyData == (Keys.Control | Keys.X))
            {
                this.btbarPegar.Enabled = Clipboard.ContainsText();
            }
        }

        private void opFuCourierNew_Click(object sender, EventArgs e)
        {
            this.setLabelDesc(sender as Control);
            this.ctEditor.Font = new Font("Courier new", ctEditor.Font.Size, ctEditor.Font.Style);
            this.opFuCourierNew.Checked = true;
            this.opFuPredeterminada.Checked = false;
            this.opFuArial.Checked = false;
        }

        private void opFuArial_Click(object sender, EventArgs e)
        {
            this.setLabelDesc(sender as Control);
            this.ctEditor.Font = new Font("Arial", ctEditor.Font.Size, ctEditor.Font.Style);
            this.opFuArial.Checked = true;
            this.opFuPredeterminada.Checked = false;
            this.opFuCourierNew.Checked = false;
        }

        private void opFuPredeterminada_Click(object sender, EventArgs e)
        {
            this.setLabelDesc(sender as Control);
            this.ctEditor.Font = new Font(SystemFonts.DefaultFont.FontFamily, ctEditor.Font.Size, ctEditor.Font.Style);
            this.opFuPredeterminada.Checked = true;
            this.opFuArial.Checked = false;
            this.opFuCourierNew.Checked = false;
        }

        private void opTam16_Click(object sender, EventArgs e)
        {
            this.setLabelDesc(sender as Control);
            this.ctEditor.Font = new Font(ctEditor.Font.FontFamily, 16, ctEditor.Font.Style);
            this.opTam16.Checked = true;
            this.opTam24.Checked = false;
            this.OpTam2Predeterminado.Checked = false;
        }

        private void opTam24_Click(object sender, EventArgs e)
        {
            this.setLabelDesc(sender as Control);
            this.ctEditor.Font = new Font(ctEditor.Font.FontFamily, 24, ctEditor.Font.Style);
            this.opTam24.Checked = true;
            this.opTam16.Checked = false;
            this.OpTam2Predeterminado.Checked = false;
        }

        private void OpTam2Predeterminado_Click(object sender, EventArgs e)
        {
            this.setLabelDesc(sender as Control);
            this.ctEditor.Font = new Font(ctEditor.Font.FontFamily, SystemFonts.DefaultFont.Size, ctEditor.Font.Style);
            this.OpTam2Predeterminado.Checked = true;
            this.opTam24.Checked = false;
            this.opTam16.Checked = false;
        }

        private void setLabelDesc(Control ctr)
        {
            if (ctr != null)
                this.toolStripStatusLabel1.Text = ctr.AccessibleDescription;
            else
                this.toolStripStatusLabel1.Text = "";
        }
    }
}
