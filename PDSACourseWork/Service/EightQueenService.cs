﻿using System.Data;
using System.Data.SqlClient;
using PDSACourseWork.Data;

namespace PDSACourseWork.Service
{
    internal class EightQueenService
    {
        public void InsertAllPossibilities(DataTable dt)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Error occured during execution!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public List<string> GetAllPossibilities()
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Error occured during execution!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public List<string> GetWinnerPossibilities()
        {
            try
            {
                List<string> possibilities = new();

                using (SqlConnection con = new SqlConnection(DataConnection.ConnectionVal()))
                {
                    using (SqlCommand sqlCommand = new("usp_GetAllWinnerPossibilities", con))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        con.Open();

                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        while (reader.Read())
                        {
                            possibilities.Add(reader["Possibility"].ToString());
                        }

                        con.Close();
                    }
                }

                return possibilities;
            }
            catch (Exception)
            {
                MessageBox.Show("Error occured during execution!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public int SaveAnswer(string name, string answer)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DataConnection.ConnectionVal()))
                {
                    using (SqlCommand sqlCommand = new("usp_InsertWinnerAnswer", con))
                    {
                        con.Open();

                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@userName", name);
                        sqlCommand.Parameters.AddWithValue("@answer", answer);

                        return sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured during execution!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
    }
}
