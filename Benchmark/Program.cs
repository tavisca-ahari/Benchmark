using BenchmarkDotNet.Running;
using System;

namespace Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var ForVsForeachSummary = BenchmarkRunner.Run<ForVsForeach>();
            var ListVsArraySummary = BenchmarkRunner.Run<ListVsArray>();
            var StringVsStringBuilderSummary = BenchmarkRunner.Run<StringVsStringBuilder>();
            var ThreadVsTaskSummary = BenchmarkRunner.Run<ThreadVsTask>();
            var ClassVsStructSummary = BenchmarkRunner.Run<ClassVsStruct>();
            Console.ReadKey();
        }
    }
}
