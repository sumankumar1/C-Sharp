using System.Diagnostics;

namespace SearchAlgorithmsComparison
{
    abstract class BaseClass
    {
        protected double[] RawData { get; set; }
        public double ElapsedTime { get; set; }
        public int Index { get; set; } = -1;
        protected double Value { get; set; }

        private Stopwatch Clock = new Stopwatch();

        public BaseClass(double[] rawData, double value)
        {
            Clock.Start();
            this.RawData = rawData;
            this.Value = value;
        }

        public void SetElapsedTime()
        {
            this.ElapsedTime = Clock.ElapsedTicks;
        }
    }
}
