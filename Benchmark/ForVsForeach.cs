using BenchmarkDotNet.Attributes;

namespace Benchmark
{
    public class ForVsForeach
    {
        [Benchmark]
        public void ForLoop()
        {
            int[] myInterger = new int[10];
            int total = 0;
            for (int i = 0; i < myInterger.Length; i++)
            {
                total += myInterger[i];
            }
        }

        [Benchmark]
        public void ForeachLoop()
        {
            int[] myInterger = new int[10];
            int total = 0;
            foreach (int i in myInterger)
            {
                total += i;
            }

        }
    }
}
