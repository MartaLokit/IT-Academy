using Microsoft.Data.SqlClient;
using System.Data;

namespace Library.DataBase
{
    public class ConnectionString
    {
        public string status;
        public SqlConnection connection;
        public ConnectionString()
        {
            connection = new SqlConnection("Data Source=DESKTOP-8BBF79J;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            if (connection.State == ConnectionState.Open)
                status = "Подключено";
        }
    }
}
