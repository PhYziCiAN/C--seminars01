// Factorial as a recursion example
using System.Diagnostics;
Stopwatch timer = Stopwatch.StartNew();

double Factorial (double n)
{
    if (n == 1) return 1;
     return  n * Factorial (n - 1);
}
for (double i = 1; i < 100; i++)
{
    Console.WriteLine ($"{i!} = {Factorial(i)}");
}
timer.Stop();
TimeSpan timeTaken = timer.Elapsed;
Console.WriteLine(timeTaken); //h:m:s.fffffff

string foo = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff");
Console.WriteLine(foo);