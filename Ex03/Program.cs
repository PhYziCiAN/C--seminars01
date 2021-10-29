// Cумма четных чисел от 1 до 15
int s=0, i=1;
while (i<=15)
{
    if(i%2==0)
    {
        s=s+i;
    }
    i++;
}
Console.WriteLine("sum:"+ s);