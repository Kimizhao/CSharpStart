using System;
using System.Threading;
using System.Threading.Tasks;

namespace CancelingTasks
{
    class Program
    {
        /// <summary>
        /// https://www.csharpstar.com/canceling-tasks-in-csharp/
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            //CancellationToken token = cancellationTokenSource.Token;
            //Task task = Task.Run(() =>
            //{
            //    while (!token.IsCancellationRequested)
            //    {
            //        Console.Write("*");
            //        Thread.Sleep(1000);
            //    }
            //}, token);
            //Console.WriteLine("Press enter to stop the task");
            //Console.ReadLine();
            //cancellationTokenSource.Cancel();
            //Console.WriteLine("Press enter to end the application");
            //Console.ReadLine();

            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;
            Task task = Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.Write("*");
                    Thread.Sleep(1000);
                }
                token.ThrowIfCancellationRequested();
            }, token);

            try
            {
                Console.WriteLine("Press enter to stop the task");
                Console.ReadLine();
                cancellationTokenSource.Cancel();
                task.Wait();
            }
            catch (AggregateException e)
            {
                Console.WriteLine(e.InnerExceptions[0].Message);
            }

            Console.WriteLine("Press enter to end the application");
            Console.ReadLine();
        }
    }
}
