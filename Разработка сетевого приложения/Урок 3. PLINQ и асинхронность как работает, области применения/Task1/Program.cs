namespace Task1
/*Напише приложение для одновременного выполнения двух задач в потоках созданных с помощью Task.
 *Нужно подсчитать сумму элементов каждого из массивов а потом сложить эти суммы полученные после выполнения каждого из потоков и вывести результат на экран.*/
{
    internal class Program
    {
        static int[] arr1 = Enumerable.Range(0, 100000).Select(x => Random.Shared.Next(0, 10)).ToArray();
        static int[] arr2 = Enumerable.Range(0, 100000).Select(x => Random.Shared.Next(0, 10)).ToArray();

        static async Task<int> Summ(int[] arr)
        {
            await Task.CompletedTask;

            int sum = 0;
            
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;

        }

        static async Task Main(string[] args)
        {
            var s1 = await Summ(arr1);
            var s2 = await Summ(arr2);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine($"summ = {s1+s2}");
        }
    }
}