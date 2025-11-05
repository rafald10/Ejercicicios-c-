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

namespace ej2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Cut_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (txtContenido == null)
            {
                e.CanExecute = false;
                return;
            }

            e.CanExecute = !string.IsNullOrEmpty(txtContenido.SelectedText);
        }

        private void Cut_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txtContenido?.Cut();
        }

     
        private void Paste_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (txtContenido == null)
            {
                e.CanExecute = false;
                return;
            }

            e.CanExecute = Clipboard.ContainsText();
        }

        private void Paste_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txtContenido?.Paste();
        }
    }
}