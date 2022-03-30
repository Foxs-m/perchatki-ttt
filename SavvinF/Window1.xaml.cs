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
using System.Data.SqlClient;
using System.Data;п
using System.Configuration;


namespace SavvinF
{

    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        string connectionString;
        SqlDataAdapter adapter;
        DataTable phonesTable;
        public Window1()
        {
            InitializeComponent();
    
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window2 f3 = new Window2();
            f3.ShowDialog();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
