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

namespace GestionDeProductos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            productImage.Source = new BitmapImage(new Uri("pack://application:,,,/GestionDeProductos;component/bin/Debug/rambutan.jpg", UriKind.Absolute));

            homeImg.Source = new BitmapImage(new Uri("pack://application:,,,/GestionDeProductos;component/bin/Debug/house-solid-full.jpg", UriKind.Absolute));
            userImg.Source = new BitmapImage(new Uri("pack://application:,,,/GestionDeProductos;component/bin/Debug/user-group-solid-full.jpg", UriKind.Absolute));
            productsImg.Source = new BitmapImage(new Uri("pack://application:,,,/GestionDeProductos;component/bin/Debug/box-open-solid-full.jpg", UriKind.Absolute));
            ajustesImg.Source = new BitmapImage(new Uri("pack://application:,,,/GestionDeProductos;component/bin/Debug/gear-solid-full.jpg", UriKind.Absolute));
            informesImg.Source = new BitmapImage(new Uri("pack://application:,,,/GestionDeProductos;component/bin/Debug/sheet-plastic-solid-full.jpg", UriKind.Absolute));
            aboutImg.Source = new BitmapImage(new Uri("pack://application:,,,/GestionDeProductos;component/bin/Debug/window-maximize-solid-full.jpg", UriKind.Absolute));

            this.productosDataGrid.ItemsSource = new List<Producto>
            {  
                new Producto { Codigo = "A101", Nombre = "Rambutan en Almibar AROY-D", Precio = 0.50m, Unidades = 100 },
                new Producto { Codigo = "B205", Nombre = "Clavo 50mm", Precio = 0.05m, Unidades = 500 },
                new Producto { Codigo = "C303", Nombre = "Tuerca M8", Precio = 0.35m, Unidades = 75 }
            };
        }
    }
}
