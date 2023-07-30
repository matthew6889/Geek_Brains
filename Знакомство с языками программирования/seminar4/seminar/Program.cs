// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if(a > 0)
// {
//     string c = Convert.ToString(a);
//     Console.WriteLine(c.Length);
// }
// else
// {
//     string c = Convert.ToString(a);
//     Console.WriteLine(c.Length - 1);
// }
// //второй вариант
// Console.Write("Введите чило: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// if (A < 0) A = A * (-1);
// while(A > 0)
// {
//     count++;
//     A /= 10;
// }
// Console.WriteLine(count);

// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.Write("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// for (int i = 1; i <= A; i++)
// {
//     count = count+i;
// }
// Console.WriteLine(count);

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Console.Write("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// for (int i = 1; i <= A; i++)
// {
//     count = count * i;
// }
// Console.WriteLine(count);

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0,2);
// }
// Console.WriteLine($"[{string.Join(",",array)}]");

// int[] array = new int[8];
// Console.Write("[");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0,2);
//     Console.Write($"{array[i]}, ");
// }
// Console.WriteLine($"\b\b]");
