
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Input
{
    /// <summary>
    /// Lógica de interacción para LabeledSlider.xaml
    /// </summary>
    public partial class LabeledSlider : UserControl
    {
        public LabeledSlider()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(int), typeof(LabeledSlider),
                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnValueChangedStatic));
        public static readonly DependencyProperty MinValueProperty =
            DependencyProperty.Register("MinValue", typeof(int), typeof(LabeledSlider), new PropertyMetadata(-100));
        public static readonly DependencyProperty MaxValueProperty =
            DependencyProperty.Register("MaxValue", typeof(int), typeof(LabeledSlider), new PropertyMetadata(100));
        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(LabeledSlider), new PropertyMetadata("Label"));
        public static readonly DependencyProperty onValueChangeProperty =
            DependencyProperty.Register("onValueChange", typeof(RoutedEventHandler), typeof(LabeledSlider), new PropertyMetadata(null));
        public static readonly DependencyProperty TextBoxColorProperty =
            DependencyProperty.Register("TextBoxColor", typeof(Color), typeof(LabeledSlider), new PropertyMetadata(Color.FromRgb(0,0,0)));
        public static readonly RoutedEvent ValueChangedEvent =
            EventManager.RegisterRoutedEvent("ValueChanged", RoutingStrategy.Bubble,
                typeof(RoutedPropertyChangedEventHandler<double>), typeof(LabeledSlider));

        private static void OnValueChangedStatic(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (LabeledSlider)d;
            var args = new RoutedPropertyChangedEventArgs<double>((int)e.OldValue, (int)e.NewValue, ValueChangedEvent);
            control.RaiseEvent(args);
        }

        public event RoutedPropertyChangedEventHandler<double> ValueChanged
        {
            add { AddHandler(ValueChangedEvent, value); }
            remove { RemoveHandler(ValueChangedEvent, value); }
        }

        public int MinValue
        {
            get => (int)GetValue(MinValueProperty);
            set => SetValue(MinValueProperty, value);
        }
        public int MaxValue
        {
            get => (int)GetValue(MaxValueProperty);
            set => SetValue(MaxValueProperty, value);
        }
        public int Value
        {
            get => (int)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }
        public string Label
        {
            get => (string)GetValue(LabelProperty);
            set => SetValue(LabelProperty, value);
        }
        public Color TextBoxColor
        {
            get => (Color)GetValue(TextBoxColorProperty);
            set => SetValue(TextBoxColorProperty, value);
        }
    }
}
