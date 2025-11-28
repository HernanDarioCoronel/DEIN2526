using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfMediaControl
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        

        private void PlayVideo_Click(object sender, RoutedEventArgs e)
        {
            mediaVideo.Play();
        }

        private void PauseVideo_Click(object sender, RoutedEventArgs e)
        {
            mediaVideo.Pause();
        }

        private void RewindVideo_Click(object sender, RoutedEventArgs e)
        {
            mediaVideo.Position = TimeSpan.Zero;
            mediaVideo.Pause();
        }

        private void PlayAudio_Click(object sender, RoutedEventArgs e)
        {
            mediaAudio.Play();
        }

        private void PauseAudio_Click(object sender, RoutedEventArgs e)
        {
            mediaAudio.Pause();
        }

        private void RewindAudio_Click(object sender, RoutedEventArgs e)
        {
            mediaAudio.Position = TimeSpan.Zero;
            mediaAudio.Pause();
        }
        
    }
}