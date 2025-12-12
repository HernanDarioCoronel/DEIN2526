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

namespace ReproductorMultimedia
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string fileName;
        private double volume;

        public MainWindow()
        {
            InitializeComponent();

            this.volume = this.volumeSlider.Value;
            this.mediaPlayer.Volume = this.volumeSlider.Value;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Filter =
                "Archivos de Windows Media|*.wm;*.wmv;*.asf" +
                "|Archivos AVCHD (incluidos los de audio Dolby Digital)|*.m2ts;*.m2t" +
                "|Archivos de Apple QuickTime|*.mov;*.qt" +
                "|Archivos AVI|*.avi" +
                "|MP4|*.mp4" +
                "|Archivos de programas de televisión grabados de Windows|*.wtv;*.dvr-ms" +
                "|Archivos de película MPEG-4|*.mp4;*.mov;*.m4v" +
                "|Archivos de película MPEG-2|*.mpeg;*.mpg;*.mpe;*.m1v;*.mp2;*.mpv2;*.mod;*.vob" +
                "|Archivos de película MPEG-1|*.m1v" +
                "|Archivos JPEG de movimiento|*.avi;*.mov" +
                "|Todos los Archivos de Video|*.wm;*.wmv;*.asf;*.m2ts;*.m2t;*.mov;*.qt;*.avi;*.wtv;*.dvr-ms;*.mp4;*.m4v;*.mpeg;*.mpg;*.mpe;*.m1v;*.mp2;*.mpv2;*.mod;*.vob";

            if (dialog.ShowDialog() == true)
            {
                this.fileName = dialog.FileName;
                this.fileNameLb.Content = this.fileName;
                this.mediaPlayer.Source = new Uri(this.fileName);

                this.playBt.IsEnabled = true;
            }
        }

        private void play_Click(object sender, RoutedEventArgs e)
        {
            this.mediaPlayer.Play();

            this.playBt.IsEnabled = false;
            this.pauseBt.IsEnabled = true;
            this.stopBt.IsEnabled = true;
        }

        private void pause_Click(object sender, RoutedEventArgs e)
        {
            this.mediaPlayer.Pause();

            this.playBt.IsEnabled = true;
            this.pauseBt.IsEnabled = false;
        }

        private void stop_Click(object sender, RoutedEventArgs e)
        {
            this.mediaPlayer.Stop();

            this.playBt.IsEnabled = true;
            this.pauseBt.IsEnabled = false;
            this.stopBt.IsEnabled = false;
        }

        private void mute_Click(object sender, RoutedEventArgs e)
        {
            bool isMuted = this.mediaPlayer.Volume == 0;
            this.mediaPlayer.Volume = isMuted ? volume : 0;
            this.muteBt.Content = isMuted ? "Silencio" : "Activar Sonido";
        }

        private void volumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            this.mediaPlayer.Volume = e.NewValue;
            this.volume = e.NewValue;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            this.mediaPlayer.Balance = e.NewValue;
        }

        private void Slider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            this.mediaPlayer.SpeedRatio = e.NewValue;
        }
    }
}
