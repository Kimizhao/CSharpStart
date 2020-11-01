using System;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        /// <summary>
        /// https://www.csharpstar.com/tasks-csharp/
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //创建
            //Task t = Task.Run(() =>
            //{
            //    for (int x = 0; x < 50; x++)
            //    {
            //        Console.Write("Hi ");
            //    }
            //});
            //t.Wait();

            //任务中返回值
            //Task<int> t = Task.Run(() =>
            //{
            //    return 100;
            //});
            //Console.WriteLine(t.Result); // Displays 100

            //
            Task<Int32[]> parent = Task.Run(() =>
            {
                var results = new Int32[3];
                new Task(() => results[0] = 0,
                TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[1] = 1,
                TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[2] = 2,
                TaskCreationOptions.AttachedToParent).Start();
                return results;
            });
            var finalTask = parent.ContinueWith(
            parentTask => {
                foreach (int i in parentTask.Result)
                    Console.WriteLine(i);
            });
            finalTask.Wait();
        }
    }
}
