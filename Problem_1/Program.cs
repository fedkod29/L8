using System;
using System.Collections.Generic;

namespace Problem_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Box<string> strBox = new Box<string>("");
            strBox.InrOut("SomeText");
            //Console.WriteLine(strBox.ToString());

            //Box<double> doubleBox = new Box<double>(12.4);
            //Console.WriteLine(doubleBox.ToString());

            ////----------------------------------------------------------------------------------------

            //Console.WriteLine("\n\nProblem 1");
            //Console.Write("Enter n: ");
            //n = Convert.ToInt32(Console.ReadLine());

            //Box<string>[] boxesStr = new Box<string>[n]; 

            //for(int i = 0; i < n; i++)
            //{
            //    Console.Write("Enter value: ");
            //    boxesStr[i] = new Box<string>(Console.ReadLine());
            //}

            //foreach (Box<string> box in boxesStr)
            //    Console.WriteLine(box.ToString());

            ////----------------------------------------------------------------------------------------

            //Console.WriteLine("\n\nProblem 2");
            //Console.Write("Enter n: ");
            //n = Convert.ToInt32(Console.ReadLine());

            //Box<int>[] boxesInt = new Box<int>[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Enter value: ");
            //    boxesInt[i] = new Box<int>(Convert.ToInt32(Console.ReadLine()));
            //}

            //foreach (Box<int> box in boxesInt)
            //    Console.WriteLine(box.ToString());

        }
    }
}
