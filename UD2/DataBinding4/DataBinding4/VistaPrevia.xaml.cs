using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataBinding4
{
    public partial class VistaPrevia : Window
    {
        Persona miPersona = new Persona { Nombre = "Juan", Edad = 20, Estudiante = true };
        public VistaPrevia()
        {
            InitializeComponent();

            this.DataContext = miPersona;
        }

        private void BtnEditar_Click(object sender, RoutedEventArgs e)
        {
            VistaEdicion vEdicion = new VistaEdicion();

            vEdicion.DataContext = miPersona;

            vEdicion.Show();
        }
    }
}
