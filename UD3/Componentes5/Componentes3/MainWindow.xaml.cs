using System.Windows;
using System.Windows.Media;

namespace Componentes3
{
    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty ColorResultProperty =
            DependencyProperty.Register("ColorResult", typeof(SolidColorBrush), typeof(MainWindow),
                new PropertyMetadata(new SolidColorBrush(Colors.Black)));

        public SolidColorBrush ColorResult
        {
            get => (SolidColorBrush)GetValue(ColorResultProperty);
            set => SetValue(ColorResultProperty, value);
        }

        public MainWindow()
        {
            InitializeComponent();
            ActualizarColorFinal();
        }

        private void ActualizarColorFinal()
        {
            Color nuevoColor = Color.FromRgb(
                (byte)sliderR.Value,
                (byte)sliderG.Value,
                (byte)sliderB.Value);

            ColorResult = new SolidColorBrush(nuevoColor);
        }

        private void sliderR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sliderR == null) return;
            sliderR.TextBoxColor = Color.FromRgb((byte)e.NewValue, 0, 0);
            ActualizarColorFinal();
        }

        private void sliderG_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sliderG == null) return;
            sliderG.TextBoxColor = Color.FromRgb(0, (byte)e.NewValue, 0);
            ActualizarColorFinal();
        }

        private void sliderB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sliderB == null) return;
            sliderB.TextBoxColor = Color.FromRgb(0, 0, (byte)e.NewValue);
            ActualizarColorFinal();
        }
    }
}