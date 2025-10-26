using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Methods
            // Geriye değer döndürmeyen metotlar(void)
            // Customer-->Listele,ekle,sil,güncelle


            //           void customerList()
            //           {
            //               Console.WriteLine("Mauro Icardi");
            //               Console.WriteLine("Arda Güler");
            //               Console.WriteLine("Kenan Yıldız");
            //               Console.WriteLine("Victor Osimhen");
            //               Console.WriteLine("Cristiano Ronaldo");
            //           }
            //// Burada customerList metodunu kaç defa çap-ğırırsan o kadar sayı kadar ekrana yazdırılır
            //           customerList();
            //           customerList();
            //           customerList();
            //           customerList();


            //void sum()
            //{
            //    int x = 4;
            //    int y = 23;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //sum();


            #endregion

            #region Geriye Deger Dondurmeyen Sting Parametreli Metotlar

            //void writeMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //writeMethod("Berzan Baran");


            //void customerCard(string name,string surName)
            //{
            //    Console.WriteLine("Customer : " + name + " " + surName);

            //}
            //customerCard("Berzan", "Baran");
            //customerCard("Mehmet", "Yıldız");




            #endregion


            #region Geriye Deger Doundurmeyen Int Parametrli Metotlar

            //void sum(int num1,int num2)
            //{
            //    int result = num1 + num2;
            //    Console.WriteLine(result);
            //}
            //sum(23, 45);



            #endregion

            #region Geriye Deger Donduren Metotlar

            //string customerName()
            //{
            //    return "Arda Yılmaz";
            //}

            //customerName();


            //string studentCard()
            //{
            //    string name = "Arda";
            //    string surname = "Yılmaz";
            //    return "Name Surname: " + name +" "+ surname;

            //}
            //Console.WriteLine(studentCard());





            #endregion

            #region Geriye Deger Donduren String Parametreli  Metotlar

            //string countryCard(string countryName, string capital,string flagColor)
            // {
            //     string cardInfo = "Country: " + countryName + "/Capital: " + capital + "/Flag Color: " + flagColor;
            //     return cardInfo;

            // }
            // string x, y, z;
            // Console.Write("Enter your a Country name: ");
            // x = Console.ReadLine();

            // Console.Write("Enter your a Capital :");                    
            // y = Console.ReadLine();

            // Console.Write("Enter your a flag color: ");
            //     z = Console.ReadLine();

            // Console.WriteLine(countryCard(x, y, z));                    


            #endregion

             #region Geriye Deger Donduren Int Parametreli  Metotlar

            //int sum(int num1,int num2)
            //{
            //    int result = num1 + num2;
            //    return result;
            //}


            //Console.WriteLine(sum(12, 45));
            //Console.WriteLine(sum(678, 123));


            //int Sum(int num1, int num2)
            //{
            //    int result = num1 * num2;
            //    return result;
            //}

            //Console.WriteLine(Sum(12, 45));
            //Console.WriteLine(Sum(678, 123));


            #endregion


            string examResult(string student,int exam1,int exam2,int exam3)
            {
                int reesult = (exam1 + exam2 + exam3) / 3;


                if (reesult >= 50)
                {
                    return student+" the student named passed the course.. Average: "+reesult;
                }
                else
                {
                    return student+" the student named failed the course.Average : " +reesult ;
                }
            
            }
            Console.WriteLine(examResult("Ahmet", 45, 12, 89));
            Console.WriteLine(examResult("Kayla", 45, 80, 100));

            Console.Read();
        }
    }
}
