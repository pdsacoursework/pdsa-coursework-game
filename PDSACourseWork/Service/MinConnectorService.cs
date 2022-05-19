using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using PDSACourseWork.Data;

namespace PDSACourseWork.Service
{
    internal class MinConnectorService
    {

        public void InsertWinnerUser(String name)
        {
            using (SqlConnection con = new SqlConnection(DataConnection.ConnectionVal()))
            {
                using (SqlCommand sqlCommand = new("usp_InsertMinConWinnerAnswer", con))
                {
                    con.Open();

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@name", name);
                    sqlCommand.ExecuteNonQuery();

                    con.Close();
                }
            }
        }

        public void InsertWinnerConnectorPaths(String from, String to, int dis)
        {
            using (SqlConnection con = new SqlConnection(DataConnection.ConnectionVal()))
            {
                using (SqlCommand sqlCommand = new("usp_InsertMinConWinnerAnswerPaths", con))
                {
                    con.Open();

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@from", from);
                    sqlCommand.Parameters.AddWithValue("@to", to);
                    sqlCommand.Parameters.AddWithValue("@distance", dis);
                    sqlCommand.ExecuteNonQuery();

                    con.Close();
                }
            }
        }
    }
}
