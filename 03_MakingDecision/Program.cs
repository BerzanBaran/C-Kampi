using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            //Console.WriteLine("Please enter your password:");
            //string password;

            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("The password you entered is correct . Welcomme!");
            //    return;
            //}
            //else
            //{
            //    Console.WriteLine("The password you enterd is incorrect .Please try again!");
            //}


            //String capital, country;
            //Console.Write("Enter the capital : ");
            //capital = Console.ReadLine();

            //Console.Write("Enter the country : ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "turkey")
            //{
            //    Console.Write("Data is confirmed");

            //}
            //else
            //{
            //    Console.WriteL("Incorrect information");
            ////}
            //int number;
            //Console.Write("Enter a number: ");
            //number = Convert.ToInt32(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("The number you entered is even.");
            //}
            //else
            //{
            //    Console.WriteLine("The number you entered is odd.");
            //}
            //int exam1, exam2, exam3;
            //string reult = "Hata!";

            //double average;
            //Console.Write("Take your first exam: ");
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("Take your second exam: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Take your third exam: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3.0;
            //Console.WriteLine("**********************************");


            //if (average>0 & average <= 50)
            //{
            //    Console.WriteLine("Unfortunately, you failed the class. Your average is: " + average);
            //}
            //else
            //{
            //    Console.WriteLine("Congratulations, you passed the class. Your average is: " + average);
            //}

            //Console.Write("Please enter your username: ");
            //string username = Console.ReadLine();

            //if(username!="admin")
            //{
            //    Console.WriteLine("Users not found !");

            //}
            //else
            //{
            //    Console.WriteLine(username + " , Your Welcome!");
            //}


            #endregion

            #region Mode Operations
            //int num;
            //Console.Write("Enter a number: ");
            //num = Convert.ToInt32(Console.ReadLine());
            //int mod = num % 2;

            //if (mod == 0)
            //{
            //    Console.WriteLine("The number you entered is couple ");
            //}
            //else
            //{
            //    Console.WriteLine("The number  you entered is unique ");
            //}

            //Console.Write("Enter the first number: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter the second number: ");
            //int num2 = int.Parse(Console.ReadLine());

            //int result = num1 % num2;
            //Console.Write("The remainder of the division of the 1st number by the 2nd number: " + result);

            #endregion

            #region Switch Case
            //Console.Write("Please enter a day number (1-7): ");
            //int day =Convert.ToInt32( Console.ReadLine());
            //Console.WriteLine();

            //switch (day)
            //{
            //    case 1:Console.WriteLine("Monday");break;
            //    case 2:Console.WriteLine("Tuesday");break;
            //    case 3:Console.WriteLine("Wednesday");break;
            //    case 4:Console.WriteLine("Thursday");break;
            //    case 5:Console.WriteLine("Friday");break;
            //    case 6: Console.WriteLine("Saturday");break;
            //    case 7:Console.WriteLine("Sunday");break;
            //default: 
            //     Console.WriteLine("Invalid day number! Please enter a number between 1 and 7.");break;
            //            }

            #endregion
            #region Switch Case with Calculations
           
            Console.Write("Enter the first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Select the operation you want to perform (+, -, *, /): ");
            char sy = Char.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (sy)
            {
                case '+':
                    Console.WriteLine("Result: " + (number1 + number2)); break;
                case '-':
                    Console.WriteLine("Result: " + (number1 - number2)); break;
                    case '*':
                    Console.WriteLine("Result: " + (number1 * number2)); break;

                case '/':   
                    if(number2!=0)
                    {
                       Console.WriteLine("Result: " + (number1 / number2));
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;  

            }

            #endregion
            Console.Read();
        }
    }
}
