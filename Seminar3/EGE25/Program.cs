

int CountDiv(int n)
{
    List<int> list = new List<int>();
    list.Add(1);
    int k=0;
    for (int i=2; i<n; i++)
    if (n%i == 0) 
        {k++;
        list.Add(i);
    return list;
}

List<int> list;
for(int i=210235; i<=210300; i++)
{
    list = CountDiv(i);
    if(List.Count==4)
    {
        Console.WriteLine(i+ ":");
        for(int j=0; j<list.Count; j++);
    }
}