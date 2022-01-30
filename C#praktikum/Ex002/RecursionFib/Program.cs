using System.Diagnostics;

Stopwatch timer = System.Diagnostics.Stopwatch.StartNew();
// stopwatch1.Start();
double Fibonacci(double n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (double i = 1; i < 41; i++)
{
    Console.WriteLine($"{i!} = {Fibonacci(i)}");
}
timer.Stop();
TimeSpan timeTaken = timer.Elapsed;
string foo = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff");
Console.WriteLine(foo);