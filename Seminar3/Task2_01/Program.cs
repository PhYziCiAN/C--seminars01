int[,] a = new int[7,5];

void FillArray (int[,]a)
{
    for  (int i=0; i<a.GetLength(0);i++)
    {
        for (int j=0; j<a.GetLength(1); j++)
        {
            a[i,j] = i*10 + j;
        }
    }
}

void Print (int[,]a)
{
    for  (int i=0; i<7;i++)
    {
        for (int j=0; j<5; j++)
        {
            Console.Write ($"{a [i,j],3}");
        }
        Console.WriteLine();
    }
}
FillArray (a);
Print (a);
Console.ReadKey();
Console.WriteLine();
FillArray (a);
Print (a);
