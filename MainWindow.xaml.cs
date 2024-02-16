using ConsoleOnlineShop;
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
using WpfShop.window;

namespace WpfShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            listClient.Items.Clear();
            listClient.ItemsSource = new People[]
            {
                new People("Иван Первый", 1000),
                new People("Корней Корнеич", 1050)
            };
            listProduct.Items.Clear();
            listProduct.ItemsSource = new Product[]
            {
                new Product("Чай", 89),
                new Product("Корица", 10)
            };
        }

        private void AddClient_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {

        }

        private void newWindow_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
        }
    }
}