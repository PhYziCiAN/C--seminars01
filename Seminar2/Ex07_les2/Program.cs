// Zero array


int[] a; //описание массива
a=new int[10]; //создание массива
int i = 0;

//Первый способ
i=0;
while(i<9)
{
    a[i]=0;
    i++;
Console.WriteLine(a[i]);
}

//Второй способ
// for(int j=0; j<10; ++j)
// {
//     a[j]=0;
// }
// for(i=0; i<10; ++i)
// {
//     a[i]=0;
// }
// Console.WriteLine(a[i]);

// Ввод массива с клавиатуры
for(int j=0;j<10;++j)
{
    string s = Console.ReadLine();
    a[j]=Convert.ToInt32(s);
}
for(i=0;i<10;++i)
{
    Console.WriteLine(a[i]+" ");
}