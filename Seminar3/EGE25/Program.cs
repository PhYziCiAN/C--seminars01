

// int CountDiv(int n)
// {
//     List<int> list = new List<int>();
//     list.Add(1);
//     int k=0;
//     for (int i=2; i<n; i++)
//         if (n%i == 0) 
//         {
//             k++;
//             list.Add(i);
//         }
//             return list;
// }
// List<int> list;
// for(int i=210235; i<=210300; i++)
//     {
//         list = CountDiv (i);
//         if (list.Count != 4)
//         {
//             continue;
//         }
//         for (int j = 0; j < list.Count; j++) ;
//         Console.WriteLine(i + ":");
//     }

// Console.WriteLine(CountDiv(5));

int[] CreateIntArray(int minValue, int maxValue)
{
    int[] tempArr = new int[maxValue-minValue+1];
    for (int i = 0; i < tempArr.Length; i++) tempArr[i] = minValue++;
    return tempArr;
}

int[] TakeRatioFor(int compareNumber)
{
    int count = 1;
    int[] plusArr = new int[count];
    int num = 2;
    for(int i = 0; i < compareNumber; i++, num++)
    {
        if (compareNumber%(num) == 0) {Array.Resize(ref plusArr, count); plusArr[count-1] = num; count++;}
    }
    return plusArr;
}

void PrintArray(int[] inputArr)
{
    foreach (int input in inputArr) Console.Write($"{input} "); Console.WriteLine();
}
int[] newArr  = CreateIntArray(210235,210300);
// int[] newArr = CreateIntArray(10,16);
foreach (int numbArr in newArr) 
{
    int[] x = TakeRatioFor(numbArr);
    if (x.Length == 5) PrintArray(x);
}
