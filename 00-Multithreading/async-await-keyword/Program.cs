using System;
using System.Threading;
using System.Threading.Tasks;

namespace async_await_keyword
{
    class Program
    {
        /// <summary>
        /// https://www.csharpstar.com/async-await-keyword-csharp/
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Task<int> value = DoAsyncWork.CalculateSumAsync(10, 11);
            //Do Other processing
            //Console.WriteLine("Value: {0}", value.Result);

            //Task value = DoAsyncWork2.CalculateSumAsync(10, 11);
            //Do Other processing
            //value.Wait();
            //Console.WriteLine("Async stuff is done");

            DoAsyncWork3.CalculateSumAsync(10, 11);
            //Do Other processing
            Thread.Sleep(200);
            Console.WriteLine("Program Exiting");
        }
    }
    /// <summary>
    /// Using an async method that returns a Task<int> object:
    /// </summary>
    static class DoAsyncWork
    {
        public static async Task<int> CalculateSumAsync(int i1, int i2)
        {
            int sum = await Task.Run(() => GetSum(i1, i2));
            return sum;
        }

        private static int GetSum(int i1, int i2)
        {
            return i1 + i2;
        }
    }

    /// <summary>
    /// Using an async method that returns a Task object:
    /// </summary>
    static class DoAsyncWork2
    {
        public static async Task CalculateSumAsync(int i1, int i2)
        {
            int sum = await Task.Run(() => GetSum(i1, i2));
            Console.WriteLine("Value: {0}", sum);
        }

        private static int GetSum(int i1, int i2)
        {
            return i1 + i2;
        }
    }
    /// <summary>
    /// Using an async method that returns a void object:
    /// </summary>
    static class DoAsyncWork3
    {
        public static async void CalculateSumAsync(int i1, int i2)
        {
            int sum = await Task.Run(() => GetSum(i1, i2));
            Console.WriteLine("Value: {0}", sum);
        }

        private static int GetSum(int i1, int i2)
        {
            return i1 + i2;
        }
    }
}
