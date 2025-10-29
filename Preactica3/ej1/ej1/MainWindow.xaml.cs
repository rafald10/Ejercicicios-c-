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

namespace ej1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int intentos = 0;
        private const int maxIntentos = 2;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnCorregir_Click(object sender, RoutedEventArgs e)
        {
            if (intentos >= maxIntentos)
            {
                MessageBox.Show("Ya no te quedan intentos.");
                return;
            }

            intentos++;

            if (r2.IsChecked == true)
                MessageBox.Show("¡Correcto!");
            else
                MessageBox.Show("Incorrecto.");

            if (intentos == maxIntentos)
                MessageBox.Show("Has agotado tus intentos.");
        }
    }
}
