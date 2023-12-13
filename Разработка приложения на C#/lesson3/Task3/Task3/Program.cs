//Есть лабиринт описанный в виде двумерного массива где 1 это стены, 0 - проход, 2 - искомая цель.
//Пример лабиринта:
//1 1 1 1 1 1 1
//1 0 0 0 0 0 1
//1 0 1 1 1 0 1
//0 0 0 0 1 0 2
//1 1 0 0 1 1 1
//1 1 1 1 1 1 1
//1 1 1 1 1 1 1
//Напишите алгоритм определяющий наличие выхода из лабиринта и выводящий на экран  координаты точки выхода если таковые имеются.

static void Main (string args[])
{
    Stack<Tuple<int,int>> _path = new Stack<Tuple<int,int>>();

    int[,] labirynth1 = new int[,]
    {
            {1, 1, 1, 1, 1, 1, 1 },
            {1, 0, 0, 0, 0, 0, 1 },
            {1, 0, 1, 1, 1, 0, 1 },
            {0, 0, 0, 0, 1, 0, 2 },
            {1, 1, 0, 0, 1, 1, 1 },
            {1, 1, 1, 1, 1, 1, 1 },
            {1, 1, 1, 1, 1, 1, 1 }
    };

    bool FindPath(int i, int j);
    {
        switch(labirynth1[i,j])
        {
            case 1: return false;
            case 2: return true;
        }

        _path.Push(item: new Tuple<int, int>(i, j));

        while (_path.Count > 0)
        {
           var current:Tuple<int, int> = _path.Pop();
           if(labiri)
        }


    }
}

