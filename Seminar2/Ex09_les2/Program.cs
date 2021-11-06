int[] CreateArray(int n)
{
    int[] a=new int[n];
    Random rnd=new Random();
    for(int i=0;i<a.Length;i++) a[i]=rnd.Next(0,101);
    return a;
}
void PrintArray(int[] a)
{
    for(int i=0;i<a.Length;i++) Console.Write(a[i]+" ");
}
int[] arr=CreateArray(5);
PrintArray(arr);

int p=1;
for(int i=0;i<arr.Length;i++)
if (arr[i]%2==0 && arr[i]%10!=0){
    p=p*arr[i];
}
Console.WriteLine();
Console.WriteLine(p);
