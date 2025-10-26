using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCamp301.Concrete
{
    public class Product
    {

        public int productID { get; set; }

        public string productName { get; set; }

        public int productgStok { get; set; }

        public decimal productPrice { get; set; }

        public string productdespriction { get; set; }


        public int CategoryID { get; set; }

        public  virtual Category Category{get;set;}
        
        public List<Order> Orders { get; set; }







    }
}
