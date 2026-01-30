using DbConnection.Classes.Utils;
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

namespace DbConnection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int pageHeight = 1123;
        private int pageWidth = 794;
        private string title = "LISTADO ACTUALIZADO DE PREMIOS NOBEL";
        private string premios_sql = "SELECT razon, anio, nombre_premios.nombre FROM premios JOIN nombre_premios WHERE premios.nombre = nombre_premios.id and persona_id = ";
        private string persona_sql = "SELECT id, nombre, vida, areas, biografia FROM personas";
        private ClsBD miBD;
        public MainWindow()
        {
            InitializeComponent();
            miBD = new ClsBD("/Resources/premios_nobel.db");
            miBD.abrirBD();// TO DO: fix route
        }

        private void DocumentViewer_Loaded(object sender, RoutedEventArgs e)
        {

        }

        public FixedPage CreateNewPage()
        {
            TextBlock titleTextBlock = new TextBlock()
            {
                Style = (Style)FindResource("h1"),
                Text = title,
            };

            FixedPage fixedPage = new FixedPage()
            {
                Width = pageWidth,
                Height = pageHeight,
                Children =
                {
                    titleTextBlock,
                    new Separator()
                }
            };

            return fixedPage;
        }
    }
}