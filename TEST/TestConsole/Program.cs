using System;
using System.Data;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dataTable= new DataTable();
            DateTime date = new DateTime (2022,3,9);
            DateTime datef = new DateTime(2022, 4, 9);
            
            while (date<datef)
            {
                date = date.AddDays(1);
                dataTable.Columns.Add(Convert.ToString(date), typeof(string));
            }
            dataTable.Rows.Add("se", typeof(string));
            Console.WriteLine(dataTable);
        }
    }
}
