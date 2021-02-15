
namespace SortingAlgorithmsComparison
{
    public class SelectionSort
    {
        private double[] SortedArray { get; set; }

        public SelectionSort(double[] SortedArray)
        {
            this.SortedArray = SortedArray;
        }

        public double[] GetSortedArray()
        {
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

            return this.SortedArray;
        }
     
    }
}
