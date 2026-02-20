using System;
using System.Collections.Generic;
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
    /// Lógica de interacción para ContrasenaInput.xaml
    /// </summary>
    public partial class ContrasenaInput : UserControl
    {
        public ContrasenaInput()
        {
            InitializeComponent();
        }

        private void Eye_MouseEnter(object sender, MouseEventArgs e)
        {
            txtVisible.Text = txtPassword.Password;

            txtPassword.Visibility = Visibility.Collapsed;
            txtVisible.Visibility = Visibility.Visible;
        }

        private void Eye_MouseLeave(object sender, MouseEventArgs e)
        {
            txtPassword.Password = txtVisible.Text;

            txtVisible.Visibility = Visibility.Collapsed;
            txtPassword.Visibility = Visibility.Visible;
        }
    }
}
