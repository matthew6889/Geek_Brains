using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
namespace HomeworkForTheSecondLecture
{
    class Program
    {
        static void Main(string[] args)//Что бы запустить определенную задачу, раскомментируй нужный task :)
        {
            //task19();
            //task21();
            //task23();
        }
        static void task19()
        // Задача 19
        // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
        // 14212 -> нет
        // 12821 -> да
        // 23432 -> да
        {
            Console.Write("Напишите пятизначное число: ");
            string? palindrome = Console.ReadLine();
            void CheckingNumber(string palindrome)
            {
                if (palindrome[0] == palindrome[4] || palindrome[1] == palindrome[3])
                {
                    Console.WriteLine($"{palindrome} -> да");
                }
                else Console.WriteLine($"{palindrome} -> нет");
            }
            if (palindrome!.Length == 5)
            {
                CheckingNumber(palindrome);
            }
            else Console.WriteLine($"Введи правильное число");
        }

        static void task21()
        // Задача 21
        // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
        // A (3,6,8); B(2, 1, -7), -> 15.84
        // A(7, -5, 0); B(1, -1, 9)-> 11.53
        {
            int enterValue(string prompt)
            {
                Console.Write($"Введите координату точки {prompt}");
                int value = Convert.ToInt32(Console.ReadLine());

                return value;
            }
            
            int xa = enterValue("a по оси x: ");
            int ya = enterValue("a по оси y: ");
            int za = enterValue("a по оси c: ");
            Console.WriteLine();
            int xb = enterValue("b по оси x: ");
            int yb = enterValue("b по оси y: ");
            int zb = enterValue("b по оси c: ");
            Console.WriteLine();

            double distance = Math.Sqrt(Math.Pow((xa - xb), 2) + Math.Pow((ya - yb), 2) + Math.Pow((za - zb), 2));
            Console.Write($"Расстояние между точками равно:{Math.Round(distance, 2)}");
        }

        static void task23()
        // Задача 23
        // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
        // 3 -> 1, 8, 27
        // 5 -> 1, 8, 27, 64, 125
        {
            Console.Write("напишите число N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int q = 0;
            Console.Write($"{n} -> ");
            for (int i = 1; i <= n; i++)
            {
                q = i * i * i;
                Console.Write($"{q}, ");
            }
            Console.Write("\b\b ");
        }

    }
}










