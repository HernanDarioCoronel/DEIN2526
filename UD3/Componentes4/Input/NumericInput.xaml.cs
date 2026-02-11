using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Input
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class NumericInput : UserControl
    {
        public NumericInput()
        {
            InitializeComponent();
        }



        private void btPlus_click(object sender, RoutedEventArgs e)
        {
            if (Value + JumpValue <= MaxValue)
                Value += JumpValue;
        }

        private void btMinus_click(object sender, RoutedEventArgs e)
        {
            if (Value - JumpValue >= MinValue)
                Value -= JumpValue;
        }

        private void valor_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            string fullText = tb.Text.Insert(tb.SelectionStart, e.Text);

            e.Handled = !(float.TryParse(fullText,
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out float result));
        }


        public static readonly DependencyProperty ValueProperty =
                DependencyProperty.Register("Value", typeof(float), typeof(NumericInput),
                    new FrameworkPropertyMetadata(0f, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public static readonly DependencyProperty MinValueProperty =
            DependencyProperty.Register("MinValue", typeof(float), typeof(NumericInput), new PropertyMetadata(0f));

        public static readonly DependencyProperty MaxValueProperty =
            DependencyProperty.Register("MaxValue", typeof(float), typeof(NumericInput), new PropertyMetadata(100f));

        public static readonly DependencyProperty JumpValueProperty =
            DependencyProperty.Register("JumpValue", typeof(float), typeof(NumericInput), new PropertyMetadata(1f));

        public static readonly DependencyProperty DecimalsProperty =
            DependencyProperty.Register("Decimals", typeof(int), typeof(NumericInput), new PropertyMetadata(2));

        public float MinValue
        {
            get => (float)GetValue(MinValueProperty);
            set => SetValue(MinValueProperty, value);
        }
        public float MaxValue
        {
            get => (float)GetValue(MaxValueProperty);
            set => SetValue(MaxValueProperty, value);
        }
        public float JumpValue
        {
            get => (float)GetValue(JumpValueProperty);
            set => SetValue(JumpValueProperty, value);
        }
        public float Value
        {
            get => (float)Math.Round((float)GetValue(ValueProperty), Decimals);
            set => SetValue(ValueProperty, value);
        }
        public int Decimals
        {
            get => (int)GetValue(DecimalsProperty);
            set => SetValue(DecimalsProperty, value);
        }
    }
}
