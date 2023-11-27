﻿using System;
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
    }
}
