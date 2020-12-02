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
                .Repeat(0, 50000)
                .Select(i => (double)randNum.Next(Min, Max))
                .ToArray();

            SortAlgo sortAlgo = new SortAlgo(UnsortedArray);
            sortAlgo.TimeComplexityComparison();
            Console.ReadKey();
        }
    }
}
