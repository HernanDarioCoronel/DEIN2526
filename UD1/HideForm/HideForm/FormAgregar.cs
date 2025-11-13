using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideForm
{
    public partial class FormAgregar : Form
    {
        internal int selectedRow = -1;

        public FormAgregar()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            FormList owner = this.Owner as FormList;
            if (selectedRow >= 0)
                Edit(selectedRow, owner);
            else
                Add(owner);

            this.Hide();
        }

        private void Edit(int index, FormList owner)
        {
            owner.dataGridView.Rows[index].Cells[0].Value = this.ctDenominacion.Text;
            owner.dataGridView.Rows[index].Cells[1].Value = this.ctBodega.Text;
            owner.dataGridView.Rows[index].Cells[2].Value = this.ctPrecio.Text;
            this.selectedRow = -1;
        }

        private void Add(FormList owner)
        {
            if (this.ctDenominacion.Text.Trim().Length < 1 ||
                this.ctBodega.Text.Trim().Length < 1 ||
                this.ctPrecio.Text.Trim().Length < 1)
            {
                // se podría validar mejor
                MessageBox.Show("Los Campos están Vacíos");
                return;
            }
            owner.dataGridView.Rows.Add(new object[] {
                    this.ctDenominacion.Text,
                    this.ctBodega.Text,
                    this.ctPrecio.Text
                });
        }

        internal void ClearFields()
        {
            this.ctBodega.Text = "";
            this.ctDenominacion.Text = "";
            this.ctPrecio.Text = "";
        }

        private void ctBodega_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.ctBodega.Text))
            {
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(ctDenominacion, "");
            }
        }

        private void ctDenominacion_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.ctDenominacion.Text))
            {
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(ctDenominacion, "");
            }
        }

        private void ctPrecio_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.ctPrecio.Text))
            {
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(ctDenominacion, "");
            }
        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {
            this.ctBodega.CausesValidation = true;
            this.ctDenominacion.CausesValidation = true;
            this.ctPrecio.CausesValidation = true;

            this.ctBodega.Validating += this.ctBodega_Validating;
            this.ctDenominacion.Validating += this.ctDenominacion_Validating;
            this.ctPrecio.Validating += this.ctPrecio_Validating;
        }
    }
}
