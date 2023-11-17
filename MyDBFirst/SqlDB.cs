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


            using (SqlConnection db = new SqlConnection(conStr2))
            {
                db.Open();
                Console.WriteLine(db.State);
                db.Close();
                Console.WriteLine(db.State);
            }
        }
    }
}
