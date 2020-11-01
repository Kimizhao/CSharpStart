using System;

namespace _03_Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            //语法和Func一样，特别之处是返回值永远是布尔类型
            Predicate<string> CheckIfApple = IsApple;
            bool result = CheckIfApple("I Phone X");
            if (result)
                Console.WriteLine("It's an IPhone");

            //匿名表达式
            Predicate<string> CheckIfApple2 = delegate (string modelName) {
                if (modelName == "I Phone X") return true;
                else return false;
            };
            bool result2 = CheckIfApple2("I Phone X");
            if (result2) Console.WriteLine("It's an IPhone");

            //Lambda表达式
            Predicate<string> CheckIfApple3 = modelName => {
                if (modelName == "I Phone X") return true;
                else return false;
            };
            bool result3 = CheckIfApple3("I Phone X");
            if (result3) Console.WriteLine("It's an IPhone");
        }

        private static bool IsApple(string modelName)
        {
            if (modelName == "I Phone X")
                return true;
            else
                return false;
        }
    }
}
