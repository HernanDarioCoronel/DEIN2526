using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Regex regex;
        private double a;
        private string symbol;

        public MainWindow()
        {
            InitializeComponent();

            this.regex = new Regex(@"^[-]?[0-9]*([.][0-9]*)?$");
        }

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            Button pressed = (Button)sender;

            if (!this.regex.IsMatch(this.cuentaCt.Text + pressed.Content.ToString()))
            {
                e.Handled = true;
                return;
            }
            this.cuentaCt.Text += pressed.Content.ToString();
        }

        private void DeleteAll_Click(object sender, RoutedEventArgs e)
        {
            this.a = 0;
            this.cuentaCt.Text = "";
        }

        private void Symbol_Click(object sender, RoutedEventArgs e)
        {
            double number;
            if (double.TryParse(this.cuentaCt.Text, out number))
            {
                this.a = number;
                this.symbol = (sender as Button).Content.ToString();
                this.cuentaCt.Text = "";
                toggleDiabledOperators(false);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void SingleOperator_Click(object sender, RoutedEventArgs e)
        {
            double number;
            if (double.TryParse(this.cuentaCt.Text, out number))
            {
                switch ((sender as Button).Content.ToString())
                {
                    case "±":
                        number *= -1;
                        break;
                    case "%":
                        number /= 100;
                        break;
                    case "Sen":
                        number = Math.Sin(number);
                        break;
                    case "Cos":
                        number = Math.Cos(number);
                        break;
                    case "Tan":
                        number = Math.Tan(number);
                        break;
                    default:
                        MessageBox.Show("Error");
                        break;
                }
                a = number;
                this.cuentaCt.Text = a.ToString();
            }
            else
                MessageBox.Show("Error");

        }

        private void igual_Click(object sender, RoutedEventArgs e)
        {
            double number;
            if (double.TryParse(this.cuentaCt.Text, out number))
                switch (symbol)
                {
                    case "/":
                        a /= number;
                        break;
                    case "*":
                        a *= number;
                        break;
                    case "-":
                        a -= number;
                        break;
                    case "+":
                        a += number;
                        break;
                    default:
                        MessageBox.Show("Error");
                        break;
                }
            else
                MessageBox.Show("Error");
            this.cuentaCt.Text = a.ToString();
            this.toggleDiabledOperators(true);

        }

        private void toggleDiabledOperators(bool isEnabled)
        {
            this.menos.IsEnabled = isEnabled;
            this.mas.IsEnabled = isEnabled;
            this.masMenos.IsEnabled = isEnabled;
            this.multiplicar.IsEnabled = isEnabled;
            this.dividir.IsEnabled = isEnabled;
            this.porcentaje.IsEnabled = isEnabled;
            this.seno.IsEnabled = isEnabled;
            this.coseno.IsEnabled = isEnabled;
            this.tangente.IsEnabled = isEnabled;
        }

        private void toggleDisableEquals(bool isEnabled)
        {
            this.igual.IsEnabled = isEnabled;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.
        }
    }
}
