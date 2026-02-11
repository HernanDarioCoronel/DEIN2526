using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Componentes2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string usuario = UsuarioTextBox.Nome;
            string password = ContraseñaTextBox.Nome;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Error: El usuario y la contraseña no pueden estar vacíos.",
                                "Error de validación", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (usuario.Length < 4 || password.Length < 4)
            {
                MessageBox.Show("Error: El nombre de usuario y la contraseña deben tener al menos 4 caracteres.",
                                "Longitud insuficiente", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBox.Show($"Bienvenido, {usuario}. Accediendo al sistema...", "Éxito");
        }
    }
}