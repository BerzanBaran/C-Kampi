using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 

            //Ado.net


            Console.WriteLine("******Csharp data-based product-category information system*******");

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("1-Categori");
            Console.WriteLine("2-Product");
            Console.WriteLine("3-Orders");
            Console.WriteLine("4-Exists");
            Console.Write("Please enter the number of the table you want to bring: ");
            int num = Convert.ToInt32(Console.Read());

            Console.WriteLine("---------------------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source =localhost\\SQLEXPRESS;initial Catalog=EgitimKampi;integrated security=true=");

            SqlCommand command = new SqlCommand("Select*from TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
           adapter.Fill(dataTable);
            connection.Close();



            foreach(DataRow row in dataTable.Rows)
            {

                foreach(var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }






            #endregion

            Console.Read();
        }
    }
}
