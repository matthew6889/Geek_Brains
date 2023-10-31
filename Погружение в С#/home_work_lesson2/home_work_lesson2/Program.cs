using System;

namespace seminar2_home_work //Дан двумерный массив.732 496 185 Отсортировать данные в нем по возрастанию. 123 456 789
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 7, 3, 2}, { 4, 9, 6}, { 1, 8, 5} };
            int y = array.GetLength(0);
            int x = array.GetLength(1);
            int[] sort = new int[x * y];
            int counter = 0;
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    sort[counter] = array[i, j];
                    counter++;
                }
            }
            Array.Sort(sort);
            counter = 0;
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    array[i, j] = sort[counter];
                    counter++;
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}