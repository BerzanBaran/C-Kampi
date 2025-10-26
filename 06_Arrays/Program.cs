using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi örnekleri

            //string[] colors = new string[4];
            //colors[0] = " Kırmızı";
            //colors[1] = "Kırmızı";
            //colors[2] = "1234455";
            //colors[3] = "savaş";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Tokyo";
            //cities[1] = "Shangai";
            //cities[2] = "New York";
            //cities[3] = "Londra";
            //cities[4] = "Budapeşte";

            //Console.WriteLine(cities[1]);


            //int[] num = new int[10];
            //num[1] = 50;
            //num[0] = 123;
            //num[4] = 786;
            //num[8] = 908;
            //num[9] = 0;
            //Console.WriteLine(num[7]);


            //string[] cities = { "Tokyo", "Paris", "Münih", "Madrid", "Barcellona", "Shangai", "Monaco" };

            //Console.WriteLine(cities[4]);


            #endregion

            #region Dizideki Tüm Elemanları Sıralama

            int[] number = { 11, 23, 45, 65, 69, 145, 467, 456, 789, 1245 };
            for (int i = 0; i <= number.Length; i++)
            {
                if (number[i] % 3 == 0)
                {
                    Console.WriteLine(number[i]);
                }
            }

            //char[] ch = { 'a', 'b', '6', '+', '1' };
            //for(int i = 0; ch.Length >= i; i++) {

            //    Console.Write(ch[i]);
            //    }

            //int[] myArray = { 12, 23, 43, 11, 67, 456, 76, 90, 123, 457 };
            //int maxnum = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] >maxnum)
            //    {
            //        maxnum = myArray[i];
            //    }
            //}
            //    Console.WriteLine(maxnum);


            //string[] persons = { "ali", "ahmet", "veli", "elifnur", "celil", "canan" };

            //Console.WriteLine(persons.Length);

            //int[] num = { 12, 4, 23, 11, 456, 67, 34, 78, 231 };

            //Array.Sort(num);
            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}


            //int[] num = { 12, 4, 23, 11, 456, 67, 34, 78, 231 };

            //Array.Reverse(num);
            //for(int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}




            #endregion

            #region Dizi metotlaarı

            //string[] customrs = { "ali ", "merve", "buse", "çınar", "kaya" };
            //int index = Array.IndexOf(customrs, "çınar");
            //Console.WriteLine(index);
            //int[] num = { 12, 2, 2, 45, 65, 34, 123, 32, 45, 1567, };
            //Console.WriteLine("Dizini en büyük elemanı: " + num.Max() + " Dizsinin en küçük elemanı: " + num.Min());

            #endregion

            #region Kullanıcıdan değer alma
            //string[] cities =new string[5];

            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($" Lütfen {i + 1}. şehri giriniz. ");
            //    cities[i] = Console.ReadLine();

            //}
            //Console.WriteLine();
            //Console.WriteLine("-----------------");

            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}


            int[] num = { 10, 20, 30, 40, 50 };
            int sum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            Console.WriteLine(sum);




            #endregion

            Console.Read();

        }
    }
}
