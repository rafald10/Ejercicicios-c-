using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace ej4
{
    public partial class MainWindow : Window
    {
        private bool mostrandoPrimera = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CambiarImagen_Click(object sender, RoutedEventArgs e)
        {
            if (mostrandoPrimera)
            {
                imgFoto.Source = new BitmapImage(new Uri("pack://application:,,,/imagenes/2.png"));
            }
            else
            {
                imgFoto.Source = new BitmapImage(new Uri("pack://application:,,,/imagenes/images (1).png"));
            }

            mostrandoPrimera = !mostrandoPrimera;
        }
    }
}
