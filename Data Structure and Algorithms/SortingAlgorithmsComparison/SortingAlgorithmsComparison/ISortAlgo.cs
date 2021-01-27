using System;
using System.Collections.Concurrent;
using System.Text;

namespace SortingAlgorithmsComparison
{
    interface ISortAlgo
    {
        double[] UnSortedArray { get; set; }
        double[] SortedArray { get; set; }
        double TimeSpent { get; set; }
        ConcurrentDictionary<String, double> ElapsedTimeBySortingMethod { get; set; }

        void SelectionSort();
        void BubbleSort();
        void InsertionSort();
        void MergeSort();
        void QuickSort();
        void HeapSort();
        void RadixSort();
        void CountSort();
        void BucketSort();
        void InbuiltCollectionList();
        void Print();
        void TimeComplexityComparison();
    }
}
