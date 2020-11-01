using System;

namespace _02_Action
{
    class Program
    {
        private static int result;
        static void Main(string[] args)
        {
            //Action无返回值
            Action<int, int> Addition = AddNumbers;
            Addition(10, 20);
            Console.WriteLine($"Addition = {result}");

            //匿名写法
            Action<int, int> Addition2 = delegate (int param1, int param2)
            {
                result = param1 + param2;
            };
            Addition2(10, 20);
            Console.WriteLine($"Addition = {result}");

            //Lambda 写法
            Action<int, int> Addition3 = (param1, param2) => result = param1 + param2; ;
            Addition3(10, 20);
            Console.WriteLine($"Addition = {result}");
        }

        private static void AddNumbers(int param1, int param2)
        {
            result = param1 + param2;
        }
    }
}
