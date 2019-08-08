using BenchmarkDotNet.Attributes;
using System.Text;

namespace Benchmark
{
    public class StringVsStringBuilder
    {
        [Benchmark]
        public void TestString()
        {
            string string1 = "hello";
            string string2 = "world";
            for (int i = 0; i < 10; i++)
            {
                string result = string1 + string2;
            }
        }

        [Benchmark]
        public void TestStringBuilder()
        {
            StringBuilder result = new StringBuilder("hello");
            for (int i = 0; i < 10; i++)
                result.Append("world");


        }
    }

}
