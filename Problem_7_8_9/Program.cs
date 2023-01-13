using System;

namespace Problem_7_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputStr = "";
            int length = 0, index1, index2;


            Console.Write("Enter list length: ");
            length = Convert.ToInt32(Console.ReadLine());

            MyList<string> list = new MyList<string>(length);

            for (int i = 0; i < length; i++)
            {
                Console.Write("Add: ");
                inputStr = Console.ReadLine();

                list.Add(inputStr);
            }

            //list = Sorter<string>.QuickSort(list, 0, list.Size);
            //list.Print();


            Console.WriteLine($"Max: {list.Max()}");
            Console.WriteLine($"Min: {list.Min()}");

            Console.Write("Enter element for Greater: ");
            inputStr = Console.ReadLine();
            Console.WriteLine($"Greater: {list.CountGreaterThan(inputStr)}");

            Console.WriteLine("Enter indexs swap: ");
            index1 = Convert.ToInt32(Console.ReadLine());
            index2 = Convert.ToInt32(Console.ReadLine());
            list.Swap(index1, index2);
            Console.WriteLine("List: ");
            list.Print();

            Console.Write("Enter element for Contains: ");
            inputStr = Console.ReadLine();
            Console.WriteLine($"Contains: {list.Contains(inputStr)}");
        }
    }
}
