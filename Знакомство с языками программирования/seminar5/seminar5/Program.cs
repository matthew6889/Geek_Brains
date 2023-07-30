// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
// int [] array = new int[12];
// int sumpos = 0;
// int sumneg = 0;

// Console.Write("[");

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-9,10);
//     Console.Write($"{array[i]}, ");
//     if (array[i] < 0) sumneg += array[i];
//     else sumpos += array[i];
// }
// Console.Write("\b\b]");
// Console.WriteLine();
// Console.WriteLine("Сумма положительных элементов: {0}", sumpos);
// Console.WriteLine("Сумма отрицательных элементов: {0}", sumneg);


// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
// int [] arr = new int[4];
// Console.Write("[");
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = new Random().Next(-10,11);
//     Console.Write($"{arr[i]}, ");
// }
// Console.Write("\b\b]");
// Console.Write(" -> ");
// Console.Write("[");
// for (int i = 0; i < arr.Length ; i++)
// {
//     arr[i] = arr[i] * (-1);
//     Console.Write($"{arr[i]}, ");
// }
// Console.Write("\b\b]");

// int EnterValue (string text)
// {
//     Console.Write(text);
//     int value = Convert.ToInt32(Console.ReadLine());

//     return value;
// }

// int NumberGeneration (int firstNumber, int secondNumber)

// {

//     return new Random().Next(firstNumber, secondNumber + 1);

// }

// int[]MassiveChanger (int[] array, int startMassive, int finishMassive)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = NumberGeneration (startMassive, finishMassive);
//     }

//     return array;
// }

// int[]MassiveReverse(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = array[i]*(-1);
//     }

//     return array;

// }

// int arraySize = EnterValue("Введите размер массива");

// int[] array = new int[arraySize]; // по умолчанию заполнится нулями

// array = MassiveChanger(array, -20, 30);

// Console.WriteLine($"Сгенерированный массив -> [{string.Join(", ", array)}]");

// array = MassiveReverse(array);


// Console.WriteLine($"Измененный массив -> [{string.Join(", ", array)}]");

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// int EnterValue (string text)
// {
//     Console.Write(text);
//     int value = Convert.ToInt32(Console.ReadLine());
//     return value;
// }
// int NumberGeneration (int firstNumber, int secondNumber)
// {
//     return new Random().Next(firstNumber, secondNumber + 1);
// }
// int[]MassiveChanger (int[] array, int startMassive, int finishMassive)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = NumberGeneration (startMassive, finishMassive);
//     }
//     return array;
// }
// int massiveSize = EnterValue("Введите длину массива -> ");
// int searchNumber = EnterValue ("Введите число, которое будем искать в массиве ->");
// int result = 0;
// int[] array = new int[massiveSize];
// array = MassiveChanger(array, -5, -1);
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == searchNumber || array[i]*(-1)== searchNumber) result++;
// }
// if (result>0)
// {
//     Console.WriteLine($"В Массиве -> [{string.Join(", ", array)}] число {searchNumber} -> ПРИСУТСТВУЕТ");
// }
// else
// {
//      Console.WriteLine($"В Массиве -> [{string.Join(", ", array)}] число {searchNumber} -> НЕПРИСУТСТВУЕТ");
// }

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] array = new int[2];
// Console.Write("[");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0,1000);
//     Console.Write($"{array[i]}, ");
// }
// Console.Write("\b\b]");
// Console.Write(" -> ");
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if(array[i] >= 10 && array[i] <= 99) count = count + 1;
//     //if(array[i] <= 99) count = count + 1;
// }
// Console.Write(count);

// int getUserValue(string prompt)
// {
//     Console.Write(prompt);
//     int userValue = Convert.ToInt32(Console.ReadLine());
    
//     return userValue;
// }
// int[] generateArray(int length, int minRandom, int maxRandom)
// {
//     int[] genArray = new int[length];
//     for (int i = 0; i <genArray.Length; i++)
//     {
//         genArray[i] = new Random().Next(minRandom,maxRandom+1);
//     }
//     Console.WriteLine("Сгенерированный массив: [{0}]",string.Join(", ", genArray));
    
//     return genArray;
// }
// int findRange(int[] array, int minRange, int maxRange)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i]>= minRange && array[i]<= maxRange) count = count+1;
//     }
    
//     return count;
// }

// int length = 5;
// int minRandom = getUserValue("Задайте минимум диапазона случайных значений: ");
// int maxRandom = getUserValue("Задайте максимум диапазона случайных значений: ");
// int[] array = generateArray(length,minRandom,maxRandom);

// int minRange =10;
// int maxRange =99;
// int result = findRange(array,minRange,maxRange);
// Console.Write($"Количество значений в диапазоне от {minRange} до {maxRange}: {result}");

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int[] array = new int[11];
// Console.Write("[");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0,10);
//     Console.Write($"{array[i]}, ");
// }
// Console.Write("\b\b]");
// Console.Write(" -> ");
// Console.Write("[");
// for (int i = 0; i < array.Length / 2; i++)
// {
//     int p = array[i] * array[array.Length - 1 - i];
//     Console.Write($"{p}, "); 
// }
// if(array.Length % 2 == 1)
// {
//     Console.Write($"{array[array.Length / 2]}");
// }
// Console.Write("]");

