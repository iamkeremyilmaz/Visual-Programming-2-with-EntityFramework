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

namespace visualprogfinall
{
    /// <summary>
    /// main.xaml etkileşim mantığı
    /// </summary>
    public partial class main : Window
    {
        public main()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            musclecars msc = new musclecars();
            this.Hide();
            msc.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
            sporcars sc = new sporcars();
            this.Hide();
            sc.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            suv suv  = new suv();
            this.Hide();
            suv.Show();
        }
    }
}
