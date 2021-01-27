namespace SearchAlgorithmsComparison
{
    class LinearSearch : BaseClass
    {
        public LinearSearch(double[] rawdata, double value): base(rawdata, value) { }

        public void Find()
        {
            for(int i=0;i<this.RawData.Length;i++)
            {
                if(this.RawData[i] == this.Value)
                {
                    this.Index = i;
                    base.SetElapsedTime();
                    return;
                }
            }
        }
    }
}
