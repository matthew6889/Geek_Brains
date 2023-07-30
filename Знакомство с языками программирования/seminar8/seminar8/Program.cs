//Задача 53: Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.

// int[,] GenerateArray(int m, int n)
// {
//     int[,] randomArray = new int[m, n];
//     for (int i = 0; i < randomArray.GetLength(0); i++)
//     {
//         Console.WriteLine();
//         for (int j = 0; j < randomArray.GetLength(1); j++)
//         {
//             randomArray[i, j] = new Random().Next(0, 9 + 1);
//             Console.Write($"{randomArray[i, j],4}");
//         }
//     }
//     Console.WriteLine();
//     return randomArray;
// }
// void ChangeRows(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.WriteLine();
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[0, j];
//             array[0, j] = array[array.GetLength(0) - 1, j];
//             array[array.GetLength(0) - 1, j] = temp;

//             Console.Write($"{array[i, j],4}");
//         }
//     }
// }
// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = GenerateArray(rows, columns);
// ChangeRows(array);


//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно,
//программа должна вывести сообщение для пользователя.

// int EnterValueInt(string text)
// {
//     Console.Write(text);
//     int value = Convert.ToInt32(Console.ReadLine());
//     return value;
// }

// int[,] GenerateDoubleArray(int row, int column, int startLimit, int endLimit)
// {
//     int[,] array = new int[row, column];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(startLimit, endLimit + 1);
//         }
//     }
//     return array;
// }

// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j],4}");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] ReverseArray(int[,] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[i, j];
//             array[i, j] = array[j, i];
//             array[j, i] = temp;
//         }
//         count++;
//     }
//     return array;
// }

// int row = EnterValueInt("Введите кол-во строк: ");
// int column = EnterValueInt("Введите кол-во столбцов: ");
// int startGen = EnterValueInt("Начало генерации: ");
// int endGen = EnterValueInt("Конец генерации: ");

// int[,] array = GenerateDoubleArray(row, column, startGen, endGen);

// ShowArray(array);

// if (row == column)
// {
//     int[,] newArray = ReverseArray(array);
//     Console.WriteLine();
//     ShowArray(newArray);
// }
// else
// {
//     Console.WriteLine("Перевернуть массив нельзя");
// }

//Задача 57
// int EnterValueInt(string text)
// {
//     Console.Write(text);
//     int value = Convert.ToInt32(Console.ReadLine());
//     return value;
// }

// int[,] GenerateDoubleArray(int row, int column, int startLimit, int endLimit)
// {
//     int[,] array = new int[row, column];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(startLimit, endLimit + 1);
//         }
//     }
//     return array;
// }

// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j],4}");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] FillLimitNumbers(int startLimit, int endLimit)
// {
//     int rowsCounter = endLimit - startLimit;
//     int [,] newArray = new int [2, rowsCounter + 1];
//     int counter = startLimit;
//     for (int j = 0; j < newArray.GetLength(1); j++)
//     {
//         newArray[0,j] = counter;
//         counter++;
//     }
//     return newArray;
// }

// int[,] NumberCounter (int [,] limitArray, int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < limitArray.GetLength(1); k++)
//             {
//                 if(array[i,j] == limitArray[0, k]) limitArray[1, k] ++;
//             }
//         }
//     }
//     return limitArray;
// }

// void ShowResult (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         if(array[1, i] != 0) Console.WriteLine($"Число {array[0, i]} Встречается {array[1, i]} раз");
//     }
// }

// int row = EnterValueInt("Введите кол-во строк: ");
// int column = EnterValueInt("Введите кол-во столбцов: ");
// int startGen = EnterValueInt("Начало генерации: ");
// int endGen = EnterValueInt("Конец генерации: ");

// int[,] array = GenerateDoubleArray(row, column, startGen, endGen);

// int [,] countArray = FillLimitNumbers(startGen, endGen);

// ShowArray(array);

// Console.WriteLine();

// ShowArray(countArray);

// Console.WriteLine();

// int [,] tempArray = NumberCounter(countArray, array);

// Console.WriteLine();

// ShowArray(tempArray);

// Console.WriteLine();

// ShowResult(tempArray);


//Задача 59 задайте двумерный массив из целых чисел. напишите программу. которая удалить сроку и столбец на пересечениее которых рассположен наименьший элемент массива.

int[,] GenerateArray(int m, int n)
{
    int[,] randomArray = new int[m, n];
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i, j] = new Random().Next(0, 9 + 1);
            Console.Write($"{randomArray[i, j],4}");
        }
    }
    Console.WriteLine();
    return randomArray;
}

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GenerateArray(rows, columns);
int[] MinArray(int[,] newArray)
{
    int minArray = newArray[0, 0];
    int [] minIndex = new int [2];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            if(newArray[i, j] < minArray)
            {
                minArray = newArray[i, j];
                minIndex[0] = i;
                minIndex[1] = j;
            }
        }
    }
    return minIndex;
}

int[] resultArray = MinArray(array);
Console.WriteLine();
Console.WriteLine($"{resultArray[0],4},{resultArray[1]}");
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if(i != resultArray[0] && j != resultArray[1])
        {
            Console.Write($"{array[i,j],4}");
        }
    }
    if(i != resultArray[0]) Console.WriteLine();
}