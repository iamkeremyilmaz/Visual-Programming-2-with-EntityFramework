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

namespace visualprogfinall
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        visualfinalEntities ef = new visualfinalEntities();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TEXTBOX1.Text != string.Empty && TEXTBOX2.Text != string.Empty)
            {
                var Users = ef.users.FirstOrDefault(a => a.Username.Equals(TEXTBOX1.Text));
                if (Users != null)
                {
                    if (Users.Pasword.Equals(TEXTBOX2.Text))
                    {
                        main frm = new main();
                        this.Hide();
                        frm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("wrong username or password, plaese check these ");
                }
            }

        }
    }
}
    
