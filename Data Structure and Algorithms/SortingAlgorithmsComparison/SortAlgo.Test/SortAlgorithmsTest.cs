using System;
using System.Linq;
using NUnit.Framework;


namespace SortingAlgorithmsComparison.Test
{
    public class Tests
    {
        SortAlgorithms sortAlgo;
        double[] Actual;
        readonly int numberOfElementsToSort = (int)Math.Pow(10, 5);

        [SetUp]
        public void Setup()
        {
            int MinValueinArray = 0, MaxValueinArray = numberOfElementsToSort;
            Random randNum = new Random();
            double[] UnsortedArray = Enumerable
                .Repeat(0, numberOfElementsToSort)
                .Select(i => (double)randNum.Next(MinValueinArray, MaxValueinArray))
                .ToArray();

            sortAlgo = new SortAlgorithms(UnsortedArray);
            sortAlgo.InbuiltCollectionList();
            Actual = sortAlgo.SortedArray;
        }

        [Test]
        [Category("pass")]
        public void TestSelectionSort()
        {
            sortAlgo.SelectionSort(); 
            CollectionAssert.AreEqual(Actual,sortAlgo.SortedArray);
        }

        [Test]
        [Category("pass")]
        public void TestBubbleSort()
        {
            sortAlgo.BubbleSort();
            CollectionAssert.AreEqual(Actual, sortAlgo.SortedArray);
        }

        [Test]
        [Category("pass")]
        public void TestInsertionSort()
        {
            sortAlgo.InsertionSort();
            CollectionAssert.AreEqual(Actual, sortAlgo.SortedArray);
        }

        [Test]
        [Category("pass")]
        public void TestMergeSort()
        {
            sortAlgo.MergeSort();
            CollectionAssert.AreEqual(Actual, sortAlgo.SortedArray);
        }

        [Test]
        [Category("pass")]
        public void TestQuickSort()
        {
            sortAlgo.QuickSort();
            CollectionAssert.AreEqual(Actual, sortAlgo.SortedArray);
        }

        [Test]
        [Category("pass")]
        public void TestHeapSort()
        {
            sortAlgo.HeapSort();
            CollectionAssert.AreEqual(Actual, sortAlgo.SortedArray);
        }
    }
}