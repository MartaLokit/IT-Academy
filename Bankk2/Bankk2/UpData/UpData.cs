using Microsoft.Data.SqlClient;
using System.Data;

namespace Bankk2.UpData
{
    public class UpDataTransaction
    {
        private string connection;
        private SqlDataAdapter adapter;
        private SqlConnection connectionString;
        private DataTable data;
        public UpDataTransaction(string balanceWithdrawal, string userEmailSender,
            string userEmailRecipient)
        {
            Realization(balanceWithdrawal, userEmailSender, userEmailRecipient);
        }
        private void Sample(string command)
        {
            try
            {
                adapter = new SqlDataAdapter(command, connection);
                data = new DataTable();
                adapter.Fill(data);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void Adapter(string balanceWithdrawal,string userEmailSender,
            string userEmailRecipient)
        {
            try
            {
                Sample("UpDate DataCard" +
                    $" Set Balance = Balance-'{balanceWithdrawal}'" +
                    $" where UserEmail='{userEmailSender}'");
                Sample("UpDate DataCard" +
                     $" Set Balance = Balance+'{balanceWithdrawal}'" +
                     $" where UserEmail='{userEmailRecipient}'");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void Realization(string balanceWithdrawal, string userEmailSender,
            string userEmailRecipient)
        {
            connection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BankAccount;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            connectionString = new SqlConnection(connection);
            try
            {
                connectionString.Open();
                Adapter(balanceWithdrawal,userEmailSender,userEmailRecipient);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
