using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace WPF_ADO_NET
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection db;
        public MainWindow()
        {
            InitializeComponent();
            db = new SqlConnection(ConfigurationManager.AppSettings["db"]);
            db.Open();
        }

        private void btFind_Click(object sender, RoutedEventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("pStaffInfo", db))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@company_name", tbCompany.Text);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgStaff.ItemsSource = dt;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Close();
        }
    }
}
