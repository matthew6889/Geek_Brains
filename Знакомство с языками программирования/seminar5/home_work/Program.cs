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
            //task34();
            //task36();
            //task38();
        }
        static void task34()
        // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
        // [345, 897, 568, 234] -> 2

        {
            int[] array = new int[5];
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(100,1000);
                if(array[i] % 2 == 0) count = count + 1;
            }
            Console.Write($"[{string.Join(", ", array)}] -> {count}");
        }

        static void task36()
        //Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
        // [3, 7, 23, 12] -> 19
        // [-4, -6, 89, 6] -> 0
        {
            int[] array = new int[new Random().Next(5,10)];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1,100);
                if(array[i] % 2 == 1) sum += array[i];               
            }
            Console.Write($"[{string.Join(", ", array)}] -> {sum}");
        }

        static void task38()
        //Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
        // [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
        {
            double[] array = new  double[new Random().Next(5,10)];
            double min = 0;
            double max = 0;
            //double m = 0;
            double itog = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1,10000) / 100.0;
                min = array.Min();
                max = array.Max();
                // if(array[i] > max) max = array[i];
                // for (int q = 0; q < array.Length; q++)
                // {
                //     m = array[0];
                //     if(array[q] <= m)
                //     {
                //         m = array[q];
                //         min = array[q];
                //     }
                // }
                itog = max - min;
            }
            Console.Write($"[{string.Join(", ", array)}] => {max} - {min} = {itog}");
        }

    }
}