using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Linq;
using SortingAlgorithmsComparison.Algorithms;

namespace SortingAlgorithmsComparison
{
    public class SortAlgorithms : ISortAlgorithms
    {
        public double[] UnSortedArray { get; set; }
        public double[] SortedArray { get; set; }
        public double TimeSpent { get; set; }
        public ConcurrentDictionary<String, double> ElapsedTimeBySortingMethod { get; set; }
            = new ConcurrentDictionary<String, double> { };

        public SortAlgorithms(double[] array)
        {
            this.UnSortedArray = array;
        }

        public void SelectionSort()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            SortedArray = new SelectionSort(UnSortedArray).GetSortedArray();
            TimeSpent = sw.ElapsedMilliseconds;
            ElapsedTimeBySortingMethod.AddOrUpdate(MethodBase.GetCurrentMethod().Name, TimeSpent,(key, value) => TimeSpent);
        }

        public void BubbleSort()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            SortedArray = new BubbleSort(UnSortedArray).GetSortedArray();
            TimeSpent = sw.ElapsedMilliseconds;
            ElapsedTimeBySortingMethod.AddOrUpdate(MethodBase.GetCurrentMethod().Name, TimeSpent, (key, value) => TimeSpent);
        }

        public void InsertionSort()
        {
            Stopwatch sw = new Stopwatch();
            SortedArray = (double[])UnSortedArray.Clone();
            sw.Start();
            SortedArray = new InsertionSort(UnSortedArray).GetSortedArray();
            TimeSpent = sw.ElapsedMilliseconds;
            ElapsedTimeBySortingMethod.AddOrUpdate(MethodBase.GetCurrentMethod().Name, TimeSpent, (key, value) => TimeSpent);
        }

        public void MergeSort()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            if (SortedArray.Length == 1) { return; }
            SortedArray = new MergeSort(UnSortedArray).GetSortedArray();
            TimeSpent = sw.ElapsedMilliseconds;
            ElapsedTimeBySortingMethod.AddOrUpdate(MethodBase.GetCurrentMethod().Name, TimeSpent, (key, value) => TimeSpent);
        }

        public void QuickSort()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            SortedArray = new QuickSort(UnSortedArray).GetSortedArray();
            TimeSpent = sw.ElapsedMilliseconds;
            ElapsedTimeBySortingMethod.AddOrUpdate(MethodBase.GetCurrentMethod().Name, TimeSpent, (key, value) => TimeSpent);
        }

        public void HeapSort()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            SortedArray = new HeapSort(UnSortedArray).GetSortedArray();
            TimeSpent = sw.ElapsedMilliseconds;
            ElapsedTimeBySortingMethod.AddOrUpdate(MethodBase.GetCurrentMethod().Name, TimeSpent, (key, value) => TimeSpent);
        }

        public void BucketSort()
        {
            throw new NotImplementedException();
        }

        public void CountSort()
        {
            throw new NotImplementedException();
        }

        public void RadixSort()
        {
            throw new NotImplementedException();
        }

        public void InbuiltCollectionList()
        {
            List<double> list = new List<double>(UnSortedArray);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            list.Sort();
            TimeSpent = sw.ElapsedMilliseconds;
            ElapsedTimeBySortingMethod.AddOrUpdate(MethodBase.GetCurrentMethod().Name, TimeSpent, (key, value) => TimeSpent);
            SortedArray = list.ToArray();
        }

        public void Print()
        {
            Print(this.SortedArray);
            Console.WriteLine("Time Taken: {0} ms", TimeSpent);
        }

        public void PrintElapsedTime()
        {
            Console.WriteLine("Time Taken: {0} ms", TimeSpent);
        }

        public void Print(double[] SortedArray)
        {
            Console.WriteLine("Sorted Array: {0}", String.Join(',', SortedArray));
        }

        public void TimeComplexityComparison()
        {
            SelectionSort();
            BubbleSort();
            InsertionSort();
            InbuiltCollectionList();
            MergeSort();
            QuickSort();
            PrintTimeComplexityComparison();
        }

        public void PrintTimeComplexityComparison()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(String.Format("{0,-30} | {1,-20} | {2,-20}", "Sorting Algorithm", "Time Complexity (ms)", "Number of Elements"));
            Console.BackgroundColor = ConsoleColor.Blue;

            Dictionary<String, double> SortedElapsedTimeBySortingMethod = 
                ElapsedTimeBySortingMethod.OrderBy(item => item.Value)
                .ToDictionary(item => item.Key, item => item.Value);

            foreach (KeyValuePair<String, double> ElapsedTime in SortedElapsedTimeBySortingMethod)
            {
                Console.WriteLine(String.Format("{0,-30} | {1,-20} | {2,-20}", ElapsedTime.Key, ElapsedTime.Value, SortedArray.Length));
            }
        }
    }
}
