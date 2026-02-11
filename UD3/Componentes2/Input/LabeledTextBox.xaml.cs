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

namespace Input
{
    /// <summary>
    /// Interaction logic for LabeledTextBox.xaml
    /// </summary>
    public partial class LabeledTextBox : UserControl
    {
        public LabeledTextBox()
        {
            InitializeComponent();
            // Importante: Establecer el DataContext a sí mismo para que el XAML 
            // encuentre la propiedad que acabamos de crear.
            this.DataContext = this;
        }

        public static readonly DependencyProperty LabelTextProperty =
            DependencyProperty.Register(
                "LabelText",
                typeof(string),
                typeof(LabeledTextBox),
                new PropertyMetadata("Label:"));
        public static readonly DependencyProperty TextBoxWidthProperty =
            DependencyProperty.Register(
                "TextBoxWidth",
                typeof(int),
                typeof(LabeledTextBox),
                new PropertyMetadata(50));

        public static readonly DependencyProperty NomeProperty =
            DependencyProperty.Register(
                "Nome",
                typeof(string),
                typeof(LabeledTextBox),
                new PropertyMetadata(string.Empty));

        public string Nome
        {
            get { return (string)GetValue(NomeProperty); }
            set { SetValue(NomeProperty, value); }
        }
        public string LabelText
        {
            get { return (string)GetValue(LabelTextProperty); }
            set { SetValue(LabelTextProperty, value); }
        }
        public int TextBoxWidth
        {
            get { return (int)GetValue(TextBoxWidthProperty); }
            set { SetValue(TextBoxWidthProperty, value); }
        }
    }

}
