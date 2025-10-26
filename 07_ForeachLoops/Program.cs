using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Loop
            //string[] city = { "Milano", "Londra", "Istanbul", "Budapeşte", "Paris", "Roma" };
            //foreach(string i in city)
            //{
            //    Console.WriteLine(i);
            //}
            //int[] num = { 12, 34, 23, 45, 123, 87,8567, 65, 90, 1678 };
            //foreach(int x in num)
            //{
            //    Console.WriteLine(x);

            //}

            //int[] num = { 12, 34, 23, 45, 123, 87, 8567, 65, 90, 1678 };
            //foreach(int i in num)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int[] num = { 12, 34, 23, 45, 123, 87, 8567, 65, 90, 1678 };
            //int total = 0;

            //foreach(int i in num)
            //{
            //    total += i;

            //}
            //Console.WriteLine(total);






            //Console.Write("Number of countries you will visit: ");

            //List<string> cities = new List<string>()
            //{

            //    "Londra","İstanbul","Budapeşte","Paris","Roma","Viyana","Prag","Berlin","Amsterdam","Brüksel","Tokyo"

            //};
            //Console.WriteLine(cities.Count);





            //foreach(string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //string word = "Hi  guys!";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}


            Console.WriteLine("****************Csharp Training Camp****************");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");

            Console.Write("How many students are there in your class? : ");
            int studentCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");


            string[] studentNames = new string[studentCount];
            double[] studentAverage = new double[studentCount];

            for(int i = 0; i < studentCount; i++)
            {
                Console.Write($" {i + 1}. enter your a student name :  ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult =0;


                for(int j = 0; j < 3; j++)
                {

                    Console.Write($"{studentNames[i]} student named {j + 1}. enter your  exam score: ");
                    double value = double.Parse(Console.ReadLine());


                    totalExamResult += value;

                   Console.WriteLine();
                }
                studentAverage[i] = totalExamResult / 3;

            }

            for(int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine($"{studentNames[i]} passed the course and average : {studentAverage[i]}"  );
               

                if (studentAverage[i] >= 50)
                {
                    Console.WriteLine("The student passed the course ");
                }
                else
                {
                    Console.WriteLine("The  student named faailed the course");
                }
                Console.WriteLine("------------------------------------------------------");
            }





            #endregion
            Console.Read();
        }
    }
}
