using System;
using System.Xml.Schema;

namespace lesson6
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

        static void Execute (Action<int> action, int value = 10)
        {
            try
            {
                action.Invoke(value);
            }
            catch (CalculatorDivideByZeroException ex)
            {
                Console.WriteLine(ex);
            }
            catch (CalculateOperationCauseOverflowException ex)
            {
                Console.WriteLine(ex);
            }
        }

        static void Main(string[] args)
        {
            //ICalc cals = new Calcultor();

            ////cals.GotResult += Calculator_GotResult;

            //string oper;

            //int b = 0;

            //Console.WriteLine("Что бы закончить вычесление нажмите q или пропуск строки");

            //int a = cals.Sum(Convert.ToInt32(Console.ReadLine()));

            //while (true)
            //{
            //    oper = Console.ReadLine();

            //    if (oper != "q" && oper != "")
            //    {
            //        if (oper == "+")
            //        {
            //            a = cals.Sum(Convert.ToInt32(Console.ReadLine()));
            //        }

            //        else if (oper == "-")
            //        {
            //            a = cals.Substruct(Convert.ToInt32(Console.ReadLine()));
            //        }

            //        else if (oper == "*")
            //        {
            //            a = cals.Multiply(Convert.ToInt32(Console.ReadLine()));
            //        }

            //        else if (oper == "/")
            //        {
            //            a = cals.Divide(Convert.ToInt32(Console.ReadLine()));
            //        }
            //        else
            //        {
            //            Console.WriteLine("Неизвестный оператор.");
            //        }
            //    }
            //    else
            //    {
            //        break;
            //    }

            //}
            //Console.WriteLine(a);

            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //int res = calculateSum(numbers, (x, y) => x + y);

            //Console.WriteLine(res);

            ICalc cals = new Calcultor();

            cals.GotResult += Calculator_GotResult;

            Execute(cals.Substruct, int.MaxValue);

            Execute(cals.Substruct, int.MaxValue);

            Execute(cals.Sum, int.MaxValue);

            Execute(cals.Sum, int.MaxValue);

            Execute (cals.Divide, 0);

            Execute(cals.Multiply);

            //Execute(cals.Sum);

            //Execute(cals.Substruct);

            //Execute(cals.Multiply);

            //Execute(cals.CanselLast();

        }
    }
}