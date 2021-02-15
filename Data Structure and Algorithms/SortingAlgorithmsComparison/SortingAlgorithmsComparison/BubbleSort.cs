

namespace SortingAlgorithmsComparison
{
    class BubbleSort
    {
        private double[] SortedArray;

        public BubbleSort(double[] SortedArray)
        {
            this.SortedArray = SortedArray;
        }

        public double[] GetSortedArray()
        {
            var len = SortedArray.Length;
            bool flag = false;
            double temp, pass = 1;
            while (true)
            {
                for (int i = 0; i < len - pass; i++)
                {
                    if (SortedArray[i] > SortedArray[i + 1])
                    {
                        temp = SortedArray[i];
                        SortedArray[i] = SortedArray[i + 1];
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
            return SortedArray;
        }
    }
}
