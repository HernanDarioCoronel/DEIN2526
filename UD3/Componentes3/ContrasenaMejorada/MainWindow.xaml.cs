using System.Windows;
using System.Windows.Input;

namespace ContrasenaMejorada
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Eye_MouseEnter(object sender, MouseEventArgs e)
        {
            txtPasswordReveal.Text = pbPassword.Password;

            pbPassword.Visibility = Visibility.Collapsed;
            txtPasswordReveal.Visibility = Visibility.Visible;
        }

        private void Eye_MouseLeave(object sender, MouseEventArgs e)
        {
            pbPassword.Password = txtPasswordReveal.Text;

            txtPasswordReveal.Visibility = Visibility.Collapsed;
            pbPassword.Visibility = Visibility.Visible;
        }
    }
}