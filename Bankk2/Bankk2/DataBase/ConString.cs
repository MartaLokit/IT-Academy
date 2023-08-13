using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Банковская_система.DataBase
{
    public class ConString
    {
        protected SqlConnection connection;
        protected ConString()
        {
            connection = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=BankAccount;Trusted_Connection=True;MultipleActiveResultSets=true");
            connection.Open();
        }
    }
}
