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

namespace Practika
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Sum1(object sender, RoutedEventArgs e)
        {
            Hide();
            new Sum().ShowDialog();
            Application.Current.Shutdown();
        }

        private void Sub1(object sender, RoutedEventArgs e)
        {
            Hide();
            new Sub().ShowDialog();
            Application.Current.Shutdown();
        }

        private void Div1(object sender, RoutedEventArgs e)
        {
            Hide();
            new Div().ShowDialog();
            Application.Current.Shutdown();
        }

        private void Mul1(object sender, RoutedEventArgs e)
        {
            Hide();
            new Mul().ShowDialog();
            Application.Current.Shutdown();
        }
    }
}
