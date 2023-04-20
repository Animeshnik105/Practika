using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Collections.ObjectModel;

namespace Practika
{
    public partial class Sum : Window
    {
        public Sum()
        {
            InitializeComponent();
        }

        private void Summ(object sender, RoutedEventArgs e)
        {
            Tre.Text = (Double.Parse(One.Text) + Double.Parse(Two.Text)).ToString();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            Hide();
            new MainWindow().ShowDialog();
            Application.Current.Shutdown();
        }

        private void BB_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }
    }
}
