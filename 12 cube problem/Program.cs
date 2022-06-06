//длина всех ребер, полная поверхнать, обьем
class Programm
{
    static void Main(string[] args)
    {
        int count = 0;
        int lentgh = 20;
        StreamWriter outputFile = new StreamWriter(@"C:\cue\True.txt");
        Box[] boxes = new Box[lentgh];
        for (int i = 0; i < lentgh; i++)
        {
            boxes[i] = new Box(i + 1);
        }


        foreach (Box box1 in boxes)
        {
            Console.Write(box1.edge.ToString() + " - ребро; " +
                box1.area.ToString() + " - площадь поверхности; " +
                box1.allEdges.ToString() + " - сумма всех ребер; " +
                box1.volume.ToString() + " - обьем;");
            Console.WriteLine();
        }
        List<int> fst = new List<int>();
        List<int> snd = new List<int>();

        Random rand = new Random();

        int a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12;

        int length13 = 13;
    start:
        fst.Clear();
        //11111
        for (int a = 1; a < length13; a++)
        {
            if (fst.ToArray().Sum() < 39)
            {
                a1 = rand.Next(1, 13);
                fst.Add(a1);
            }
            else if (fst.ToArray().Sum() == 39)
            {
                goto startSecondArr;

            }
            else
            {
                goto start;
            }
            //22222
            for (int b = 1; b < length13 - 1; b++)
            {
                if(fst.ToArray().Sum() < 39)
                {
                    while (true)
                    {
                        a2 = rand.Next(1, 13);
                        if (fst.Contains(a2) == true)
                        {
                            continue;
                        }
                        else
                        {
                            fst.Add(a2);
                            break;
                        }
                    }
                }
                else if (fst.ToArray().Sum() == 39)
                {
                    goto startSecondArr;

                }
                else
                {
                    goto start;
                }
                //33333
                for (int c = 1; c < length13 - 2; c++)
                {

                    if (fst.ToArray().Sum() < 39)
                    {
                        while (true)
                        {
                            a3 = rand.Next(1, 13);
                            if (fst.Contains(a3) == true)
                            {
                                continue;
                            }
                            else
                            {
                                fst.Add(a3);
                                break;
                            }
                        }
                    }
                    else if (fst.ToArray().Sum() == 39)
                    {
                        goto startSecondArr;

                    }
                    else
                    {
                        goto start;
                    }
                    //44444
                    for (int d = 1; d < length13 - 3; d++)
                    {

                        if (fst.ToArray().Sum() < 39)
                        {
                            while (true)
                            {
                                a4 = rand.Next(1, 13);
                                if (fst.Contains(a4) == true)
                                {
                                    continue;
                                }
                                else
                                {
                                    fst.Add(a4);
                                    break;
                                }
                            }
                        }
                        else if (fst.ToArray().Sum() == 39)
                        {
                            goto startSecondArr;

                        }
                        else
                        {
                            goto start;
                        }

                        //55555
                        for (int e = 1; e < length13 - 4; e++)
                        {
                            if (fst.ToArray().Sum() < 39)
                            {
                                while (true)
                                {
                                    a5 = rand.Next(1, 13);
                                    if (fst.Contains(a5) == true)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        fst.Add(a5);
                                        break;
                                    }
                                }
                            }
                            else if (fst.ToArray().Sum() == 39)
                            {
                                goto startSecondArr;

                            }
                            else
                            {
                                goto start;
                            }
                            //66666
                            for (int f = 1; f < length13 - 5; f++)
                            {

                                if (fst.ToArray().Sum() < 39)
                                {
                                    while (true)
                                    {
                                        a6 = rand.Next(1, 13);
                                        if (fst.Contains(a6) == true)
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            fst.Add(a6);
                                            break;
                                        }
                                    }
                                }
                                else if (fst.ToArray().Sum() == 39)
                                {
                                    goto startSecondArr;

                                }
                                else
                                {
                                    goto start;
                                }

                                //77777
                                for (int g = 1; g < length13 - 6; g++)
                                {
                                    if (fst.ToArray().Sum() < 39)
                                    {
                                        while (true)
                                        {
                                            a7 = rand.Next(1, 13);
                                            if (fst.Contains(a7) == true)
                                            {
                                                continue;
                                            }
                                            else
                                            {
                                                fst.Add(a7);
                                                break;
                                            }
                                        }
                                    }
                                    else if (fst.ToArray().Sum() == 39)
                                    {
                                        goto startSecondArr;

                                    }
                                    else
                                    {
                                        goto start;
                                    }
                                    //88888
                                    for (int h = 1; h < length13 - 7; h++)
                                    {
                                        if (fst.ToArray().Sum() < 39)
                                        {
                                            while (true)
                                            {
                                                a8 = rand.Next(1, 13);
                                                if (fst.Contains(a8) == true)
                                                {
                                                    continue;
                                                }
                                                else
                                                {
                                                    fst.Add(a8);
                                                    break;
                                                }
                                            }
                                        }
                                        else if (fst.ToArray().Sum() == 39)
                                        {
                                            goto startSecondArr;

                                        }
                                        else
                                        {
                                            goto start;
                                        }
                                        //99999
                                        for (int i = 1; i < length13 - 8; i++)
                                        {
                                            if (fst.ToArray().Sum() < 39)
                                            {
                                                while (true)
                                                {
                                                    a9 = rand.Next(1, 13);
                                                    if (fst.Contains(a9) == true)
                                                    {
                                                        continue;
                                                    }
                                                    else
                                                    {
                                                        fst.Add(a9);
                                                        break;
                                                    }
                                                }
                                            }
                                            else if (fst.ToArray().Sum() == 39)
                                            {
                                                goto startSecondArr;

                                            }
                                            else
                                            {
                                                goto start;
                                            }
                                            //1010101010
                                            for (int j = 1; j < length13 - 9; j++)
                                            {
                                                if (fst.ToArray().Sum() < 39)
                                                {
                                                    while (true)
                                                    {
                                                        a10 = rand.Next(1, 13);
                                                        if (fst.Contains(a10) == true)
                                                        {
                                                            continue;
                                                        }
                                                        else
                                                        {
                                                            fst.Add(a10);
                                                            break;
                                                        }
                                                    }
                                                }
                                                else if (fst.ToArray().Sum() == 39)
                                                {
                                                    goto startSecondArr;

                                                }
                                                else
                                                {
                                                    goto start;
                                                }
                                                //1111111111
                                                for (int k = 1; k < length13 - 10; k++)
                                                {
                                                    if (fst.ToArray().Sum() < 39)
                                                    {
                                                        while (true)
                                                        {
                                                            a11 = rand.Next(1, 13);
                                                            if (fst.Contains(a11) == true)
                                                            {
                                                                continue;
                                                            }
                                                            else
                                                            {
                                                                fst.Add(a11);
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    else if (fst.ToArray().Sum() == 39)
                                                    {
                                                        goto startSecondArr;

                                                    }
                                                    else
                                                    {
                                                        goto start;
                                                    }
                                                    //1212121212
                                                    for (int l = 1; l < length13 - 11; l++)
                                                    {
                                                        if (fst.ToArray().Sum() < 39)
                                                        {
                                                            while (true)
                                                            {
                                                                a12 = rand.Next(1, 13);
                                                                if (fst.Contains(a12) == true)
                                                                {
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    fst.Add(a12);
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                        else if (fst.ToArray().Sum() == 39)
                                                        {
                                                            goto startSecondArr;

                                                        }
                                                        else
                                                        {
                                                            goto start;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

    startSecondArr:

        int q = fst.Count;
        for (int i = 1; i < 13; i++)
        {
            if(fst.Contains(i) == true)
            {
                continue;
            }
            else
            {
                snd.Add(i);
            }
        }


        Console.WriteLine("Первая группа:");
        foreach (int f in fst)
        {
            Console.Write(f.ToString() + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Вторая группа:");
        foreach (int f in snd)
        {
            Console.Write(f.ToString() + " ");
        }
        Console.WriteLine();


        List<Box> boxes1 = new List<Box>();
        foreach(int f in fst)
        {
            Box box = new Box(f);
            boxes1.Add(box);
        }
        Group group1 = new Group(boxes1);


        List<Box> boxes2 = new List<Box>();
        foreach (int f in snd)
        {
            Box box = new Box(f);
            boxes2.Add(box);
        }
        Group group2 = new Group(boxes2);

        bool isTrue = EqualsGroups(group1, group2);
        if (isTrue == false)
        {
            Console.WriteLine(isTrue.ToString());
            Console.WriteLine(count + " - комбинаций проверено");
            Console.WriteLine();
            fst.Clear();
            snd.Clear();
            boxes1.Clear();
            boxes2.Clear();
            group1 = null;
            group2 = null;
            count++;
            goto start;

        }
        else
        {
            Console.WriteLine("БАЛДЕЕЕТЬ");

            outputFile.WriteLine("First group:");
            foreach (int f in fst)
            {
                outputFile.Write(f.ToString() + " ");
            }
            outputFile.WriteLine();

            outputFile.WriteLine("Second group:");
            foreach (int f in snd)
            {
                outputFile.Write(f.ToString() + " ");
            }
            outputFile.WriteLine();
            Console.WriteLine(count + " - combination");
        }
        outputFile.Close();


    }
    public static bool EqualsGroups(Group boxes1, Group boxes2)
    {
        //Console.WriteLine("1 группа     2 группа");
        //Console.WriteLine(boxes1.sumEdge.ToString() + " " + boxes2.sumEdge.ToString());
        //Console.WriteLine(boxes1.sumArea.ToString() + " " + boxes2.sumArea.ToString());
        //Console.WriteLine(boxes1.sumAllEges.ToString() + " " + boxes2.sumAllEges.ToString());
        //Console.WriteLine(boxes1.sumVolume.ToString() + " " + boxes2.sumVolume.ToString());

        if (boxes1.sumEdge == boxes2.sumEdge &&
            boxes1.sumArea == boxes2.sumArea &&
            boxes1.sumAllEges == boxes2.sumAllEges &&
            boxes1.sumVolume == boxes2.sumVolume)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

class Box
{
    public int edge;
    public int area;
    public int allEdges;
    public int volume;
    public Box(int edge)
    {
        this.edge = edge;
        this.area = edge * edge * 6;
        this.allEdges = edge * 12;
        this.volume = edge * edge * edge;

        //public bool 
    }
}
class Group
{
    public List<Box> boxes;
    public int sumEdge;
    public int sumArea;
    public int sumVolume;
    public int sumAllEges;

    public Group(List<Box> boxes)
    {
        this.boxes = boxes;
        foreach (Box box in boxes)
        {
            this.sumEdge += box.edge;
            this.sumArea += box.area;
            this.sumVolume += box.volume;
            this.sumAllEges += box.allEdges;
        }
    }
}