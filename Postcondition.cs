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
       public static void DeleteDbDocument()
       {
           SqlConnection sqlConnection1 = new SqlConnection(SqlServer);
           SqlCommand comm = new SqlCommand();
           Object reportIdValue;

           comm.CommandText = "select quary";
           comm.CommandType = CommandType.Text;
           comm.Connection = sqlConnection1;

           sqlConnection1.Open();

           reportIdValue = comm.ExecuteScalar();


           comm.CommandText = "delete quary" + reportIdValue;
           comm.ExecuteReader();
           sqlConnection1.Close();

       }
    }
}
