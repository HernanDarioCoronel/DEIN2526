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

namespace Componentes3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Color color = new Color();



        public MainWindow()
        {
            InitializeComponent();
        }

        private void sliderR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            color.R = (byte)sliderR.Value;
            sliderR.TextBoxColor = Color.FromRgb((byte)sliderR.Value, 0, 0);
        }

        private void sliderG_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            color.G = (byte)sliderG.Value;
            sliderG.TextBoxColor = Color.FromRgb(0, (byte)sliderG.Value, 0);
        }

        private void sliderB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            color.B = (byte)sliderB.Value;
            sliderB.TextBoxColor = Color.FromRgb(0, 0, (byte)sliderB.Value);
        }
    }
}