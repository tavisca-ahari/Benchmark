using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace Benchmark
{
    public class ListVsArray
    {
        [Benchmark]
        public void TestList()
        {
            List<int> list = new List<int>(100);
            for (int i = 0; i <= 100; i++)
            {
                list.Add(i);
            }
        }

        [Benchmark]
        public void TestArray()
        {
            int[] array = new int[100];
            for (int i = 0; i < 100; i++)
            {
                array[i] = i;
            }
        }

    }
}
