// Удалить вторую цифру 3-значного числа

int a = 258;

int b = a % 100 / 10;
int c = a / 100;
int d = a % 10;

Console.WriteLine(a +"\n"+ c +""+ b);
Console.WriteLine(c);
Console.WriteLine(b);
Console.WriteLine(d);
