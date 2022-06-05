//длина всех ребер, полная поверхнать, обьем
class Programm
{
    static void Main(string[] args)
    {
        int lentgh = 20;
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

            foreach (Box box2 in boxes)
            {


            }
        }
        int length13 = 13;
        for (int a = 0; a < length13; a++)
        {
            for (int b = 0; b < length13 - 1; b++)
            {
                for (int c = 0; c < length13 - 2; c++)
                {
                    for (int d = 0; d < length13 - 3; d++)
                    {
                        for (int e = 0; e < length13 - 4; e++)
                        {
                            for (int f = 0; f < length13 - 5; f++)
                            {
                                for (int g = 0; g < length13 - 6; g++)
                                {
                                    for (int h = 0; h < length13 - 7; h++)
                                    {
                                        for (int i = 0; i < length13 - 8; i++)
                                        {
                                            for (int j = 0; j < length13 - 9; j++)
                                            {
                                                for (int k = 0; k < length13 - 10; k++)
                                                {
                                                    for (int l = 0; l < length13 - 11; l++)
                                                    {
                                                        for (int m = 0; m < length13 - 12; m++)
                                                        {

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

        List<Box> boxes1 = new List<Box>();
        List<Box> boxes2 = new List<Box>();
        Group group1 = new Group(boxes1);
        Group group2 = new Group(boxes2);

    }
    public bool EqualsGroups(Group boxes1, Group boxes2)
    {
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