// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Console.Write("Ввести размер m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввести размер n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] arr = new int[m, n];
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = new Random().Next(-9, 10);
//         Console.Write($"{arr[i,j], 4}");
//     }
//     Console.WriteLine();
// }
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         Console.Write($"{arr[i,j], 4}");
//     }
//     Console.WriteLine();
// }

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
// void FillArray (int m, int n)
// {
//     Console.WriteLine();
//     int[,] array = new int[m,n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = i+j;
//             Console.Write($"{array[i,j], 4}");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Write("Введите m размерность массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите n размерность массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// FillArray(m,n);

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса не чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4
// int [,] FillArray (int m, int n)
// {
//     Console.WriteLine();
//     int[,] array = new int[m,n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = i+j;
//             Console.Write($"{array[i,j], 4}");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }
// int [,] FinalArray (int m, int n)
// {
//     Console.WriteLine();
//     int[,] array = new int[m,n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = i+j;
//             if (i % 2 == 1 && j % 2 == 1) array[i, j] = array[i, j] * array[i, j];
//             Console.Write($"{array[i,j], 4}");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }
// Console.Write("Введите m размерность массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите n размерность массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// FillArray(m,n);
// Console.WriteLine();
// FinalArray(m,n);

// int[,] Arr(int m, int n)
// {
//     int[,] randomArray = new int[m,n];
//     for (int i = 0; i < randomArray.GetLength(0); i++)
//     {
//         Console.WriteLine();
//         for (int j = 0; j < randomArray.GetLength(1); j++)
//         {
//             randomArray[i,j] = new Random().Next(-9,9+1);
//             Console.Write($"{randomArray[i,j],4}");
//         }
//         Console.WriteLine();
//     }
//     return randomArray;
// }
// Console.Write("Введите m размерность массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите n размерность массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] Array=Arr(m,n);
// Console.WriteLine();
//  for (int i = 0; i < m; i++)
//     {
//         Console.WriteLine();
//         for (int j = 0; j < n; j++)
//         {
//              if (i%2!=0 && j%2!=0)
//                 {Array[i,j]=Array[i,j]*Array[i,j];}
//              Console.Write($"{Array[i,j],4}");
//         }
//         Console.WriteLine();
//     }



// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// int[,] Arr(int m, int n)
// {
//     int[,] randomArray = new int[m,n];
//     for (int i = 0; i < randomArray.GetLength(0); i++)
//     {
//         Console.WriteLine();
//         for (int j = 0; j < randomArray.GetLength(1); j++)
//         {
//             randomArray[i,j] = new Random().Next(0,11);
//             Console.Write($"{randomArray[i,j],4}");
//         }
//         Console.WriteLine();
//     }
//     return randomArray;
// }
// Console.Write("Введите m размерность массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите n размерность массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] Array=Arr(m,n);
// int sum = 0;
//  for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//              if (i == j)
//              {
//                 sum = sum + Array[i,j];
//              }
//             }
//     Console.Write($"{sum}");
//     }
