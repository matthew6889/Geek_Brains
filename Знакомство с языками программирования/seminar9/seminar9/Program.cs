// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Console.Write("Ввести число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write($"N = {N} -> ");
// string PrintN(int start, int end)
// {
//     if(start == end) return Convert.ToString(start);
//     return(start + " " + PrintN(start + 1, end));
// }
// Console.Write(PrintN(1, N));

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// int EnterValueInt (string text)
// {
//     Console.Write(text);
//     int value = Convert.ToInt32(Console.ReadLine());
//     return value;
// }

// int m = EnterValueInt("Введите число M -> ");
// int n = EnterValueInt("Введите число N -> ");
// bool flag = false;
// if (m>n) flag = true;

// string PrintN(int start, int end)
// {
//     if (start == end) return Convert.ToString(start);
//     int step = start + 1;
//     if (flag) step = start -1;
//     return(start + " " + PrintN(step, end));
// }

// Console.WriteLine(PrintN(m, n));

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int EnterValueInt (string text)

// {
//     Console.Write(text);
//     int value = Convert.ToInt32(Console.ReadLine());
//     return value;
// }

// int m = EnterValueInt("Введите число -> ");

// int SumOfNumbers(int number)
// {
//     if (number/10 == 0) return number;
//     return (number%10+SumOfNumbers(number/10)); 
// }

// int sum = SumOfNumbers(m);
// Console.WriteLine(sum);

// Console.Write("Введите число: ");
// string input = Console.ReadLine();
// int sum = CalculateDigitSumRecursive(input, 0);
// Console.WriteLine($"Сумма цифр числа: {sum}");

// static int CalculateDigitSumRecursive(string input, int index)
// {
//     if (index >= input.Length)
//         return 0;
//     char digitChar = input[index];
//     if (char.IsDigit(digitChar))
//     {
//         int digitValue = int.Parse(digitChar.ToString());
//         return digitValue + CalculateDigitSumRecursive(input, index + 1);
//     }
//     return CalculateDigitSumRecursive(input, index + 1);
// }

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// Console.Write("Ввести число A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввести число B: ");
// int B = Convert.ToInt32(Console.ReadLine());

// int Degree(int A, int B)
// {
//     if (B == 0) return (1);
//     return (A * Degree(A, B - 1));
// }

// Console.Write(Degree(A, B));

