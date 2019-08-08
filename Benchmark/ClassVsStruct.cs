using BenchmarkDotNet.Attributes;

namespace Benchmark
{
    class ClassVsStruct
    {
        [Benchmark]
        public void TestClass()
        {
            MyClass myClass = new MyClass();
            myClass.value = new int[100];
            for (int i = 0; i < 100; i++)
            {
                myClass.value[i] = i;
            }

        }

        [Benchmark]
        public void TestStruct()
        {
            MyStruct myStruct = new MyStruct();
            myStruct.value = new int[100];
            for (int i = 0; i < 100; i++)
            {
                myStruct.value[i] = i;
            }

        }


    }
    public class MyClass
    {
        public int[] value;
    }

    struct MyStruct
    {
        public int[] value;
    }
}
