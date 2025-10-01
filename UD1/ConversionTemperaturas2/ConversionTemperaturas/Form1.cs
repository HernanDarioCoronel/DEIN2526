using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace ConversionTemperaturas
{
    public partial class Form1 : Form
    {
        private enum SelectedBoxEnum
        {
            CelsiusNud,
            FarenheithNud
        }
        private SelectedBoxEnum selected;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void CelsiusTbox_Enter(object sender, EventArgs e)
        {
            this.CelsiusTbox.Select(0, int.MaxValue);
            this.selected = SelectedBoxEnum.CelsiusNud;
        }

        private void FarenheithTbox_Enter(object sender, EventArgs e)
        {
            this.FarenheithTbox.Select(0, int.MaxValue);
            this.selected = SelectedBoxEnum.FarenheithNud;
        }

        private string ToCelsius(string f)
        {
            float value;
            if (!float.TryParse(f, out value))
                throw new Exception("No es un número.");

            float result = (value - 32) * 5 / 9;
            return result == 0 ? "0,00" : result.ToString("F2");
        }

        private string ToFarenheith(string c)
        {
            float value;

            if (!float.TryParse(c, out value))
                throw new Exception("No es un número.");

            float result = value * 9 / 5 + 32;
            return result == 0 ? "0,00" : result.ToString("F2");
        }

        private void CalcularBtn_Click(object sender, EventArgs e) => Calcular();

        private void Tbox_Press(object sender, KeyPressEventArgs e)
        {
            TextBox tbox = sender as TextBox;
            errorProvider1.SetError(tbox, null);

            if (e.KeyChar == (char)Keys.Enter)
            {
                Calcular();
                return;
            }

            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!tbox.Text.Contains(",") && e.KeyChar == ',')
            {
                return;
            }

            if ((e.KeyChar == '-' || e.KeyChar == '+') && tbox.SelectionStart == 0)
            {
                return;
            }

            e.Handled = true;
            return;
        }

        private void Calcular()
        {
            try
            {
                switch (this.selected)
                {
                    case SelectedBoxEnum.CelsiusNud:
                        FarenheithTbox.Text = ToFarenheith(CelsiusTbox.Text);
                        break;
                    case SelectedBoxEnum.FarenheithNud:
                        CelsiusTbox.Text = ToCelsius(FarenheithTbox.Text);
                        break;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void Tbox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;
            try
            {
                float validated = float.Parse(tb.Text);
            }
            catch (ArgumentNullException)
            {
                errorProvider1.SetError(tb, "El campo está vacío.");
                e.Cancel = true;
            }
            catch (FormatException)
            {
                errorProvider1.SetError(tb, "No es un número.");
                e.Cancel = true;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }

}
