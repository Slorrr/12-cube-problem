class Programm
{
    static void Main(string[] args)
    {
        int count = 0;
        int lentgh = 20;
        //Variable for writing the result to a file
        StreamWriter outputFile = new StreamWriter(@"C:\cue\True.txt");

        //Output characteristics
        Cube[] cubes = new Cube[lentgh];
        for (int i = 0; i < lentgh; i++)
        {
            cubes[i] = new Cube(i + 1);
        }

        foreach (Cube cube1 in cubes)
        {
            Console.Write(cube1.edge.ToString() + " - edge; " +
                cube1.area.ToString() + " - area; " +
                cube1.allEdges.ToString() + " - allEdges; " +
                cube1.volume.ToString() + " - volume;");
            Console.WriteLine();
        }


        List<int> fst = new List<int>(); //Array for entering elements of the first group
        List<int> snd = new List<int>(); //Array for entering elements of the second group

        Random rand = new Random(); //Variable to create a random number

        int a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12; //Variables for entering random numbers

        int length13 = 13;

        start:
        fst.Clear(); //Clearing the first array

        for (int a = 1; a < length13; a++)
        {
            if (fst.ToArray().Sum() < 39) //If the sum of first array is less than 39 create a new number and add to array
            {
                a1 = rand.Next(1, 13);
                fst.Add(a1);
            }
            else if (fst.ToArray().Sum() == 39) //If the sum of the array is 39 go to the creation of the second group
            {
                goto startSecondArr;

            }
            else //If the sum of the array is greater than 39, return to the creation of the first array
            {
                goto start;
            }
            for (int b = 1; b < length13 - 1; b++) //This and subsequent loops are identical
            {
                if(fst.ToArray().Sum() < 39) //If the sum of first array is less than 39 create a new number and add to array
                {
                    while (true)
                    {
                        a2 = rand.Next(1, 13);
                        if (fst.Contains(a2) == true) //If the created number is already in the array
                        {
                            continue;
                        }
                        else //If the created number is not in the array, add it
                        {
                            fst.Add(a2); 
                            break;
                        }
                    }
                }
                else if (fst.ToArray().Sum() == 39)  //If the sum of the array is 39 go to the creation of the second group
                {
                    goto startSecondArr;

                }
                else //If the sum of the array is greater than 39, return to the creation of the first array
                {
                    goto start;
                }
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

        //The second array consists of numbers from 1 to 12 which were not in the first array
        for (int i = 1; i < 13; i++) //Creating a second array
        {
            if(fst.Contains(i) == true) //If the number is already in the first array
            {
                continue;
            }
            else //If the number is not in the first array
            {
                snd.Add(i);
            }
        }

        //Displaying group values
        Console.WriteLine("First group:");
        foreach (int f in fst)
        {
            Console.Write(f.ToString() + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Second group:");
        foreach (int f in snd)
        {
            Console.Write(f.ToString() + " ");
        }
        Console.WriteLine();


        
        //Creating an array of cubes and creating groups
        List<Cube> cubes1 = new List<Cube>();
        foreach(int f in fst)
        {
            Cube cube = new Cube(f);
            cubes1.Add(cube);
        }
        GroupOfCubes group1 = new GroupOfCubes(cubes1);


        List<Cube> cubes2 = new List<Cube>();
        foreach (int f in snd)
        {
            Cube cube = new Cube(f);
            cubes2.Add(cube);
        }
        GroupOfCubes group2 = new GroupOfCubes(cubes2);

      
        bool isTrue = EqualsGroups(group1, group2); //Compare group values
        if (isTrue == false) //If the group values are equal
        {
            Console.WriteLine(isTrue.ToString());
            Console.WriteLine(count + " - combinations tested");
            Console.WriteLine();

            //Clearing all variables
            fst.Clear();
            snd.Clear();
            cubes1.Clear();
            cubes2.Clear();
            group1 = null;
            group2 = null;

            count++;

            goto start;

        }
        else //If the groups are equal
        {
            //Console output
            Console.WriteLine("Groups are equal");

            Console.WriteLine("////////////////////");
            Console.WriteLine("First group:");
            foreach (int f in fst)
            {
                Console.Write(f.ToString() + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Second group:");
            foreach (int f in snd)
            {
                Console.Write(f.ToString() + " ");
            }
            Console.WriteLine();
            Console.WriteLine("////////////////////");
            Console.WriteLine();

            //Write to file
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

    //Group Comparison Method
    public static bool EqualsGroups(GroupOfCubes cubes1, GroupOfCubes cubes2)
    {
        //Console.WriteLine("1 группа     2 группа");
        //Console.WriteLine(boxes1.sumEdge.ToString() + " " + boxes2.sumEdge.ToString());
        //Console.WriteLine(boxes1.sumArea.ToString() + " " + boxes2.sumArea.ToString());
        //Console.WriteLine(boxes1.sumAllEges.ToString() + " " + boxes2.sumAllEges.ToString());
        //Console.WriteLine(boxes1.sumVolume.ToString() + " " + boxes2.sumVolume.ToString());

        //Compare all values
        if (cubes1.sumEdge == cubes2.sumEdge &&
            cubes1.sumArea == cubes2.sumArea &&
            cubes1.sumAllEges == cubes2.sumAllEges) //&&
            //The sum of volumes is not taken into account in the comparison
            //cubes1.sumVolume == cubes2.sumVolume)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

//Cube class
class Cube
{
    public int edge;
    public int area;
    public int allEdges;
    public int volume;
    public Cube(int edge)
    {
        this.edge = edge;
        this.area = edge * edge * 6;
        this.allEdges = edge * 12;
        this.volume = edge * edge * edge;
    }
}

//Group of cubes class
class GroupOfCubes
{
    public List<Cube> Cubes;
    public int sumEdge;
    public int sumArea;
    public int sumVolume;
    public int sumAllEges;

    public GroupOfCubes(List<Cube> Cubes)
    {
        this.Cubes = Cubes;
        foreach (Cube cube in Cubes)
        {
            this.sumEdge += cube.edge;
            this.sumArea += cube.area;
            this.sumVolume += cube.volume;
            this.sumAllEges += cube.allEdges;
        }
    }
}