using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCamp301.Concrete
{
    public class Customer
    {

        public int customerID { get; set; }

        public string customerName { get; set; }


        public string customerSurname { get; set; }
        public string customerDistrict { get; set; }
        public string customerCity { get; set; }

 
        public List<Order> ordesr { get; set; }


    }
}
