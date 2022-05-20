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
    internal class ShoertestPathService
    {
        public void InsertShortestPathUser(String username, String anwser)
        {
            using (SqlConnection con = new SqlConnection(DataConnection.ConnectionVal()))
            {
                using (SqlCommand sqlCommand = new("usp_InsertShortestPathWinner", con))
                {
                    con.Open();

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@username", username);
                    sqlCommand.Parameters.AddWithValue("@answer", anwser);
                    sqlCommand.ExecuteNonQuery();

                    con.Close();
                }
            }
        }
    }
}
