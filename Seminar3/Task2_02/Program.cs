// Digits from 1 to 10 via recursion

void Loop(int i)
{
    Console.Write($"{i} ");
    if (i<=10) Loop (i+1);
}
Loop(1);