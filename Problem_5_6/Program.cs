using System;
using System.Collections.Generic;

namespace Problem_5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            string str;
            double doub;

            Console.WriteLine("Problem 5");

            Console.Write("Enter n: ");
            n = Convert.ToInt32(Console.ReadLine());

            List<Box<string>> compareStrBoxes = new List<Box<string>>(n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter value: ");
                compareStrBoxes.Add(new Box<string>(Console.ReadLine()));
            }

            Console.Write("Enter element for compare: ");
            str = Console.ReadLine();

            Console.WriteLine(CountLargerElements<string>(compareStrBoxes, str));


            //----------------------------------------------------------------------------------------

            Console.WriteLine("\n\nProblem 6");

            Console.Write("Enter n: ");
            n = Convert.ToInt32(Console.ReadLine());

            List<Box<double>> compareDoubleBoxes = new List<Box<double>>(n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter value: ");
                compareDoubleBoxes.Add(new Box<double>(Convert.ToDouble(Console.ReadLine())));
            }

            Console.Write("Enter element for compare: ");
            doub = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(CountLargerElements<double>(compareDoubleBoxes, doub));
        }

        static int CountLargerElements<T>(List<Box<T>> list, T element) where T : IComparable<T>
        {
            int count = 0;
            foreach(Box<T> box in list)
                if(box.CompareTo(element))
                    count++;

            return count;
        } 
    }
}
