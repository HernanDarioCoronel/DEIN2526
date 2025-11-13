using System;
using System.Windows.Forms;

namespace HideForm
{
    public partial class FormList : Form
    {
        FormAgregar fAgregar;

        public FormList()
        {
            InitializeComponent();
        }

        private void FormList_Load(object sender, EventArgs e)
        {
            fAgregar = new FormAgregar();
            fAgregar.Owner = this;

            this.dataGridView.Rows.Add(new object[] { "Faustino VII", "Bodegas Faustino", 3.75 });
            this.dataGridView.Rows.Add(new object[] { "Viña Romana", "Adega Algueira", 6.90 });
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            this.ctCerrar.Enabled = true;
            fAgregar.ClearFields();
            fAgregar.Show();
        }

        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("no se cambiará nada en el formulario hijo");
                return;
            }
            DataGridViewRow row = this.dataGridView.Rows[e.RowIndex];

            fAgregar.Show();
            fAgregar.selectedRow = e.RowIndex;
            fAgregar.ctDenominacion.Text = row.Cells[0].Value.ToString();
            fAgregar.ctBodega.Text = row.Cells[1].Value.ToString();
            fAgregar.ctPrecio.Text = row.Cells[2].Value.ToString();
        }

        private void ctCerrar_Click(object sender, EventArgs e)
        {
            fAgregar.Hide();
        }
    }
}
