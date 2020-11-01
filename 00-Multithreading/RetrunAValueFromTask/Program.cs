using System;
using System.Threading.Tasks;

namespace RetrunAValueFromTask
{
    class Program
    {
        /// <summary>
        /// https://www.csharpstar.com/return-a-value-from-task-csharp/
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        static async Task Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            await DoWork();
        }

        #region
        public static async Task DoWork()
        {
            //Using Task.Run in C#:
            Func<int> function = new Func<int>(() => ReturnSum(10, 20));
            int res = await Task.Run<int>(function);

            //Using Task.Factory.StartNew in C#:
            //Func<int> function = new Func<int>(() => ReturnSum(10, 20));
            //int res = await Task.Factory.StartNew<int>(function);

            //Using Task.FromResult in C#:
            //int res = await Task.FromResult<int>(ReturnSum(10, 20));

            Console.WriteLine(res);
        }

        private static int ReturnSum(int a, int b)
        {
            return a + b;
        }
        #endregion
    }
}
