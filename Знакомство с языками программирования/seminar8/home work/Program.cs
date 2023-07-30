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
            //task54();
            //task56();
            //task58();
            //task60();
            //task62();
        }
        static void task54()
        //Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // В итоге получается вот такой массив:
        // 7 4 2 1
        // 9 5 3 2
        // 8 4 4 2
        {
            Console.Clear();
            int line = 3;
            int column = 4;

            int[,] CreateDoubleArray(int line, int column)
            {
                int[,] array = new int[line, column];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = new Random().Next(1, 10);
                        Console.Write($"{array[i, j],4}");
                    }
                    Console.WriteLine();
                }
                return array;
            }

            int[,] orderArray = CreateDoubleArray(line, column);
            Console.WriteLine();
            Console.WriteLine("В итоге получается вот такой массив:");
            Console.WriteLine();

            void Swap(ref int e1, ref int e2)
            {
                var temp = e1;
                e1 = e2;
                e2 = temp;
            }

            int[,] BubbleSort(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array.GetLength(1) - 1; k++)
                        {
                            if (array[i, k] < array[i, k + 1])
                            {
                                Swap(ref array[i, k + 1], ref array[i, k]);
                            }
                        }
                    }
                }
                return array;
            }
            
            void PrintArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write($"{array[i, j],4} ");
                    }
                    Console.WriteLine();
                }
            }
            PrintArray(BubbleSort(orderArray));
        }


        static void task56()
        //Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // 5 2 6 7
        // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
        {
            Console.Clear();
            int line = 3;
            int column = 4;

            int[,] CreateDoubleArray(int line, int column)
            {
                int[,] array = new int[line, column];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = new Random().Next(1, 10);
                        Console.Write($"{array[i, j],4}");
                    }
                    Console.WriteLine();
                }
                return array;
            }

            int[,] SumArray = CreateDoubleArray(line, column);

            int SumLine(int[,] array, int i)
            {
                int sum = array[i, 0];
                for (int j = 1; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
                return sum;
            }

            int minSum = 1;
            int sum = SumLine(SumArray, 0);

            for (int i = 1; i < SumArray.GetLength(0); i++)
            {
                if (sum > SumLine(SumArray, i))
                {
                    sum = SumLine(SumArray, i);
                    minSum = i + 1;
                }
            }
            Console.WriteLine($"\nСтрока c наименьшей суммой элементов: {minSum}");
        }

        static void task58()
        //Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
        // Например, даны 2 матрицы:
        // 2 4 | 3 4
        // 3 2 | 3 3
        // Результирующая матрица будет:
        // 18 20
        // 15 18
        {
           Console.Clear();
           int line = 2;
           int column = 2;
           
           int[,] CreateArray (int line, int column)
           {
                int[,] array = new int[line,column];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = new Random().Next(1,10);
                        Console.Write($"{array[i, j],4}");
                    }
                    Console.WriteLine();
                }
                return array;
           }

           int[,] firstArray = CreateArray(line,column);
           Console.WriteLine();
           int[,] secondArray = CreateArray(line,column);
           Console.WriteLine();
           int[,] resultArray = new int[line,column];

           void MultiplyArray (int[,] firstArray, int[,]secondArray, int[,]resultArray)
           {
                for (int i = 0; i < resultArray.GetLength(0); i++)
                {
                    for (int j = 0; j < resultArray.GetLength(1); j++)
                    {
                        int sum = 0;
                        for (int k = 0; k < firstArray.GetLength(1); k++)
                        {
                            sum += firstArray[i, k] * secondArray[k, j];
                        }
                        resultArray[i, j] = sum;
                        Console.Write($"{resultArray[i, j],4}");
                    }
                    Console.WriteLine();
                }
           }
           Console.WriteLine("Результирующая матрица будет:");
           MultiplyArray (firstArray, secondArray, resultArray);
        }
        static void task60()
        //Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
        // Массив размером 2 x 2 x 2
        // 66(0,0,0) 25(0,1,0)
        // 34(1,0,0) 41(1,1,0)
        // 27(0,0,1) 90(0,1,1)
        // 26(1,0,1) 55(1,1,1)
        {
            Console.Clear();
            int x = 2;
            int y = 2;
            int z = 2;

            int[,,] CreateDoubleArray(int x, int y, int z)
            {
                int[,,] array = new int[x, y, z];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array.GetLength(2); k++)
                        {
                            array[i, j, k] = new Random().Next(10, 100);
                            Console.Write($"{array[i, j, k],4}");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                return array;
            }

            int[,,] coordinatesArray = CreateDoubleArray(x, y, z);

            void WriteArray (int[,,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array.GetLength(2); k++)
                        {
                            Console.Write($"{array[i, j, k]}({i},{j},{k})  ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
            }
            WriteArray(coordinatesArray);
        }
        static void task62()
        //Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
        // Например, на выходе получается вот такой массив:
        // 01 02 03 04
        // 12 13 14 05
        // 11 16 15 06
        // 10 09 08 07
        {
            Console.Clear();
            int n = 4;
            int[,] doubleArray = new int[n, n];

            int temp = 1;
            int i = 0;
            int j = 0;

            while (temp <= doubleArray.GetLength(0) * doubleArray.GetLength(1))
            {
                doubleArray[i, j] = temp;
                temp++;
                if (i <= j + 1 && i + j < doubleArray.GetLength(1) - 1) j++;
                else if (i < j && i + j >= doubleArray.GetLength(0) - 1) i++;
                else if (i >= j && i + j > doubleArray.GetLength(1) - 1) j--;
                else i--;
            }

            PrintArray(doubleArray);

            void PrintArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] / 10 <= 0) Console.Write($" {array[i, j]} ");
                        else Console.Write($"{array[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}