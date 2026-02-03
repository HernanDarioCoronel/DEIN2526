using DbConnection.Classes.Entities;
using DbConnection.Classes.Utils;
using System.Data;
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
        private ClsBD miBD;
        private List<Persona> listaPersonas;
        public MainWindow()
        {
            InitializeComponent();
            string dbPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "premios_nobel.db");
            miBD = new ClsBD(dbPath);
            miBD.abrirBD(false);
            listaPersonas = GetData();
        }

        /** 
         To Do:
            - Fixear overflow de textos
            - No se ve el titulo en las páginas
            - usar grid como contenedor de páginas         
         */

        private void DocContent_Loaded(object sender, RoutedEventArgs e)
        {
            GenerateDocument();
        }

        private List<Persona> GetData()
        {
            DataSet datosPersonas = this.miBD.operacionsSelect("SELECT id, nombre, vida, areas, biografia FROM personas");
            List<Persona> personas = new List<Persona>();
            try
            {
                foreach (DataRow row in datosPersonas.Tables[0].Rows)
                {
                    Persona persona = new Persona(
                        Convert.ToInt32(row["id"]),
                        row["nombre"].ToString()!,
                        row["vida"].ToString()!,
                        row["areas"].ToString()!,
                        row["biografia"].ToString()!,
                        GetPremiosByPersonaId(row["id"].ToString()!)
                    );
                    personas.Add(persona);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las personas: \n" + ex.Message);
            }
            return personas;
        }

        private List<Premio> GetPremiosByPersonaId(string personaId)
        {
            string sql = "SELECT razon, anio, nombre_premios.nombre FROM premios JOIN nombre_premios WHERE premios.nombre = nombre_premios.id and persona_id = " + personaId;
            DataSet datosPremios = this.miBD.operacionsSelect(sql);
            List<Premio> premios = new List<Premio>();
            try
            {
                foreach (DataRow row in datosPremios.Tables[0].Rows)
                {
                    Premio premio = new Premio(
                        row["razon"].ToString()!,
                        row["nombre"].ToString()!,
                        Convert.ToInt32(row["anio"])
                    );
                    premios.Add(premio);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los premios: \n" + ex.Message);
            }
            return premios;
        }

        private void GenerateDocument()
        {
            foreach (var p in listaPersonas.Chunk(2))
            {
                FixedPage page = CreateNewPage(p[0], p.Length == 2 ? p[1] : null);
                DocContent.Pages.Add(new PageContent()
                {
                    Child = page
                });
            }
        }

        private FixedPage CreateNewPage(Persona p1, Persona? p2)
        {
            TextBlock titleTextBlock = new TextBlock()
            {
                Style = (Style)FindResource("h1"),
                Text = title,
            };


            StackPanel content = new StackPanel()
            {
                Children =
                {
                    FormatPersona(p1),
                    new Separator(),
                    p2 != null ? FormatPersona(p2): new StackPanel()
                }
            };
            StackPanel pageContent = new StackPanel()
            {
                Children =
                {
                    titleTextBlock,
                    new Separator(),
                    content
                }
            };

            FixedPage fixedPage = new FixedPage()
            {
                Width = pageWidth,
                Height = pageHeight,
                Children =
                {
                    pageContent
                }
            };

            return fixedPage;
        }

        private StackPanel FormatPersona(Persona p)
        {
            TextBlock Nombre = new TextBlock()
            {
                Style = (Style)FindResource("h2"),
                Text = $"{p.Nombre} ({p.Vida})",
            };
            TextBlock Areas = new TextBlock()
            {
                Style = (Style)FindResource("h4"),
                Text = p.Areas,
            };
            StackPanel PremiosStack = new StackPanel();
            if (p.Premios.Count > 0)
            {
                PremiosStack.Margin = new Thickness(0, 0, 0, 20);
                PremiosStack.Children.Add(new TextBlock()
                {
                    Style = (Style)FindResource("h3"),
                    Text = "Premios:",
                });
                foreach (Premio premio in p.Premios)
                {
                    TextBlock premioTextBlock = new TextBlock()
                    {
                        Style = (Style)FindResource("p"),
                        Text = $"{premio.Anio} - {premio.Nombre}: {premio.Razon}",
                    };
                    PremiosStack.Children.Add(premioTextBlock);
                }
            }
            StackPanel Biografia = new StackPanel()
            {
                Margin = new Thickness(0, 0, 0, 20),
                Children =
                {
                    new TextBlock()
                    {
                        Style = (Style)FindResource("h3"),
                        Text = "Biografía:",
                    },
                    new ScrollViewer()
                    {
                        VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                        Height = 200,
                        Content =
                            new TextBlock()
                            {
                                Style = (Style)FindResource("p"),
                                Text = p.Biografia,
                                TextWrapping = TextWrapping.Wrap,

                            }
                    }
                }
            };
            return new StackPanel()
            {
                Children =
                {
                    Nombre,
                    PremiosStack,
                    Areas,
                    Biografia
                }
            };
        }
    }
}