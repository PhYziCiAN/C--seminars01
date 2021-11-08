
int[] z = new int [12];
Random rand = new Random();
for(int i = 0; i < 12; ++i)
{
    z[i] = rand.Next(0,9);
    Console.WriteLine("  " + z[i]);
}
