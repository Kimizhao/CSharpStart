using System;
using System.Threading.Tasks;

namespace DifferentWaysToStartATask
{
    class Program
    {
        /// <summary>
        /// https://www.csharpstar.com/different-ways-to-start-task-csharp/
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //1. The most simple way to start a Task (Using Task Factory):
            Task.Factory.StartNew(() => 
            { 
                Console.WriteLine("Hello World!");
            });

            //2.Using Lambda and named method:
            Task task2 = new Task(() => PrintMessage());
            task2.Start();

            //3.Using Lambda and anonymous method:
            Task task3 = new Task(() => { PrintMessage(); });
            task3.Start();

            //4.Using Action Class
            Task task4 = new Task(new Action(PrintMessage));
            task4.Start();

            //5.Using a Delegate
            Task task5 = new Task(delegate { PrintMessage(); });

            //6.Using Task.Run in .NET4.5:
            DoWork();

            async Task DoWork()
            {
                await Task.Run(() => PrintMessage());
            }

            //where PrintMessage is a method:
            void PrintMessage()
            {
                Console.WriteLine("Hello World!");
            }


        }
    }
}
