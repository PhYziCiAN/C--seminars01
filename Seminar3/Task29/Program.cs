
//int N = 30;
int F = 1;
for (int N = 1; N < 30; N++)
{
    F = 1;
    for(int i = 1; i<=N; i++)
    {
        F = F *i;
    }  
Console.WriteLine("N=" +N+ "F="+F);
}