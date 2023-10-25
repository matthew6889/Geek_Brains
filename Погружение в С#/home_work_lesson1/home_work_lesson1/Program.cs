using System;

namespace seminar1_home_work //Написать программу-калькулятор, вычисляющую выражения вида a + b, a - b, a / b, a * b, введенные из командной строки, и выводящую результат выполнения на экран.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Не верное число аргументов!");
            }
            else
            {
                int a = Convert.ToInt32(args[0]);
                char sign = Convert.ToChar(args[1]);
                int b = Convert.ToInt32(args[2]);
                int equals = 0;
                if (sign == '+')
                {
                    equals = a + b;
                }
                if (sign == '-')
                {
                    equals = a - b;
                }
                if (sign == '*')
                {
                    equals = a * b;
                }
                if (sign == '/')
                {
                    equals = a / b;
                }
                Console.WriteLine($"{a}{sign}{b}={equals}");
            }
            
        }
    }
}