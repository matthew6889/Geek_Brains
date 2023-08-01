using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
namespace Homework
{
    class Program
    {
        static void Main(string[] args)//Что бы запустить определенную задачу, раскомментируй нужный task :)
        {
            //task64();
            //task66();
            //task68();
        }
        static void task64()
        //Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
        // N = 5 -> "5, 4, 3, 2, 1"
        // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
        {
            Console.Write("Ввести число N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write($"N = {N} -> ");
            
            string PrintN(int start, int end)
            {
                if (start == 1) return Convert.ToString(start);
                return (start + " " + PrintN(start - 1, end));
            }
            Console.Write(PrintN(N, 1));
        }


        static void task66()
        //Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
        // M = 1; N = 15 -> 120
        // M = 4; N = 8. -> 30
        {
            int EnterValueInt(string text)
            {
                Console.Write(text);
                int value = Convert.ToInt32(Console.ReadLine());
                return value;
            }

            int m = EnterValueInt("Введите число M -> ");
            int n = EnterValueInt("Введите число N -> ");

            int PrintN(int start, int end)
            {
                if (start == end) return start;
                return (start + PrintN(start + 1, end));
            }

            Console.WriteLine($"M = {m}; N = {n} -> {(PrintN(m, n))}");
        }

        static void task68()
        //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
        // m = 2, n = 3 -> A(m,n) = 9
        // m = 3, n = 2 -> A(m,n) = 29
        {
           int EnterValueInt(string text)
            {
                Console.Write(text);
                int value = Convert.ToInt32(Console.ReadLine());
                return value;
            }

            int m = EnterValueInt("Введите число m -> ");
            int n = EnterValueInt("Введите число n -> ");

            int Ackerman (int m, int n)
            {
                if (m == 0) return n + 1;
                else if (m > 0 && n == 0) return Ackerman(m - 1,1);
                else return Ackerman(m-1,Ackerman(m,n-1));
            }

            Console.WriteLine($"А({m},{n}) -> {(Ackerman(m, n))}");
        }
    }
}