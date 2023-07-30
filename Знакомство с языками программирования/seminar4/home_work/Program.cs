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
            //task25();
            task27();
            //task29();
        }
        static void task25()
        //Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
        // 3, 5 -> 243 (3⁵)
        // 2, 4 -> 16
        {
            Console.Write("Введите число A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = 1;
            for (int i = 0; i < b; i++)
            {
                c = c * a;
            }
            Console.Write(c);
        }

        static void task27()
        // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
        {
            int Prompt (string mes)
            {
                Console.Write(mes);
                string? readInput = Console.ReadLine();
                int res = Convert.ToInt32(readInput);
                return res;
            }
            int Sum(int num)
            {
                int res = 0;
                while (num > 0)
                {
                    res += num % 10;
                    num = num / 10;
                }
                return res;
            }
            int num = Prompt("Введите число: ");
            Console.WriteLine($"{num} -> {Sum(num)} \u263A");
        }

        static void task29()
        // Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
        {
            Console.Write("Введите длинну массива: ");
            int LenArray = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите диапазон чисел массива от ... до ... (через пробел):");
            string[] OutS = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(OutS[0]);
            int b = Convert.ToInt32(OutS[1]);
            
            int[] array = new int[LenArray];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(a, b);
            }
            Console.WriteLine($"[{string.Join(",", array)}]");
        }

    }
}