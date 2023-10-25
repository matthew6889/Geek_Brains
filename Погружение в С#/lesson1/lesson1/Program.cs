using System;

namespace seminar1
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            int min = Convert.ToInt32(args[0]);
            int max = Convert.ToInt32(args[0]);
            for (int i = 0; i < args.Length; i++)
            {
                int M = Convert.ToInt32(args[i]);
                if (M < min)
                {
                    min = M;
                }
                if (M > max)
                {
                    max = M;
                }

            }
            Console.WriteLine($"[максимум -> {max} минимум -> {min}");
        }
    }
}