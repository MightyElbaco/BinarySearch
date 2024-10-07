// See https://aka.ms/new-console-template for more information

using System;

namespace BinarySearch
{
    internal class Program
    {
        private static int BinarySearch(int[] arr, int find)
        {
            int Start = 0, End = arr.Length - 1, Trials = 0;

            while (Start <= End)
            {
                int Middle = Start + (End - Start) / 2;
                Trials++;

                Console.WriteLine("Trial " + Trials);

                //Check if Middle present find
                if (arr[Middle] == find)
                {
                    Console.WriteLine($"Found after {Trials} Trial/s :)");
                    return Middle;
                }

                // If find greater, ignore left half
                if (find > arr[Middle])
                    Start = Middle + 1;

                // If find is smaller, ignore right half
                else
                    End = Middle - 1;

            }
            Console.WriteLine("Not Found!");
            return -1;
        }


        static void Main(string[] args)
        {

            Random rand = new Random();
            HashSet<int> uniqueNumbers = new HashSet<int>();

            while (uniqueNumbers.Count < 10)
            {
                uniqueNumbers.Add(rand.Next(1, 15)); // Generate numbers between 1 and 15
            }

            int[] uniqueIntegers = new int[10];
            uniqueNumbers.CopyTo(uniqueIntegers);


            int Find = 5;

            int FindIndex = BinarySearch(uniqueIntegers, Find);
        }
    }
}