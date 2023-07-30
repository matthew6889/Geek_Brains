// double[] arr = new double[8];
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = Math.Round(new Random().NextDouble() * 100, 2);
//     Console.Write($"{arr[i]} ");
// }

// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// Console.Write("Введите размер массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение массива: ");
// int minArr = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение массива: ");
// int maxArr = Convert.ToInt32(Console.ReadLine());

// void PrintArr(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
//     Console.Write("\b\b]");
//     Console.WriteLine();
// }
// int[] GenArr(int num, int min, int max)
// {
//     int[] arr = new int[num];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(min, max + 1);
//     }
//     return arr;
// }
// void ReversArry(int[] arr)
// {
//     Console.Write("[");
//     for (int i = arr.Length - 1; i >= 0; i--)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
//     Console.Write("\b\b]");
//     Console.WriteLine();
// }
// int[] ReversArry_2(int[] arr)
// {
//     for (int i = 0; i < arr.Length / 2; i++)
//     {
//         int temp = arr[i];
//         arr[i] = arr[arr.Length - 1 - i];
//         arr[arr.Length - 1 - i] = temp;
//     }
//     return arr;
// }

// int[] arry = GenArr(n, minArr, maxArr);
// PrintArr(arry);
// ReversArry(arry);
// int[] arry_2 = ReversArry_2(arry);
// PrintArr(arry_2);

//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int c = Convert.ToInt32(Console.ReadLine());
// if (a < b + c && b < a + c && c < b + a) Console.WriteLine("Да");
// else Console.WriteLine("Нет");

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string ost = string.Empty; //string ost;
// while (number != 0)
// {
//    ost += Convert.ToString(number % 2);
//    number = number / 2;
// }
// for (int i = ost.Length - 1; i >= 0; i--)
// {
//     Console.Write($"{ost[i]}");
// }

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// void FibonacciCycle (int length)
// {
//     int[] array = new int[length];
//     if (length == 1) array[0] = 0;
//     else if (length == 2) array[1] = 1;
//     else
//     {    
//         array[1] = 1;
//         for (int i = 2; i < length; i++)
//         {
//             array[i] = array[i - 1] +array[i - 2];
//         }
//     }
//     Console.Write($"Числа Фибоначчи: {String.Join(", ",array)}");
// }
// Console.Write("Введите количество чисел ряда Фибоначчи для вывода: ");
// int UserLength = Convert.ToInt32(Console.ReadLine());
// FibonacciCycle(UserLength);

//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
// Console.Write("Введите длинну массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальный элемент массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальный элемент массива: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[length];
// int[] CopyArray = new int[length];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(min,max + 1);
//     //Console.Write($"{array[i]} ");
// }
// Console.Write($"[{String.Join(", ", array)}]");
// Console.Write(" -> ");
// for (int i = 0; i < CopyArray.Length; i++)
// {
//     CopyArray[i] = array[i];
// }
// Console.Write($"[{String.Join(", ", CopyArray)}]");