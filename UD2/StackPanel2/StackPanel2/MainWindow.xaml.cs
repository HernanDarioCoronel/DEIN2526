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

namespace StackPanel2
{
    public partial class MainWindow : Window
    {
        int horizontalWidth = 240;
        int verticalWidth = 80;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            bt2.Width = verticalWidth;
            bt1.Width = verticalWidth;
            bt3.Width = verticalWidth;
            bt4.Width = verticalWidth;
            panel.Orientation = Orientation.Horizontal;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            bt1.Width = horizontalWidth;
            bt2.Width = horizontalWidth;
            bt3.Width = horizontalWidth;
            bt4.Width = horizontalWidth;
            panel.Orientation = Orientation.Vertical;
        }
    }
}
