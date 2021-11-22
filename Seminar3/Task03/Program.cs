﻿
// int[] a = {Monday, Tuesday, Wednesday, Thursday, Saturday, Sunday}; //описание массива
// //a=new int[10]; //создание массива
// //int i = 7;
// Console.WriteLine(a[i]+" ");

// for(int j=0;j<7;++j)
// {
//     string s = Console.ReadLine();
//     a[j]=Convert.ToInt32(s);
// }
// for(i=0;i<10;++i)
// {
//     Console.WriteLine(a[i]+" ");
// }
﻿//int a;
Console.WriteLine("Input weeks day number: ");
string? s = Console.ReadLine();

if(s=="0") Console.WriteLine("No such day");
if(s=="1") Console.WriteLine("Monday");
if(s=="2") Console.WriteLine("Tuesday");
if(s=="3") Console.WriteLine("Wednesday");
if(s=="4") Console.WriteLine("Thursday");
if(s=="5") Console.WriteLine("Friday");
if(s=="6") Console.WriteLine("Saturday");
if(s=="7") Console.WriteLine("Sunday");

// switch(s)
// {
//     case "1":
//     Console.WriteLine("Monday");
//     break;
//     case "2":
//     Console.WriteLine("Tuesday");
//     break;
//     default:
//     Console.WriteLine("Error");
//     break;
// }

// string s = Console.ReadLine();
// string[] days = new string[8];
// days[0] = "Monday"
// int day = Convert.ToInt32(s);
// Console.WriteLine (days[day-1]);
