using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            #region Double Değişkenler
            Console.WriteLine("****Price List****");
            Console.WriteLine();

            double applePrice, orangePrice, strawberryPrice, potatoesPrice, tomatoPrice;
            applePrice = 20.50;
            orangePrice = 15.75;
            strawberryPrice = 70;
            potatoesPrice = 7.50;
            tomatoPrice = 15.80;

            Console.WriteLine("----- Apple unit price : " + applePrice + " TL");
            Console.WriteLine("----- Orange unit price : " + orangePrice + " TL");
            Console.WriteLine("----- Strawberry unit price : " + strawberryPrice + " TL");
            Console.WriteLine("----- Potatoes unit price : " + potatoesPrice + " TL");
            Console.WriteLine("----- Tomato unit price : " + tomatoPrice + " TL");


            double appleWeight, orangeWeight, strawberryWeight, potatoesWeight, tomatoWeight;
            appleWeight = 1.780;
            orangeWeight = 2.350;
            strawberryWeight = 0.550;
            potatoesWeight = 4.430;
            tomatoWeight = 4.430;


            double appleTotal = applePrice * appleWeight;
            double orangeTotal = orangePrice * orangeWeight;
            double strawberryTotal = strawberryPrice * strawberryWeight;
            double potatoesTotal = potatoesPrice * potatoesWeight;
            double tomatoTotal = tomatoPrice * tomatoWeight;


            Console.WriteLine("Product received: Apple -" + "Unit price: " + applePrice + " -Weight: " + appleWeight + " Total price: " + appleTotal);
            Console.WriteLine("Product received: Orange -" + "Unit price: " + orangePrice + " -Weight: " + orangeWeight + " Total price: " + orangeTotal);
            Console.WriteLine("Product received:  Strawberry -" + "Unit price: " + strawberryPrice + " -Weight: " + strawberryWeight + " Total price: " + strawberryTotal);
            Console.WriteLine("Product received:  Potatoes -" + "Unit price: " + potatoesPrice + " -Weight: " + potatoesWeight + " Total price: " + potatoesTotal);
            Console.WriteLine("Product received: Tomato -" + "Unit price: " + tomatoPrice + " -Weight: " + tomatoWeight + " Total price: " + tomatoTotal);

            double Total = appleTotal + orangeTotal + strawberryTotal + potatoesTotal + tomatoTotal;
            Console.WriteLine("**************************");
            Console.WriteLine("Total Amount to be Paid : " + Total + " TL");

            #endregion

            #region Char Değişkenler
            //char sybol1 = 'A';
            //Console.WriteLine(sybol1);

            #endregion(Veri girişleri)

            #region String Değişkenler
            //Console.WriteLine("***** reservation Card*****");
            //Console.WriteLine();
            //string customerName, customerSurname, customerPhone, customerEmail, customerAddress, customerCity;
            //Console.Write("Please enter your name : ");
            //customerName = Console.ReadLine();
            //Console.Write("Please enter your surame: ");
            //customerSurname = Console.ReadLine();
            //Console.Write("Please enter your phone number : ");
            //customerPhone = Console.ReadLine();
            //Console.Write("Please enter your email adress:");
            //customerEmail = Console.ReadLine();
            //Console.Write("Please enter your adress : ");
            //customerAddress = Console.ReadLine();
            //Console.Write("Please enter your city : ");
            //customerCity = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("***** Reservation Card *****");
            //Console.WriteLine("Customer Name Surname : " + customerName + " " + customerSurname);
            //Console.WriteLine("Customer Phone Number : " + customerPhone);
            //Console.WriteLine("Customer Email Adress : " + customerEmail);
            //Console.WriteLine("Customer Adress : " + customerAddress);
            //Console.WriteLine("Customer City : " + customerCity);
            //Console.WriteLine("*************************");


            #endregion

            #region İnt Değişkenler(Klavyeden veri girişi)

            //int shoesPrice, clothesPrice, hatPrice, tshirtPrice, totalPrice;
            //shoesPrice = 800;
            //clothesPrice = 1200;
            //hatPrice = 250;
            //tshirtPrice = 200;


            //int shoesCount, clothesCount, hatCount, tshirtCount;
            //Console.Write("Please enter the number of shoes you want to by: ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Please enter the number of clothes you want to by: ");
            //clothesCount = int.Parse(Console.ReadLine());
            //Console.Write("Please enter the number of hats you want to by: ");
            //hatCount = int.Parse(Console.ReadLine());
            //Console.Write("Please enter the number of t-shirts you want to by: ");
            //tshirtCount = int.Parse(Console.ReadLine());

            //totalPrice = shoesCount * shoesPrice + clothesCount * clothesPrice + hatCount * hatPrice + tshirtCount * tshirtPrice;

            //Console.WriteLine("**************************");
            //Console.WriteLine("Total amount to be paid : " + totalPrice + " Tl");





            #endregion

            #region Ondalılklı Değişkenler(Klavye veri girişi)

            //double exam1, exam2, exam3, average;
            //Console.Write("Please enter your first exam score: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Please enter your second exam score: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Please enter your third exam score: ");
            //exam3 = double.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("**************************");

            //Console.WriteLine("Your average score is : " + average);



            #endregion

            #region Karakter Değişkenleri (Klavye veri girişi)

            //char gender;
            //Console.Write("Please enter your gender(E/K): ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("**************************");
            //Console.WriteLine("Your gender is: " + gender);

            #endregion

            Console.Read();
        }
    }
}
