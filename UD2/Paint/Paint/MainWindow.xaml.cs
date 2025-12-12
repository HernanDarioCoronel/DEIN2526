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
using System.Windows.Ink;
using Microsoft.Win32;
using System.IO;

namespace Paint
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int currColor = 0;
        int currBrushThiccness = 1;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void ChangeColor_Click(object sender, RoutedEventArgs e)
        {
            switch (currColor)
            {
                case 0:
                    paint.DefaultDrawingAttributes.Color = Colors.Red;
                    selectedColor.Background = Brushes.Red;
                    break;
                case 1:
                    paint.DefaultDrawingAttributes.Color = Colors.Blue;
                    selectedColor.Background = Brushes.Blue;
                    break;
                case 2:
                    paint.DefaultDrawingAttributes.Color = Colors.Yellow;
                    selectedColor.Background = Brushes.Yellow;
                    break;
                case 3:
                    paint.DefaultDrawingAttributes.Color = Colors.Green;
                    selectedColor.Background = Brushes.Green;
                    break;
                default:
                    paint.DefaultDrawingAttributes.Color = Colors.Black;
                    selectedColor.Background = Brushes.Black;
                    currColor = 0;
                    return;
            }
            currColor++;
        }

        private void ChangeBrushTickness_Click(object sender, RoutedEventArgs e)
        {
            if (currBrushThiccness <= 10)
                currBrushThiccness++;
            else
                currBrushThiccness = 1;

            selectedThicknes.Height = currBrushThiccness;
            selectedThicknes.BorderThickness = new Thickness(currBrushThiccness);
            paint.DefaultDrawingAttributes.Width = currBrushThiccness;
            paint.DefaultDrawingAttributes.Height = currBrushThiccness;
            paint.EraserShape = new RectangleStylusShape(currBrushThiccness, currBrushThiccness, 0);


        }

        private void DrawOrPaint_Click(object sender, RoutedEventArgs e)
        {
            if (paint.EditingMode == InkCanvasEditingMode.Ink)
            {
                paint.EditingMode = InkCanvasEditingMode.EraseByPoint;
                ((Button)sender).Content = "Pintar";
            }
            else
            {
                paint.EditingMode = InkCanvasEditingMode.Ink;
                ((Button)sender).Content = "Borrar";
            }
        }

        private void Nuevo_Click(object sender, RoutedEventArgs e)
        {
            paint.Strokes.Clear();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "Imagen PNG (*.png)|*.png",
                FileName = "MiDibujoImagen"
            };

            if (saveDialog.ShowDialog() == true)
            {
                try
                {
                    RenderTargetBitmap rtb = new RenderTargetBitmap(
                        (int)paint.ActualWidth,
                        (int)paint.ActualHeight,
                        96, 96,
                        PixelFormats.Pbgra32
                    );

                    rtb.Render(paint);

                    PngBitmapEncoder pngEncoder = new PngBitmapEncoder();
                    pngEncoder.Frames.Add(BitmapFrame.Create(rtb));
                    using (FileStream fs = new FileStream(saveDialog.FileName, FileMode.Create))
                    {
                        pngEncoder.Save(fs);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar la imagen: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (paint.Strokes.Count > 0)
            {
                string mensaje = "¿Desea salir sin guardar los cambios? Los trazos se perderán.";
                MessageBoxResult resultado = MessageBox.Show(
                    mensaje,
                    "Confirmar Salida",
                    MessageBoxButton.YesNo, 
                    MessageBoxImage.Warning
                );
                
                if (resultado == MessageBoxResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}   
