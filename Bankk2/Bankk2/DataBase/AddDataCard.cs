using Bankk2.Models;
using Microsoft.Data.SqlClient;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using System.Data;
using Банковская_система.DataBase;

namespace Bankk2.DataBase
{
    public class AddDataCard:ConString
    {
        public bool autorization;
        private string resaul;
        private SqlDataAdapter sqlCommand = null;
        private DataTable data = null;
        private void Sample(string command)
        {
            try
            {
                sqlCommand = new SqlDataAdapter(command, connection);
                data = new DataTable();
                sqlCommand.Fill(data);
            }
            catch (Exception ex)
            {
               
            }

        }
        public void Registration()
        {
            //CreateNumberCard createNumber = new CreateNumberCard();
            //string temp = createNumber.securitycode;
            //Sample($"Insert Into DataCard VALUES " +
            //    $"('{StaticDataCard.CardNumber}','{StaticDataCard.CVV}','07/23'," +
            //    $"'{StaticDataCard.UserEmail}')");
        }
    }
}
