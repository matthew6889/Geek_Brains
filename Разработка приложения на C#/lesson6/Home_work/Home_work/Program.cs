using System;
using System.Xml.Schema;

namespace Home_work
{
    internal class Program
    {
        static void Calculator_GotResult(object sender, EventArgs eventArgs)
        {
            Console.WriteLine($"{((Calcultor)sender).Result}");
        }

        static int calculateSum(List<int> numbers, Func<int, int, int>operation)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                sum = operation(item, sum);
            }
            return sum;
        }

        static void Main(string[] args)
        {
            ICalc cals = new Calcultor();

            //cals.GotResult += Calculator_GotResult;

            string oper;

            double b = 0;

            Console.WriteLine("Что бы закончить вычесление нажмите q или пропуск строки");

            double a = cals.Sum(Convert.ToDouble(Console.ReadLine()));

            while (true)
            {
                oper = Console.ReadLine();

                if (oper != "q" && oper != "")
                {
                    if (oper == "+")
                    {
                        a = cals.Sum(Convert.ToDouble(Console.ReadLine()));
                    }

                    else if (oper == "-")
                    {
                        a = cals.Substruct(Convert.ToDouble(Console.ReadLine()));
                    }

                    else if (oper == "*")
                    {
                        a = cals.Multiply(Convert.ToDouble(Console.ReadLine()));
                    }

                    else if (oper == "/")
                    {
                        a = cals.Divide(Convert.ToDouble(Console.ReadLine()));
                    }
                    else
                    {
                        Console.WriteLine("Неизвестный оператор.");
                    }
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine(string.Format("{0:N2}", a));
        }
    }
}