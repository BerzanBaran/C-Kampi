using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region YazdirmaKomutlari
            Console.WriteLine("Hello World");

            Console.WriteLine("Selamlar");

            Console.WriteLine("Yemek Servisimiz ");
            Console.WriteLine("1- Hamburger");
            Console.WriteLine("2- Pizza");
            Console.WriteLine("3- Salata");
            Console.Write("Lütfen yemek seçiniz : ");
            #endregion


            #region  string Değişkenler

            string name = "Ahmet";
            Console.WriteLine(name);

            string customerName = "Ahmet";
            string customerSurname = "Yılmaz";
            int customerAge = 25;
            string customerTelephone = "05321234567", customeremail = "deneme@gmail.com";
            string customerCity = "İstanbul", customerDiststrict = "Sarıyer";

            Console.WriteLine("Rezevartion Card");
            Console.WriteLine("Name : " + customerName);
            Console.WriteLine("Surname : " + customerSurname);
            Console.WriteLine("Age : " + customerAge);
            Console.WriteLine("Telephone : " + customerTelephone);
            Console.WriteLine("Email : " + customeremail);
            Console.WriteLine("City : " + customerCity);
            Console.WriteLine("District : " + customerDiststrict);
            Console.WriteLine("**************************");



            #endregion

            #region Int Değişkenler

            int number = 20;


            int hamburgerPrice = 180;
            int cokePrice = 50;
            int waterPrice = 20;
            int pizzaPrice = 250;
            int lemonadePrice = 60;
            int friesPrice = 90;


            Console.WriteLine("*****Restorant Menu Price List*****");
            Console.WriteLine();
            Console.WriteLine("--Hamburger Price : " + hamburgerPrice + " TL");
            Console.WriteLine("--Coke Price : " + cokePrice + " TL");
            Console.WriteLine("--Water Price : " + waterPrice + " TL");
            Console.WriteLine("--Pizza Price : " + pizzaPrice + " TL");
            Console.WriteLine("--Lemonade Price : " + lemonadePrice + " TL");
            Console.WriteLine("--Fries Price : " + friesPrice + " TL");
            Console.WriteLine();

            int totalPrice;

            int hamburgerCount = 3;
            int cokeCount = 2;
            int waterCount = 3;
            int pizzaCount = 0;
            int lemonadeCount = 1;
            int friesCount = 1;
            Console.WriteLine("------------------------------------");

            totalPrice = (hamburgerPrice * hamburgerCount) + (cokePrice * cokeCount) + (waterPrice * waterCount) + (pizzaPrice * pizzaCount) + (lemonadePrice * lemonadeCount) + (friesPrice * friesCount);


            Console.WriteLine("The total amount of food you eat : " + totalPrice + " + TL");


            #endregion



            Console.ReadLine();
        }
    }
}
