using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Linq;

namespace SortingAlgorithmsComparison
{
    public class SortAlgo : ISortAlgo
    {
        public double[] UnSortedArray { get; set; }
        public double[] SortedArray { get; set; }
        public double TimeSpent { get; set; }
        public ConcurrentDictionary<String, double> ElapsedTimeBySortingMethod { get; set; }
            = new ConcurrentDictionary<String, double> { };

        public SortAlgo(double[] array)
        {
            this.UnSortedArray = array;
        }

        public void SelectionSort()
        {
            Stopwatch sw = new Stopwatch();
            SortedArray = (double[])UnSortedArray.Clone();

            sw.Start();
            var len = SortedArray.Length;
            for (int i = 0; i < len - 1; i++)
            {
                int min_index = i;
                for (int j = i + 1; j < len; j++)
                {
                    if (SortedArray[min_index] > SortedArray[j])
                    {
                        min_index = j;
                    }
                }
                if (min_index != i)
                {
                    var temp = SortedArray[i];
                    SortedArray[i] = SortedArray[min_index];
                    SortedArray[min_index] = temp;
                }
            }

            TimeSpent = sw.ElapsedMilliseconds;
            ElapsedTimeBySortingMethod.AddOrUpdate(MethodBase.GetCurrentMethod().Name, TimeSpent,(key, value) => TimeSpent);
        }

        public void BubbleSort()
        {
            Stopwatch sw = new Stopwatch();
            SortedArray = (double[])UnSortedArray.Clone();
            int len = SortedArray.Length;
            sw.Start();

            bool flag = false;
            double temp,pass=1;
            while(true)
            {
                for(int i=0;i<len-pass;i++)
                {
                    if(SortedArray[i]>SortedArray[i+1])
                    {
                        temp = SortedArray[i];
                        SortedArray[i] = SortedArray[i+1];
                        SortedArray[i + 1] = temp;
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    break;
                }
                pass += 1;
                flag = false;
            }    

            TimeSpent = sw.ElapsedMilliseconds;
            ElapsedTimeBySortingMethod.AddOrUpdate(MethodBase.GetCurrentMethod().Name, TimeSpent, (key, value) => TimeSpent);
        }

        public void BucketSort()
        {
            Stopwatch sw = new Stopwatch();
            SortedArray = (double[])UnSortedArray.Clone();
            sw.Start();

            TimeSpent = sw.ElapsedMilliseconds;
            ElapsedTimeBySortingMethod.AddOrUpdate(MethodBase.GetCurrentMethod().Name, TimeSpent, (key, value) => TimeSpent);
            throw new NotImplementedException();
        }

        public void CountSort()
        {
            Stopwatch sw = new Stopwatch();
            SortedArray = (double[])UnSortedArray.Clone();
            sw.Start();

            TimeSpent = sw.ElapsedMilliseconds;
            ElapsedTimeBySortingMethod.AddOrUpdate(MethodBase.GetCurrentMethod().Name, TimeSpent, (key, value) => TimeSpent);
            throw new NotImplementedException();
        }

        public void HeapSort()
        {
            Stopwatch sw = new Stopwatch();
            SortedArray = (double[])UnSortedArray.Clone();
            sw.Start();

            TimeSpent = sw.ElapsedMilliseconds;
            ElapsedTimeBySortingMethod.AddOrUpdate(MethodBase.GetCurrentMethod().Name, TimeSpent, (key, value) => TimeSpent);
            throw new NotImplementedException();
        }

        public void InsertionSort()
        {
            Stopwatch sw = new Stopwatch();
            SortedArray = (double[])UnSortedArray.Clone();
            sw.Start();

            int len=SortedArray.Length, IndexToBeCompared;
            double temp;
            for(int i=1; i<len;  i++)
            {
                IndexToBeCompared = i;
                while(IndexToBeCompared>0 && SortedArray[IndexToBeCompared-1] > SortedArray[IndexToBeCompared])
                {
                    temp = SortedArray[IndexToBeCompared];
                    SortedArray[IndexToBeCompared] = SortedArray[IndexToBeCompared - 1];
                    SortedArray[IndexToBeCompared - 1] = temp;
                    IndexToBeCompared -= 1;
                }
            }

            TimeSpent = sw.ElapsedMilliseconds;
            ElapsedTimeBySortingMethod.AddOrUpdate(MethodBase.GetCurrentMethod().Name, TimeSpent, (key, value) => TimeSpent);
        }

        public void MergeSort()
        {
            Stopwatch sw = new Stopwatch();
            double[] SortedArray = (double[])UnSortedArray.Clone();
            sw.Start();

            int len = SortedArray.Length;
            if (len == 1) { return; }
            
            MergeSort(ref SortedArray, len);

            TimeSpent = sw.ElapsedMilliseconds;
            ElapsedTimeBySortingMethod.AddOrUpdate(MethodBase.GetCurrentMethod().Name, TimeSpent, (key, value) => TimeSpent);
            this.SortedArray = SortedArray;
        }

        private double[] MergeSort(ref double [] array,int len)
        {
            if (len <= 1) { return array; }

            int leftSize = (int)Math.Floor(len / 2.0);
            double[] left = new double[leftSize];
            Array.Copy(array,left, leftSize);

            double[] right = new double[len - leftSize];
            Array.Copy(array, leftSize , right, 0, len - leftSize);

            MergeSort(ref left, left.Length);
            MergeSort(ref right, right.Length);

            SortAndMergeArray(ref left, ref right, ref array);
            return array;
        }

        private void SortAndMergeArray(ref double[] left, ref double[] right, ref double[] mergedArray)
        {
            int main_index = 0, left_index = 0, right_index = 0;

            while (main_index < mergedArray.Length && left_index < left.Length && right_index < right.Length)
            {
                if (left[left_index] <= right[right_index])
                {
                    mergedArray[main_index] = left[left_index];
                    left_index ++;
                }
                else
                {
                    mergedArray[main_index] = right[right_index];
                    right_index ++;
                }
                main_index ++;
            }

            while (left_index < left.Length)
            {
                mergedArray[main_index] = left[left_index];
                left_index++;
                main_index++;
            }
            while (right_index < right.Length)
            {
                mergedArray[main_index] = right[right_index];
                right_index++;
                main_index++;
            }
        }
        public void QuickSort()
        {
            Stopwatch sw = new Stopwatch();
            double[] UnSortedArray = (double[])this.UnSortedArray.Clone();
            sw.Start();

            QuickSort(ref UnSortedArray, 0, UnSortedArray.Length-1);
            
            TimeSpent = sw.ElapsedMilliseconds;
            ElapsedTimeBySortingMethod.AddOrUpdate(MethodBase.GetCurrentMethod().Name, TimeSpent, (key, value) => TimeSpent);
            this.SortedArray = UnSortedArray;
        }

        private void QuickSort(ref double[] unSortedArray, int start ,int end)
        {
            if (start >= end) { return; }
            int pIndex = start;
            Partition(ref pIndex, ref unSortedArray, start, end);
            QuickSort(ref unSortedArray, start, pIndex-1);
            QuickSort(ref unSortedArray, pIndex+1, end);
        }

        private void Partition(ref int pIndex, ref double[] unSortedArray, int start, int end)
        {
            double temp, pivot = unSortedArray[end];
            for (int i = start; i< end ; i++ )
            {
                if(unSortedArray[i] <= pivot)
                {
                    temp = unSortedArray[i];
                    unSortedArray[i] = unSortedArray[pIndex];
                    unSortedArray[pIndex] = temp;
                    pIndex++;
                }
            }
            temp = unSortedArray[end];
            unSortedArray[end] = unSortedArray[pIndex];
            unSortedArray[pIndex] = temp;
        }

        public void RadixSort()
        {
            Stopwatch sw = new Stopwatch();
            SortedArray = (double[])UnSortedArray.Clone();
            sw.Start();

            TimeSpent = sw.ElapsedMilliseconds;
            ElapsedTimeBySortingMethod.AddOrUpdate(MethodBase.GetCurrentMethod().Name, TimeSpent, (key, value) => TimeSpent);
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
