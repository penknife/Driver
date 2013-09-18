using System.Data.SqlClient;

namespace SensingPortalTests.Helpers
{
    public class PostCondition
    {
       public static void DeleteDbFolder(PostCondition postCondition)
        {
            SqlCommand comm = new SqlCommand();
            comm.Connection = new SqlConnection("Server=server;Database=somebase;User Id=User;Password=Password;");
            const string sql = @"some query";
            comm.CommandText = sql;
            comm.Connection.Open();
             comm.ExecuteReader();
            comm.Connection.Close();
            }
    }
}
