// See https://aka.ms/new-console-template for more information
int a = 5;
int b = 8;
int c = 7;
if (a > b && a > c)
{
    Console.WriteLine ("Maximal is: "+ a);
}
else if (b > c)
{
    Console.WriteLine ("Maximal is: "+ b);
}
else
{
    Console.WriteLine("Maximal is: "+ c);
}