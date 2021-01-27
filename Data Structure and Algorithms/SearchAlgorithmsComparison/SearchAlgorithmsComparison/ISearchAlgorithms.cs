using System.Collections.Concurrent;

namespace SearchAlgorithmsComparison
{
    interface ISearchAlgorithms
    {
        ConcurrentDictionary<string, double> ElapsedTimeByAlgoName  { get; set; }

        void LinearSearch();
        void BinarySearch();
        void JumpSearch();
        void InterpolationSearch();
        void ExponentialSearch();
        void FibonacciSearch();
        void Print();
        void CompareTimeComplexity();
    }
}
