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

namespace DataBinding
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CambiarModo(object sender, RoutedEventArgs e)
        {
            if (txt1Bnd == null || txt2Bnd == null) return;

            RadioButton rb = sender as RadioButton;
            if (rb == null) return;
            
            Binding nuevoBinding = new Binding("Text");
            nuevoBinding.ElementName = "txt1Bnd";

            nuevoBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.ClearBinding(txt2Bnd, TextBox.TextProperty);

            switch (rb.Content.ToString())
            {
                case "One Time": nuevoBinding.Mode = BindingMode.OneTime; break;
                case "One Way": nuevoBinding.Mode = BindingMode.OneWay; break;
                case "Two Way": nuevoBinding.Mode = BindingMode.TwoWay; break;
                case "OneWay To Source": nuevoBinding.Mode = BindingMode.OneWayToSource; break;
            }
            txt2Bnd.SetBinding(TextBox.TextProperty, nuevoBinding);
        }
    }
}
