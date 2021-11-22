int n = 10;
int Fib(int n)
{
    if (n==1 || n==2) return 1;
    else return Fib(n-1)+Fib(n-2);
}
Console.WriteLine($"{Fib(n)}");
