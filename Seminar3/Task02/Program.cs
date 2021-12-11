//output maximal and mininmal of 2 integers
// int a = 3;
// int b = 6;
// if ( a > b)
// {
//     Console.WriteLine("Max is: "+a);
//     Console.WriteLine("Min is: "+b);
// }
// else
// {
//     Console.WriteLine("Max is: "+b);
//     Console.WriteLine("Min is: "+a);
// }

int PrintMax(int a, int b)
{
    
    if (a > b) return a;
    else return b;
        
}
int PrintMin(int a, int b)
{
    
    if (a < b) return a;
    else return b;
        
}

Console.WriteLine($"Max is: {PrintMax (5,6)} \nMin is: {PrintMin(5,6)}");

// int n = PrintMax(6,5);
// Console.WriteLine("Max is:" +n);