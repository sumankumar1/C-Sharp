using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchAlgorithmsComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0, max = 1000000000, i=0, TotalElem = 1000000;
            Random rnd = new Random();

            HashSet<double> HashData = new HashSet<double>();

            while(i< TotalElem)
            {
                HashData.Add((double)rnd.Next(min,max));
                i++;
            }

            double[] RawData = HashData.ToArray();
            double FindValue = RawData[rnd.Next(0, HashData.Count)];

            SearchAlgorithms sortingAlgorithms = new SearchAlgorithms(RawData, FindValue);
            sortingAlgorithms.CompareTimeComplexity();
        }
    }
}
