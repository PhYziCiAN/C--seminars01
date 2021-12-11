// Factorial as a recursion example

double Factorial (double n)
{
    if (n == 1) return 1;
     return  n * Factorial (n - 1);
}
for (double i = 1; i < 100; i++)
{
    Console.WriteLine ($"{i!} = {Factorial(i)}");
}