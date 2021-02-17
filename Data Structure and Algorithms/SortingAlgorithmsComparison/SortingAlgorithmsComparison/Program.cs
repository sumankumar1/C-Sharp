using System;
using System.Linq;

namespace SortingAlgorithmsComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int Min = 0, Max = 20;
            Random randNum = new Random();
            double[] UnsortedArray = Enumerable
                .Repeat(0, 10000)// Set this number carefully, it may lead to stackoverflow in case of QuickSort
                .Select(i => (double)randNum.Next(Min, Max))
                .ToArray();

            SortAlgorithms sortAlgo = new SortAlgorithms(UnsortedArray);
            sortAlgo.TimeComplexityComparison();
            Console.ReadKey();
        }
    }
}
