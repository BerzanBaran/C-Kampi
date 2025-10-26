using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCamp301.Concrete
{
    public class Order
    {

        public int OrderID { get; set; }


        public int ProductID { get; set; }

        public virtual Product Product { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }
        public decimal totalPrice { get; set; }

        public int customerID { get; set; }
        public virtual Customer customer { get; set; }




    }
}
