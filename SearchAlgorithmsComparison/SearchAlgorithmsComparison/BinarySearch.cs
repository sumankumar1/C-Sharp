using System;
using System.Collections.Generic;
using System.Text;

namespace SearchAlgorithmsComparison
{
    class BinarySearch : BaseClass
    {
        public BinarySearch(double[] rawData, double value) : base(rawData, value)
        {
            
        }

        public void Find()
        {
            int n = 0;
            FindRecursive(ref n);

            for (int i=0; i<n; i++)
            {
                if(this.RawData[i] == this.Value)
                {
                    this.Index = i;
                    base.SetElapsedTime();
                    return;
                }
            }
        }

        void FindRecursive(ref int n)
        {
            if (this.RawData.Length < 2) { return; }
            n = this.RawData.Length;

            while(this.RawData[n-1]> this.Value && n>2)
            {
                if (this.RawData[n-1] < this.Value)
                {
                    break;
                }
                else
                {
                    n = (int)Math.Ceiling(n / 2.0);
                }
            }

        }
    }
}
