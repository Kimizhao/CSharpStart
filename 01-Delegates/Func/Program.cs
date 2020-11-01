using System;

namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {
            //语法一、public delegate TResult Func<int T, out TResult>(T arg);  
            //语法二、public delegate TResult Func<in T1, in T2, out TResult>(T1 arg, T2 arg2) 
            //常规写法
            Func<int, int, int> Addition = AddNumbers;
            int result = Addition(10, 20);
            Console.WriteLine($"Addition = {result}");

            //Func 匿名写法
            Func<int, int, int> Addition2 = delegate (int param1, int param2)
            {
                return param1 + param2;
            };
            int result2 = Addition2(10, 20);
            Console.WriteLine($"Addition = {result2}");

            //Lambda表达式 写法
            Func<int, int, int> Addition3 = (param1, param2) => param1 + param2;
            int result3 = Addition3(10, 20);
            Console.WriteLine($"Addition = {result3}");
        }

        private static int AddNumbers(int param1, int param2)
        {
            return param1 + param2;
        }
    }
}
