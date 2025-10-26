using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCamp301.Concrete
{
    public class Category

    {
        //***************Acess modifers(Erişim belirleyiciler)**********
        // Public -> Solutuion altındaki her yerden erişilebilir 
        //private -> sadece bulundığu clastan veya Interface ten erişim sağlayabilir
        // Internale -> Saddece  bulunduğu katmandan(Entity) erişim sağlabilir
        //Protected -> Bir sınıf ve o sınıftan miras alan yerden erişim salayabilir 

            public int CategoryID { get; set; }   
        
        
        public string CategoryName { get; set; }
                                         
    public bool Categorystatus { get; set; }

        public List<Product> Products { get; set; }


    }


}

/*
 * field-variable-Property
 * field exam:
 *  int x;
 * 
*variable exam:
 *   void test() { int z; }
 * 
 * property exam:
 *  public int y{get;set;}
 * 
    */



