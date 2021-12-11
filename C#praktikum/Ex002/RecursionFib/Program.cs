using System.Diagnostics;
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
double Fibonacci(double n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (double i = 1; i < 41; i++)
{
    Console.WriteLine($"{i!} = {Fibonacci(i)}");
}
stopwatch.Stop();
TimeSpan timeTaken = stopwatch.Elapsed;
string foo = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff");
Console.WriteLine(foo);