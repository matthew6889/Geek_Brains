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
            //task47();
            //task50();
            //task52();
        }
        static void task47()
        //Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
        // m = 3, n = 4.
        // 0,5 7 -2 -0,2
        // 1 -3,3 8 -9,9
        // 8 7,8 -7,1 9
        {
            Console.Write("Введите кол-во строк: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во столбоц: ");
            int n = Convert.ToInt32(Console.ReadLine());
            void DoubleArray (int m, int n)
            {
                double[,] array = new double[m, n];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = new Random().NextDouble() * 10;
                        Console.Write($"{Math.Round(array[i, j],1), 7}");
                    }
                    Console.WriteLine();
                }
            }
            DoubleArray(m, n);
        }


        static void task50()
        //Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
        // и возвращает значение этого элемента или же указание, что такого элемента нет.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // 17 -> такого числа в массиве нет
        {
            //Console.Write("Введите кол-во строк: ");
            int m = 3;  //Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите кол-во столбоц: ");
            int n = 4;  //Convert.ToInt32(Console.ReadLine());
            int[,] DoubleArray (int m, int n)
            {
                int[,] array = new int[m, n];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = new Random().Next(1, 10);
                        Console.Write($"{(array[i, j]),4}");
                    }
                    Console.WriteLine();
                }
                return array;
            }

            //DoubleArray(m, n);
            Console.WriteLine("Введите координаты массива: ");
            Console.Write("x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int [,] NumberArray = DoubleArray(m, n);
            Console.WriteLine();
            if (x > m || y > n) Console.Write($"[{x}:{y}] -> на этои месте числа нет");
            else
            {
                object? number = NumberArray.GetValue(x, y);
                Console.Write(number);
            }
        }

        static void task52()
        //Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
        {
            //Console.Write("Введите кол-во строк: ");
            int m = 3;  //Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите кол-во столбоц: ");
            int n = 4;  //Convert.ToInt32(Console.ReadLine());
            int[,] DoubleArray (int m, int n)
            {
                int[,] array = new int[m, n];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = new Random().Next(1, 10);
                        Console.Write($"{(array[i, j]),4}");
                    }
                    Console.WriteLine();
                }
                return array;
            }
            int [,] AvgArray = DoubleArray(m, n);
            Console.WriteLine();
            for (int j = 0; j < AvgArray.GetLength(1); j++)
            {
                double avarage = 0;
                for (int i = 0; i < AvgArray.GetLength(0); i++)
                {
                    avarage = (avarage + AvgArray[i, j]);
                }
                avarage = avarage / m;
                Console.Write(Math.Round(avarage,1) + "; ");
            }
            Console.Write("\b\b.");
        }
    }
}