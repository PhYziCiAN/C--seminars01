// Define number of integers

int CountDigits(int n)
{
    int k =0;
    while (n!=0)
    {
        k++;
        n = n/10;
    }
    return k;
}
Console.WriteLine(CountDigits(1987));


Console.ReadKey();
