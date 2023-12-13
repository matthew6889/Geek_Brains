using System;

Stack<Tuple<int, int>> _path = new Stack<Tuple<int, int>>();

int[,] labirynth1 = new int[,]
{
{1, 1, 1, 1, 1, 1, 1 },
{1, 1, 0, 0, 0, 0, 1 },
{1, 1, 1, 1, 1, 0, 1 },
{2, 0, 0, 0, 1, 0, 2 },
{1, 1, 0, 2, 1, 1, 1 },
{1, 1, 1, 1, 1, 1, 1 },
{1, 1, 1, 2, 1, 1, 1 }
};
Console.WriteLine($"Количество выходов: {FindPath(1, 2)}");
Console.WriteLine($"Количество выходов: {FindPath(3, 2)}");
Console.WriteLine($"Количество выходов: {FindPath(1, 1)}");

int FindPath(int i, int j)
{

    if (labirynth1[i, j] == 0) _path.Push(new(i, j));
    
    int exit = 0;

    while (_path.Count > 0)
    {
        var current = _path.Pop();

        if (labirynth1[current.Item1, current.Item2] == 2)
        {
            exit++;
        }

        labirynth1[current.Item1, current.Item2] = 1;

        if (current.Item1 + 1 < labirynth1.GetLength(0)
           && labirynth1[current.Item1 + 1, current.Item2] != 1)
            _path.Push(new(current.Item1 + 1, current.Item2));

        if (current.Item2 + 1 < labirynth1.GetLength(1) &&
           labirynth1[current.Item1, current.Item2 + 1] != 1)
            _path.Push(new(current.Item1, current.Item2 + 1));

        if (current.Item1 > 0 && labirynth1[current.Item1 - 1, current.Item2] != 1)
            _path.Push(new(current.Item1 - 1, current.Item2));

        if (current.Item2 > 0 && labirynth1[current.Item1, current.Item2 - 1] != 1)
            _path.Push(new(current.Item1, current.Item2 - 1));
    }

    return exit;
}