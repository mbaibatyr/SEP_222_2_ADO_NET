using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace MyDBFirst
{
    internal class SqlDB
    {
        private readonly string conStr = @"Server=214-13;Database=testDB;Trusted_Connection=True;";
        private readonly string conStr2 = @"Server=221-13\MSSQLSERVER11;Database=SEP_222;User Id=admin;Password=1234;";

        private readonly string sql_1 = "SELECT  m.id, convert(varchar(10), m.[match_date], 104) dt, t1.[team_name] team_name_1, t2.[team_name] team_name_2, cast(m.[first_team_point] as varchar(2)) + ':' + cast(m.[second_team_point] as varchar(2)) score FROM [dbo].matches m join [dbo].[Teams] t1 on m.first_team_id = t1.id join [dbo].[Teams] t2 on m.second_team_id = t2.id";
        private readonly string sql_2 = "SELECT [id] ,[dt] ,[team_name_1] ,[team_name_2] ,[score] FROM [testDB].[dbo].[vGetMatchesOfTeams]";
        private readonly string sql_3 = "pGetMatchesOfTeams";

        public void TestConnection()
        {

            #region 
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

            //try
            //{
            //    using (SqlConnection db = new SqlConnection(conStr2))
            //    {
            //        db.Open();
            //        for (int i = 0; i < 10; i++)
            //        {
            //            using (SqlCommand cmd = new SqlCommand("insert into for_update values(" + i.ToString() + ", '" + Arr[i] +"')", db))
            //            {
            //                cmd.ExecuteNonQuery();
            //            }
            //        }

            //        Console.WriteLine(db.State);
            //        db.Close();
            //        Console.WriteLine(db.State);
            //    }


            //}
            //catch (Exception err)
            //{
            //    Console.WriteLine(err.Message);
            //}

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
            #endregion
        }

        public void Fetch()
        {
            using (SqlConnection db = new SqlConnection(conStr))
            {
                db.Open();
                using (SqlCommand cmd = new SqlCommand(sql_3, db))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //SqlParameter team_id = new SqlParameter("team_id", 1);
                    //cmd.Parameters.Add(team_id);
                    //cmd.Parameters.AddWithValue("team_id", 1);
                    cmd.Parameters.Add(new SqlParameter("team_id", 1));
                    SqlDataReader dr = cmd.ExecuteReader();
                    //if(dr.HasRows)
                    //{
                    //    while (dr.Read())
                    //    {
                    //        Console.WriteLine($"{dr[0].ToString()} {dr["team_name_1"].ToString()} {dr[1].ToString()}  {dr[2].ToString()}  {dr[3].ToString()}  {dr[4].ToString()}");
                    //    }
                    //}

                    DataTable dt = new DataTable();
                    //dt.Load(dr);

                    //foreach (DataRow item in dt.Rows)
                    //{
                    //    Console.WriteLine($"{item[0].ToString()} {item["team_name_1"].ToString()} {item[1].ToString()}  {item[2].ToString()}  {item[3].ToString()}  {item[4].ToString()}");
                    //}
                    //db.Close();

                    
                    dt.Load(dr);

                    foreach (DataRow item in dt.Rows)
                    {
                        Console.WriteLine($"{item[0].ToString()} {item["team_name_1"].ToString()} {item[1].ToString()}  {item[2].ToString()}  {item[3].ToString()}  {item[4].ToString()}");
                    }
                    db.Close();


                }
            }
        }

        public void Fetch2()
        {
            using (SqlConnection db = new SqlConnection(conStr))
            {
                db.Open();
                using (SqlCommand cmd = new SqlCommand("pOut", db))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("team_id", 4);

                    SqlParameter count_mathes = new SqlParameter("count_mathes", SqlDbType.Int);
                    count_mathes.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(count_mathes);

                    cmd.ExecuteNonQuery();
                    var count = cmd.Parameters["count_mathes"].Value.ToString();
                    Console.WriteLine(count);
                    db.Close();


                }
            }
        }

        public void Fetch3()
        {
            using (SqlConnection db = new SqlConnection(conStr))
            {
                db.Open();
                using (SqlCommand cmd = new SqlCommand("pSelect", db))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("team_id", 1);
                    var ob = cmd.ExecuteScalar();
                    if(ob != null)
                        Console.WriteLine(ob.ToString());
                    db.Close();
                }
            }
        }
    }
}


//https://github.com/mbaibatyr/SEP_222_2_ADO_NET.git