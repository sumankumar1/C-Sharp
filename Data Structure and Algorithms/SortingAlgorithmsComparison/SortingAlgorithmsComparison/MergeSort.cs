using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithmsComparison
{
    class MergeSort
    {
        private double[] SortedArray;

        public MergeSort(double[] SortedArray)
        {
            this.SortedArray = SortedArray;
        }

        public double[] GetSortedArray()
        {
            var len = SortedArray.Length;

            GetSortedArray(ref SortedArray, len);
            return SortedArray;
        }

        private double[] GetSortedArray(ref double[] array, int len)
        {
            if (len <= 1) { return array; }

            int leftSize = (int)Math.Floor(len / 2.0);
            double[] left = new double[leftSize];
            Array.Copy(array, left, leftSize);

            double[] right = new double[len - leftSize];
            Array.Copy(array, leftSize, right, 0, len - leftSize);

            GetSortedArray(ref left, left.Length);
            GetSortedArray(ref right, right.Length);

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
                    left_index++;
                }
                else
                {
                    mergedArray[main_index] = right[right_index];
                    right_index++;
                }
                main_index++;
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
    }
}
