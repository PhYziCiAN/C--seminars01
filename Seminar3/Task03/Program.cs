//int a;
Console.WriteLine("Input weeks day number: ");
string s = Console.ReadLine();

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