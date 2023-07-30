/* Напишите программу, которая на вход принимает число и выдает его квадрат 
(число умноженное на само себя).

Например:
4 -> 16 
-3 -> 9 
-7 -> 49
*/
Console.Write("Напишите число: ");
int number = int.Parse(Console.ReadLine());
int sqr = number * number;

//Вывод построчно
Console.Write("Квадрат числа ");
Console.Write(number);
Console.Write(" равен = ");
Console.Write(sqr);
Console.WriteLine();

//Вывод с использованием $
Console.WriteLine($"Квадрат числа {number} равен = {sqr}");

//Вывод с обращением к переменным
Console.WriteLine("Квадрат числа {0} равен = {1}", number, sqr);

//Вывод с использованием библиотеки Math
int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine("Квадрат числа {0} равен = {1}", number, sqr1);