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
using System.Windows.Shapes;

namespace WpfShop.window
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void textBox1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragDrop.DoDragDrop(textBox1, textBox1.Text, DragDropEffects.Copy);
        }

        private void button1_Drop(object sender, DragEventArgs e)
        {
            button1.Content = e.Data.GetData(DataFormats.Text);
        }
    }
}
