
int[] z = new int [8];
Random rand = new Random();
for(int i = 0; i < 8; ++i)
{
    z[i] = rand.Next(1,27);
    Console.WriteLine("  " + z[i]);
}
