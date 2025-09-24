using System;
using System.Windows.Forms;

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
        private static char ENTER = (char)13;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void CelsiusNud_Enter(object sender, EventArgs e)
        {
            this.CelsiusTbox.Select(0, int.MaxValue);
            this.selected = SelectedBoxEnum.CelsiusNud;
        }

        private void FarenheithNud_Enter(object sender, EventArgs e)
        {
            this.FarenheithTbox.Select(0, int.MaxValue);
            this.selected = SelectedBoxEnum.FarenheithNud;
        }

        private string ToCelsius(string f)
        {
            float value;
            if (float.TryParse(f, out value))
            {
                return ((value - 32) * 5 / 9).ToString("#.##");
            }
            throw new Exception("No es un número.");
        }

        private string ToFarenheith(string c)
        {
            float value;
            if (float.TryParse(c, out value))
            {
                return (value * 9 / 5 + 32).ToString("#.##");
            }
            throw new Exception("No es un número.");
        }

        private void CalcularBtn_Click(object sender, EventArgs e)=>Calcular();

        private void EnterPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ENTER)
            {
                Calcular();
            }
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
