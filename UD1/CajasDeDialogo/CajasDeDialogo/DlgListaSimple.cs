using System;
using System.Windows.Forms;

namespace CajasDeDialogo
{
    public partial class DlgListaSimple : Form
    {
        public DlgListaSimple()
        {
            InitializeComponent();
        }

        private void ctAñadir_Click(object sender, EventArgs e)
        {
            object selectedItem = this.lsLista1l.SelectedItem;
            foreach (object item in lbCoches.Items)
                if (item.ToString() == selectedItem.ToString())
                    return;
            this.lbCoches.Items.Contains(selectedItem);
            this.lbCoches.Items.Add(selectedItem);
        }

        private void lsLista1l_SelectedValueChanged(object sender, EventArgs e)
        {
            this.ctAñadir.Enabled = this.lsLista1l.SelectedItem != null;
        }

        private void lbCoches_SelectedValueChanged(object sender, EventArgs e)
        {
            object seleccion = lbCoches.SelectedItem;
            bool somethingSelected = seleccion != null;

            this.btBorrar.Enabled = somethingSelected;
            this.btAceptar.Enabled = somethingSelected;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            object selectedText = this.lbCoches.SelectedItem;
            int index = this.lbCoches.Items.IndexOf(selectedText);
            if (index >= 0)
                this.lbCoches.Items.RemoveAt(index);
        }
    }
}
