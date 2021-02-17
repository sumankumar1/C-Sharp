using System;

namespace SortingAlgorithmsComparison.Algorithms
{
    class HeapSort
    {
        private readonly double[] sortedArray;

        public HeapSort(double[] unSortedArray)
        {
            sortedArray = unSortedArray;
        }

        public double[] GetSortedArray()
        {
            for(int lastElementIndex=sortedArray.Length-1; lastElementIndex >= 0 ; lastElementIndex--)
            {
                MaxHeapify(lastElementIndex);
                Swap(0, lastElementIndex);
            }

            return sortedArray;
        }

        private void MaxHeapify(int lastElementIndex)
        {
            for (int childIndex = lastElementIndex; childIndex > 0; childIndex--)
            {
                var possibleParentIndex1 = (childIndex - 1) / 2;
                var possibleParentIndex2 = (childIndex - 2) / 2;
                var parentIndex = possibleParentIndex1 == Math.Floor((decimal)possibleParentIndex1)
                    ? possibleParentIndex1 : possibleParentIndex2;


                if (sortedArray[childIndex] > sortedArray[parentIndex])
                {
                    Swap(childIndex, parentIndex);
                }
            }
        }

        private void Swap(int index1, int index2)
        {
            var temp = sortedArray[index2];
            sortedArray[index2] = sortedArray[index1];
            sortedArray[index1] = temp;
        }
    }
}
