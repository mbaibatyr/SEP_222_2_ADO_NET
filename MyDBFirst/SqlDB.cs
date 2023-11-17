using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace MyDBFirst
{
    internal class SqlDB
    {
        private readonly string conStr = @"Server=221-13\MSSQLSERVER11;Database=SEP_222;Trusted_Connection=True;";
        private readonly string conStr2 = @"Server=221-13\MSSQLSERVER11;Database=SEP_222;User Id=admin;Password=1234;";

        public void TestConnection()
        {
            //using (OracleConnection db = new OracleConnection())
            //{
            //    db.Open();
            //    Console.WriteLine(db.State);
            //    db.Close();
            //    Console.WriteLine(db.State);
            //}



            //using (NpgsqlConnection db = new NpgsqlConnection())
            //{
            //    db.Open();
            //    Console.WriteLine(db.State);
            //    db.Close();
            //    Console.WriteLine(db.State);
            //}

            try
            {
                using (SqlConnection db = new SqlConnection(conStr2))
                {
                    db.Open();
                    for (int i = 0; i < 10; i++)
                    {
                        using (SqlCommand cmd = new SqlCommand("insert into for_update values(" + i.ToString() + ", '" + Arr[i] +"')", db))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }

                    Console.WriteLine(db.State);
                    db.Close();
                    Console.WriteLine(db.State);
                }

             
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            //SqlConnection db = null;

            //try
            //{
            //    db = new SqlConnection(conStr2);
            //    db.Open();
            //    Console.WriteLine(db.State);
            //}
            //catch (Exception err)
            //{
            //    Console.WriteLine(err.Message);
            //}
            //finally
            //{
            //    db.Close();
            //    Console.WriteLine(db.State);
        //}

        }
    }
}


//https://github.com/mbaibatyr/SEP_222_2_ADO_NET.git