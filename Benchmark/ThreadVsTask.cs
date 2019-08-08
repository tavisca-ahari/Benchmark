using BenchmarkDotNet.Attributes;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Benchmark
{
    public class ThreadVsTask
    {

        [Benchmark]
        public void TestThread()
        {
            Thread thread1 = new Thread(method1);
            Thread thread2 = new Thread(method2);
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
        }

        [Benchmark]
        public void TestTask()
        {
            Task.Run(async () =>
            {
                var task1 = taskMethod1();
                var task2 = taskMethod2();
                await Task.WhenAll(task1, task2);
            }).GetAwaiter().GetResult();

        }

        public void method1()
        {
            Thread.Sleep(3000);

        }
        public void method2()
        {
            Thread.Sleep(4000);
        }
        public async static Task taskMethod1()
        {
            await Task.Delay(3000);

        }
        public async static Task taskMethod2()
        {
            await Task.Delay(4000);

        }


    }
}
