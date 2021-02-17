

namespace SortingAlgorithmsComparison.Algorithms
{
    class InsertionSort
    {
        private double[] SortedArray { get; set; }

        public InsertionSort(double[] SortedArray)
        {
            this.SortedArray = SortedArray;
        }

        public double[] GetSortedArray()
        {
            int len = SortedArray.Length, IndexToBeCompared;
            double temp;
            for (int i = 1; i < len; i++)
            {
                IndexToBeCompared = i;
                while (IndexToBeCompared > 0 && SortedArray[IndexToBeCompared - 1] > SortedArray[IndexToBeCompared])
                {
                    temp = SortedArray[IndexToBeCompared];
                    SortedArray[IndexToBeCompared] = SortedArray[IndexToBeCompared - 1];
                    SortedArray[IndexToBeCompared - 1] = temp;
                    IndexToBeCompared -= 1;
                }
            }
            return this.SortedArray;
        }
    }
}
