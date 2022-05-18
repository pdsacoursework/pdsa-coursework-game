using PDSACourseWork.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDSACourseWork.Service
{
    internal class EightQueenService
    {
        public void InsertAllPossibilities(DataTable dt)
        {
            using (SqlConnection con = new SqlConnection(DataConnection.ConnectionVal()))
            {
                using (SqlCommand sqlCommand = new("usp_InsertPossibilities", con))
                {
                    con.Open();

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@uttPossibilities", dt);
                    sqlCommand.ExecuteNonQuery();

                    con.Close();
                }
            }
        }

        public List<string> GetAllPossibilities()
        {
            List<string> possibilities = new();

            using (SqlConnection con = new SqlConnection(DataConnection.ConnectionVal()))
            {
                using (SqlCommand sqlCommand = new("usp_GetAllPossibilities", con))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    con.Open();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        possibilities.Add(reader["possibilities"].ToString());
                    }

                    con.Close();
                }
            }

            return possibilities;
        }
    }
}
