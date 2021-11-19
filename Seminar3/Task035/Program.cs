

int[] arr = new int[100];
Console.Write("Search necessary number : ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();
int i;
for (i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 100);
    Console.WriteLine(i+ " : " +arr[i] + " ");
}

for (i = 0; i < arr.Length; i++)
{
    if (arr[i] == userNumber)
    {
        Console.WriteLine($"We found your number. It is at position {i}");
        break;
    }
}
if (i == arr.Length)
{
    Console.WriteLine($"We do not found your number");
}