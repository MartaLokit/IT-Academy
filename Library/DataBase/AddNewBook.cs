using Library.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Library.DataBase
{
    public class AddNewBook:ConnectionString
    {
        private SqlCommand command;
        private Author author;
        private string FirstName;
        private string LastName;
        private string Surname;
        private DataTable table;
        public SqlDataAdapter dataAdapter;
        public void DataAuthor(string data)
        {
            string[] split = data.Split(' ');
            /*author.FirstName= split[1];
            author.LastName= split[0];
            author.Surname = split[2];*/
            FirstName= split[1];
            LastName= split[0];
            Surname = split[2];
        }
        public void AddDataAuthor(string data)
        {
            DataAuthor(data);
            dataAdapter=new SqlDataAdapter("Insert Into Author Values" +
                $" ('{LastName}','{FirstName}','{Surname}')", connection);
            table=new DataTable();
            dataAdapter.Fill(table);
        }
    }
}
