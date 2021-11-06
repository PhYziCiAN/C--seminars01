// заполнить массив 10 случайными числами
int[] a=new int[10];
Random rnd;
rnd=new Random();
for(int i=0;i<10;i++)
{
    a[i]=rnd.Next(0,100);
}
for(int i=0;i<10;i++) //++i лучше
{
    Console.WriteLine(a[i]+" ");
}