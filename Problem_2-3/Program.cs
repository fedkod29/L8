using System;
using System.Collections.Generic;
using System.Transactions;

namespace Problem_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, firstIndex, secondIndex;

            Console.WriteLine("Problem 3");

            Console.Write("Enter n: ");
            n = Convert.ToInt32(Console.ReadLine());

            List<Box<string>> swapStrBoxes = new List<Box<string>>(n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter value: ");
                swapStrBoxes.Add(new Box<string>(Console.ReadLine()));
            }

            Console.Write("Enter firts index: ");
            firstIndex = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second index: ");
            secondIndex = Convert.ToInt32(Console.ReadLine());

            if (firstIndex == secondIndex || firstIndex > n || secondIndex > n)
                throw new Exception("The first index cannot be equal to the second index");

            Swap<string>(swapStrBoxes, firstIndex, secondIndex);

            Console.WriteLine("Swap =>");
            foreach (Box<string> box in swapStrBoxes)
                Console.WriteLine(box.ToString());


            Console.WriteLine("\n\nProblem 4");

            Console.Write("Enter n: ");
            n = Convert.ToInt32(Console.ReadLine());

            List<Box<int>> swapIntBoxes = new List<Box<int>>(n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter value: ");
                swapIntBoxes.Add(new Box<int>(Convert.ToInt32(Console.ReadLine())));
            }

            Console.Write("Enter firts index: ");
            firstIndex = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second index: ");
            secondIndex = Convert.ToInt32(Console.ReadLine());

            if (firstIndex == secondIndex || firstIndex > n || secondIndex > n)
                throw new Exception("The first index cannot be equal to the second index");

            Swap<int>(swapIntBoxes, firstIndex, secondIndex);

            Console.WriteLine("Swap =>");
            foreach (Box<int> box in swapIntBoxes)
                Console.WriteLine(box.ToString());
        }

        static void Swap<T>(List<Box<T>> list, int fisrtIndex, int secondIndex)
        {
            Box<T> tmp = list[fisrtIndex];
            list[fisrtIndex] = list[secondIndex];
            list[secondIndex] = tmp;
        }
    }
}
