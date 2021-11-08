// Maximal from 3 integers

int max (int a, int b, int c)
{
    if (a > b)
    {
    return a;
    }  
    else if(b > c) 
    {
    return b; 
    }
    else 
    {
    return c;
    }
}
Console.WriteLine(max(10,20,30));