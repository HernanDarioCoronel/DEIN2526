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
using System.Windows.Threading;

namespace Componentes
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        DispatcherTimer dt;
        public UserControl1()
        {
            InitializeComponent();
            dt = new DispatcherTimer();

            dt.Interval = TimeSpan.FromSeconds(0,0,1);
            dt.Tick += Dt_Tick;
            dt.Start();
        }

        private void Dt_Tick(object? sender, EventArgs e)
        {
            lbTimeDisplay.Content = DateTime.Now.ToLongTimeString();
        }
    }

}
