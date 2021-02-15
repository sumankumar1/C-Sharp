

namespace SortingAlgorithmsComparison
{
    class QuickSort
    {
        private double[] SortedArray;

        public QuickSort(double[] SortedArray)
        {
            this.SortedArray = SortedArray;
        }

        public double[] GetSortedArray()
        {
            var len = SortedArray.Length;
            GetSortedArray(ref SortedArray, 0, SortedArray.Length - 1);
            return SortedArray;
        }

        private void GetSortedArray(ref double[] unSortedArray, int start, int end)
        {
            if (start >= end) { return; }
            int pIndex = start;
            Partition(ref pIndex, ref unSortedArray, start, end);
            GetSortedArray(ref unSortedArray, start, pIndex - 1);
            GetSortedArray(ref unSortedArray, pIndex + 1, end);
        }

        private void Partition(ref int pIndex, ref double[] unSortedArray, int start, int end)
        {
            double temp, pivot = unSortedArray[end];
            for (int i = start; i < end; i++)
            {
                if (unSortedArray[i] <= pivot)
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
    }
}
