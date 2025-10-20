using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for loop (for döngüsü)


            //int i;
            //for (int j = 1; j <= 9; j++)
            //{
            //    Console.WriteLine("I am starting");
            //}
            //for (i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Please enter the number of numbers you want to be displayed on the screen: ");

            //int finalNumber = Convert.ToInt32(Console.ReadLine());

            //for(int i = 4; i <= finalNumber; i += 3)
            //{
            //    Console.WriteLine(i);
            //}




            #endregion

            #region for loop and decision structures(for döngüsü ve karar yapıları)

            //for(int i = 5; i <= 50; i++)
            //{
            //    if(i%3==0& i % 4 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //int totalValue = 0;
            //for (int i = 1; i < 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //    }
            //    else
            //    {
            //        totalValue -= i;
            //    }
            //}
            //Console.WriteLine("Total value: " + totalValue);

            // int count = 0;
            // for(int i = 1; i <= 80; i++)
            // {
            //     if (i % 8 == 0)
            //     {
            //         count++;
            //     }
            //}

            // Console.WriteLine(count);


            int bacterium = 1;
            for (int i = 1; i <= 24; i++)
            {
                bacterium *= 2;
                Console.WriteLine(i + ".Bacterial count at the end of the hour: " + bacterium);
            }


            #endregion

            #region While Loop (While Döngüsü)

            //int i = 1;
            //while (i < 15){

            //    Console.WriteLine("Hi Looops");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 12)
            //{
            //    if (i % 4 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //        i++;

            //}
            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);





            #endregion

            #region The sum of the place values ​​of the number entered from the keyboard
            // Klavyeden girilen sayının basamak değerlerinin toplamı(1.yol)

            //int num, sum;
            //Console.Write("Please enter a number. ");
            //num = Convert.ToInt32(Console.ReadLine());
            //for(sum=0; num != 0; num = num / 10)
            //{
            //    sum = num % 10 + sum;
            //    Console.WriteLine(sum);
            //}


            int number ,ones, tens, hundreds, thousands, sum;
            Console.Write("Please enter a number between(1-9999): ");
            number = int.Parse(Console.ReadLine());


            ones = number % 10;
            tens = (number % 100) / 10;
            hundreds = (number % 1000) / 100;
            thousands = (number % 1000) / 1000;

            sum = ones + tens + hundreds + thousands;
            Console.WriteLine(sum);


            #endregion

            Console.Read();

        }
    }
}
