using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Используя стек инвертируйте порядок следования элементов в спиcке
namespace Task1
{
    internal class Task1
    {
        static void Reverse(List<int> input)
        {

            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < input.Count; i++)
            {
                stack.Push(input[i]);
            }

            input.Clear();

            for (int i = 0; i < stack.Count;)
            {
                input.Add(stack.Pop());
            }
        }
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine(string.Join(",", list));
            Reverse(list);
            Console.WriteLine(string.Join(",", list));

        }
    }
}
