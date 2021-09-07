using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace visualprogfinall
{
    /// <summary>
    /// sporcars.xaml etkileşim mantığı
    /// </summary>
    public partial class sporcars : Window
    {
        public sporcars()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-G4CLP0B;Initial " +
            "Catalog=visualfinall;Integrated Security=True");

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            connection.Open();
            SqlCommand add = new SqlCommand("insert into sportcars " +
                "values(@brand,@model,@year,@price)", connection);

            add.Parameters.AddWithValue("@brand", textbox2.Text);
            add.Parameters.AddWithValue("@model", textbox3.Text);
            add.Parameters.AddWithValue("@year", textbox4.Text);
            add.Parameters.AddWithValue("@price", textbox5.Text);

            add.ExecuteNonQuery();


            MessageBox.Show("Datas are added.", "Information", MessageBoxButton.OK);
            connection.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            connection.Open();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from sportcars", connection);
            DataTable dt = new DataTable();
            datagrid2.DataContext = dt;
            da2.Fill(dt);


            connection.Close();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            connection.Open();
            SqlCommand delete = new SqlCommand("delete from sportcars where id=@id", connection);
            delete.Parameters.AddWithValue("@id", textbox1.Text);
            delete.ExecuteNonQuery();
            MessageBox.Show("specified datas are deleted.");

            connection.Close();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            connection.Open();
            SqlCommand update = new SqlCommand("update sportcars set" +
                " brand=@brand,model=@model, year=@year, price=@price where id=@id", connection);
            update.Parameters.AddWithValue("@band", textbox2.Text);
            update.Parameters.AddWithValue("@Model", textbox3.Text);
            update.Parameters.AddWithValue("@Price", textbox4.Text);
            update.Parameters.AddWithValue("@Features", textbox5.Text);
            update.Parameters.AddWithValue("@id", textbox1.Text);
            update.ExecuteNonQuery();
            MessageBox.Show("Datas are updated.");

            connection.Close();
        }
    }
}
