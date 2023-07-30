// Console.Write("введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write($"[");
// for (int i = 0; i <= num; i++)
// {
//     Console.Write($"{i}, ");
// }
// Console.Write("\b\b] ");

// Console.Write("введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// switch(num)
// {
//     case 1:
//     {
//         Console.Write("один ");
//         break;
//     }
//     case 2:
//     {
//         Console.Write("два ");
//         break;
//     }
//     case 3:
//     {
//         Console.Write("три ");
//         break;
//     }
//     default:
//     {
//         Console.WriteLine("такого числа нет");
//         break;
//     }
// }

// Console.Write("введите число: ");
// string num = Console.ReadLine();
// switch(num)
// {
//     case "один":
//     {
//         Console.Write("1");
//         break;
//     }
//     case "два":
//     {
//         Console.Write("2");
//         break;
//     }
//     case "три":
//     {
//         Console.Write("3");
//         break;
//     }
//     default:
//     {
//         Console.WriteLine("такого числа нет");
//         break;
//     }
// }

// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка
// Console.Write("введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите число: ");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x != 0 && y != 0)
// {
//     if (x > 0 && y > 0)
//     {
//         Console.WriteLine("1");
//     }
//     else if (x < 0 && y > 0)
//     {
//         Console.WriteLine("2");
//     }
//     else if (x < 0 && y < 0)
//     {
//         Console.WriteLine("3");
//     }
//     else
//     {
//         Console.WriteLine("4");
//     }
// }
// else
// {
//     Console.WriteLine("ВВод х = 0 и у = 0");
// }

//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
// Console.Write("введите номер четверти: ");
// int x = Convert.ToInt32(Console.ReadLine());
// if (x < 5 && x > 0)
// {
//     if (x == 1)
//     {
//         Console.WriteLine("x > 0 && y > 0");
//     }
//     else if (x == 2)
//     {
//         Console.WriteLine("x < 0 && y > 0");
//     }
//     else if (x == 3)
//     {
//         Console.WriteLine("x < 0 && y < 0");
//     }
//     else
//     {
//         Console.WriteLine("x > 0 && y < 0");
//     }
// }
// else
// {
//     Console.WriteLine("Введите корректный номер четверти");
// }


// Console.Write("Веедите номер четверти: ");
// int quarter = Convert.ToInt32(Console.ReadLine());
// switch (quarter)
// {
//     case 1:
//         {
//             Console.WriteLine("X > 0 && Y > 0");
//             break;
//         }
//     case 2:
//         {
//             Console.WriteLine("X < 0 && Y > 0");
//             break;
//         }
//     case 3:
//         {
//             Console.WriteLine("X < 0 && Y < 0");
//             break;
//         }

//     case 4:
//         {
//             Console.WriteLine("X > 0 && Y < 0");
//             break;
//         }

//     default:
//         {
//             Console.WriteLine("Введите число от 1 до 4х");
//             break;
//         }
// }

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// int enterValue (string prompt)
// {
//     Console.Write($"Введите координату точки {prompt}");
//     int value = Convert.ToInt32(Console.ReadLine());

//     return value;
// }

// int xa = enterValue("a по оси x: ");
// int ya = enterValue("a по оси y: ");
// Console.WriteLine();
// int xb = enterValue("b по оси x: ");
// int yb = enterValue("b по оси y: ");
// Console.WriteLine();

// double distance = Math.Sqrt(Math.Pow((xa - xb),2) + Math.Pow((ya - yb),2));
// Console.Write($"Расстояние между точками равно:{Math.Round(distance,2)}");

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1,4

// Console.Write("напишите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int q = 0;
// Console.Write($"{n} -> ");
// for (int i = 1; i <= n; i++)
// {
//     q = i * i;
//     Console.Write($"{q}, ");
// }
// Console.Write("\b\b ");

