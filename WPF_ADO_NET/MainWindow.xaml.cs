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
using WPF_ADO_NET.Model;

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

                List<StaffInfoModel> lst = (from DataRow dr in dt.Rows
                                            select new StaffInfoModel()
                                            {
                                                id = dr["id"].ToString(),
                                                ceo = dr["ceo"].ToString(),
                                                company = dr["company"].ToString(),
                                                cost = dr["cost"].ToString(),
                                                date_birth = dr["date_birth"].ToString(),
                                                date_foundation = dr["date_foundation"].ToString(),
                                                f_name = dr["f_name"].ToString(),
                                                gender = dr["gender"].ToString(),
                                                head_office_location = dr["head_office_location"].ToString(),
                                                l_name = dr["l_name"].ToString(),
                                                position = dr["position"].ToString(),
                                                salary = dr["salary"].ToString()
                                            }).ToList();

                dgStaff.ItemsSource = lst;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Close();
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            //var model = dgStaff.SelectedItems[0] as StaffInfoModel;
            //Title = $"{model.id} - {model.l_name} - { model.f_name }";


            fmAdd form = new fmAdd();
            if ((bool)form.ShowDialog())
            {
                using (SqlCommand cmd = new SqlCommand("pStaffInsert", db))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@l_name", form.tbLName.Text);
                    //cmd.Parameters.AddWithValue("@compmany", form.cbCompany.SelectedValue.ToString());


                    object ob = cmd.ExecuteScalar();
                    string result = null;
                    if (ob != null)
                        result = ob.ToString();
                    if (result == "ok")
                        ;//refresh
                }
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cbCompany.ItemsSource = getComboBox("Company");
        }


        List<ComboBoxModel> getComboBox(string value)
        {
            string sql = $"select id, name from {value} order by name";

            using (SqlCommand cmd = new SqlCommand(sql, db))
            {
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return (from DataRow dr in dt.Rows
                        select new ComboBoxModel()
                        {
                            id = dr["id"].ToString(),
                            name = dr["name"].ToString()
                        }).ToList();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var value = cbCompany.SelectedValue.ToString();            
            value = (cbCompany.SelectedItem as ComboBoxModel).id;

        }
    }
}
