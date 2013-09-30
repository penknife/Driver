using System;
using System.Data;
using System.Data.SqlClient;


namespace SensingPortalTests.Helpers
{
    public class PostCondition
    {
        public static String SqlServer =
            "Server=;Database=;User Id=;Password=;";

        public static void DeleteDbFolder()
        {
            SqlCommand comm = new SqlCommand();
            comm.Connection = new SqlConnection(SqlServer);
            const string sql = @"some query";
            comm.CommandText = sql;
            comm.Connection.Open();
            comm.ExecuteReader();
            comm.Connection.Close();
        }

        public static void DeleteDbDocument()
        {
            SqlConnection sqlConnection1 = new SqlConnection(SqlServer);
            SqlCommand comm = new SqlCommand();
            Object reportIdValue;

            comm.CommandText = "some query";
            comm.CommandType = CommandType.Text;
            comm.Connection = sqlConnection1;

            sqlConnection1.Open();

            reportIdValue = comm.ExecuteScalar();


            comm.CommandText = "some query" +
                               reportIdValue;
            comm.ExecuteReader();
            sqlConnection1.Close();

        }

        public static void DeleteEditFolder()
        {
            SqlCommand comm = new SqlCommand();
            comm.Connection = new SqlConnection(SqlServer);
            const string sql = @"some query";
            comm.CommandText = sql;
            comm.Connection.Open();
            comm.ExecuteReader();
            comm.Connection.Close();
        }

        public static void DeleteDocument1()
        {
            string reportId = null;
            string attachmentId = null;
            using (var conn = new SqlConnection(SqlServer))
            using (var comm = conn.CreateCommand())
            {
                conn.Open();
                comm.CommandText = "some query";
                using (var reader = comm.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        reportId = reader["ReportId"].ToString();
                    }
                }

                comm.CommandText = "some query" +
                                   reportId;
                using (var reader = comm.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        attachmentId = reader["AttachmentId"].ToString();
                    }
                    conn.Close();

                }

                conn.Open();
                comm.CommandText = "some query" + attachmentId;
                comm.ExecuteReader();
                conn.Close();


                conn.Open();
                comm.CommandText = some query" + attachmentId;
                comm.ExecuteReader();
                conn.Close();

                conn.Open();
                comm.CommandText = "some query" + attachmentId;
                comm.ExecuteReader();

                conn.Close();

            }
        }

    }
}

