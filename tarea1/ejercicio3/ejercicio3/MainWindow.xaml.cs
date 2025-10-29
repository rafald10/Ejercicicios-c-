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

namespace ejercicio3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Grid mainGrid = new Grid();
            Button btn = new Button
            {
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center, 
                FontWeight
                    = FontWeights.Bold

            };
            WrapPanel panel = new WrapPanel();

            TextBlock textBlock1 = new TextBlock
            {
                Text = "Primer Bloque",
                Foreground = Brushes.Green
            };
            TextBlock textBlock2 = new TextBlock
            {
                Text = "Segundo Bloque",
                Foreground = Brushes.Blue
            };
            TextBlock textBlock3 = new TextBlock
            {
                Text = "Tercer Bloque",
                
            };
            panel.Children.Add(textBlock1);
            panel.Children.Add(textBlock2);
            panel.Children.Add(textBlock3);

            btn.Content = panel;

            mainGrid.Children.Add(btn);

            this.Content = mainGrid;
        }
    }
}