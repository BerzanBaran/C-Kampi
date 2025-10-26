using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        private static SqlConnection connection;

       

        static void Main(string[] args, object productPrice)
        {


            //Console.WriteLine(" ******Menu orderr procesing panel******");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------");
            //Console.Write("The category name you want to add: ");
            //string categoryName = Console.ReadLine();
            #region Product adding process



            //SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS; initial catalog=EgitimKampi; integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("INSERT INTO TblCategory (CategoryName) VALUES (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Category was added succcessfully.");

            #endregion

            #region Product listing process

            //string productName;
            //decimal productPrice;


            //Console.Write("Product price: ");
            //productPrice = Convert.ToDecimal(Console.ReadLine());

            //SqlConnection conneciton = new SqlConnection("Data Source=localhost\\SQLEXPRESS;initial catalog=EgitimKampiDb;Integrated Security=True;");
            //conneciton.Open();

            //SqlCommand cmd = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values" +
            //    "(@productName,@productPrice,@productStatus) ", connection);


            //cmd.Parameters.AddWithValue("@roductName", productName);
            //cmd.Parameters.AddWithValue("@productPrice", productPrice);
            //cmd.Parameters.AddWithValue("@productStatus", true);
            //cmd.ExecuteNonQuery();
            //connection.Close();

            #endregion

            #region Ürün Listeleme ıslemi

            //SqlConnection connection=new SqlConnection("Data Source=localhost\\SQLEXPRESS;initial catalog=EgitimKampiDB;integrated security=true");

            //connection.Open();
            //SqlCommand commmand = new SqlCommand("Select  From TblProdct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{


            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.WriteLine(item.ToString()+" ");
            //    }
            //    Console.WriteLine();

            //}


            //connection.Close();
            #endregion


            #region Product Delete process

            //Console.Write("ID of the product to be deleted: ");
            //int productID = int.Parse(Console.ReadLine());

            //SqlConnection conneciton = new SqlConnection("Data Source=localhost\\SQLEXPRESS;initial catalog=EgitimKampiDb;Integrated Security=True;");

            //    connection.Open();

            //SqlCommand command = new SqlCommand("Delete from TblProduct Where ProductID=@productID",connection);
            //command.Parameters.AddWithValue("@productID", productID);
            //command.ExecuteNonQuery();


            //connection.Close();



            Console.WriteLine("Deletion process comleted");


            #endregion

            #region Product Update process


            Console.Write("Product ID to be updated: ");
            int productID = int.Parse(Console.ReadLine());


            Console.Write("Name of the product to be updated: ");
            string productName = Console.ReadLine();


            Console.Write("Price of the product to be updated: ");
             decimal Price=decimal.Parse(Console.ReadLine());



            SqlConnection conneciton = new SqlConnection("Data Source=localhost\\SQLEXPRESS;initial catalog=EgitimKampiDb;Integrated Security=True;");
            connection.Open();


            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice where ProductID=@productID",connection);

            command.Parameters.AddWithValue("@productName",productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productID", productID);
            command.ExecuteNonQuery();
            
            connection.Close();

            Console.WriteLine("Update is the succesfful");
                

            #endregion


            Console.Read();
        }
    }
}
