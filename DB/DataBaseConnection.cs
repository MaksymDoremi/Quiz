using System.Configuration;
using System.Data.SqlClient;

namespace Quiz.DB
{
    public class DataBaseConnection
    {
        public SqlConnection connection;

        //serverConnection - database Ivana Kantnerova
        //myConnection - local pc database
        public DataBaseConnection()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["serverConnection"].ConnectionString);
        }

    }
}

