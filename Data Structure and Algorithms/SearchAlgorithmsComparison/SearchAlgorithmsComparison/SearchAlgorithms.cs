using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SearchAlgorithmsComparison
{
    class SearchAlgorithms : BaseClass, ISearchAlgorithms
    {
        public ConcurrentDictionary<string, double> ElapsedTimeByAlgoName { get; set; }
                = new ConcurrentDictionary<string, double>();

        public SearchAlgorithms(double[] rawdata, double value): base(rawdata, value)
        {
            
        }

        public void BinarySearch()
        {   
            BinarySearch binarySearch = new BinarySearch(this.RawData, this.Value);
            binarySearch.Find();
            ElapsedTime = binarySearch.ElapsedTime;
            Index = binarySearch.Index;
            ElapsedTimeByAlgoName.AddOrUpdate(MethodBase.GetCurrentMethod().Name,
                ElapsedTime, (key, value) => ElapsedTime);

        }

        public void CompareTimeComplexity()
        {
            BinarySearch();
            LinearSearch();
            Print();
        }

        public void ExponentialSearch()
        {
            throw new NotImplementedException();
        }

        public void FibonacciSearch()
        {
            throw new NotImplementedException();
        }

        public void InterpolationSearch()
        {
            throw new NotImplementedException();
        }

        public void JumpSearch()
        {
            throw new NotImplementedException();
        }

        public void LinearSearch()
        {
            LinearSearch linearSearch = new LinearSearch(this.RawData, this.Value);
            linearSearch.Find();
            ElapsedTime = linearSearch.ElapsedTime;
            Index = linearSearch.Index;
            ElapsedTimeByAlgoName.AddOrUpdate(MethodBase.GetCurrentMethod().Name,
                ElapsedTime, (key, value) => ElapsedTime);
        }

        public void Print()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(String.Format("{0,-30} | {1,-25} | {2,-20} | {3,-15} | {4,-10}", 
                "Search Algorithm", "Time Complexity (ticks)", "Number of Elements", "FindValue", "FoundAtIndex"));
            Console.BackgroundColor = ConsoleColor.Blue;

            Dictionary<String, double> SortedElapsedTimeByAlgoName =
                ElapsedTimeByAlgoName.OrderBy(item => item.Value)
                .ToDictionary(item => item.Key, item => item.Value);

            foreach (KeyValuePair<String, double> ElapsedTime in SortedElapsedTimeByAlgoName)
            {
                Console.WriteLine(String.Format("{0,-30} | {1,-25} | {2,-20} | {3,-15} | {4,-10}", 
                    ElapsedTime.Key, ElapsedTime.Value, this.RawData.Length, this.Value, this.Index));
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }

    }
}
