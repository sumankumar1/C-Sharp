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
            // Maxheapify every non-leaf node to build a Max-Heap
            var lastNonLeafNodeIndexinArray = sortedArray.Length / 2 - 1;
            BuildHeap(lastNonLeafNodeIndexinArray);

            // Sort
            for (int lastElementIndex = sortedArray.Length-1; lastElementIndex >= 0 ; lastElementIndex--)
            {
                // Move current root (maximum value) to end
                Swap(0, lastElementIndex);

                // Maxheapify root node in reduced heap
                MaxHeapify(0, lastElementIndex);

                // Reduce heap : exclude end in current heap to get reduced heap
            }

            return sortedArray;
        }

       
        private void BuildHeap (int lastNonLeafNodeIndexinArray)
        {
            for (int currentNonLeafNode = lastNonLeafNodeIndexinArray; currentNonLeafNode >= 0; currentNonLeafNode--)
            {
                MaxHeapify(currentNonLeafNode, sortedArray.Length-1);
            }

        }

        private void MaxHeapify(int currentNonLeafNode, int lastElementIndex)
        {
            int largestElemIndexMustBe = currentNonLeafNode;
            var leftChildNodeIndex = 2 * currentNonLeafNode + 1;
            var rightChildNodeIndex = 2 * currentNonLeafNode + 2;

            if (leftChildNodeIndex < lastElementIndex)
            {
                if(sortedArray[largestElemIndexMustBe] < sortedArray[leftChildNodeIndex])
                {
                    largestElemIndexMustBe = leftChildNodeIndex;
                }
            }

            if (rightChildNodeIndex < lastElementIndex)
            {
                if (sortedArray[largestElemIndexMustBe] < sortedArray[rightChildNodeIndex])
                {
                    largestElemIndexMustBe = rightChildNodeIndex;
                }
            }

            if (largestElemIndexMustBe != currentNonLeafNode)
            {
                Swap(largestElemIndexMustBe, currentNonLeafNode);
                MaxHeapify(largestElemIndexMustBe, lastElementIndex);
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
