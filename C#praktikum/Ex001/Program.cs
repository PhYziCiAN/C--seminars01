/* Задача
Сформировать случайным образом
целочисленный массив А из натуральных двузначных чисел.
Создать на его основе массив В, отбрасывая те, которые
нарушают порядок возрастания
больше среднего арифметического элементов А
четные
*/

// int val = array[2] - забираем значение из индекса 2 массива в переменную val
// int val = array[index];Console.WriteLine(val) вывод идексированных значений
// int GetRandom(int minValue, int maxValue)
// {
//     return new Random().Next(minValue, 100);
// }
// int[] arr = new int[10]{1,2,3,4,5,1,1,3,4}; // либо в {} конкретные числа (можно не указывать []), или размер массива в таких скобках []
// int length = arr.length;
// int index = 0; 
// int k = GetNumber(); //force user to input from keyboard
// int count = RepeatK(k, arr);

//  while(index<10)
// {
//      arr[index] = GetRandom().Next(10,100); // [10-99]
//      index++;
// }

// index=0;

// while(index<10)
// {
//     Console.WriteLine(A[index]);
//     index++;
// }

// int RepeatK(int k, int[] array)
// {

// }


//int GetNumber() => Console.ReadLine();


int[] a = new int[10]; //array with 10 random numbers 10-99
Random rnd=new Random();
//rnd=new Random();
//int i;
for(int i=0;i<10;i++)
{
    a[i] = rnd.Next(10,100);
}
for(int i = 0;i < 10; i++) //++i лучше
{
    Console.WriteLine(a[i]+" ");
}
///excluding number interrupted increasing order
Console.WriteLine();
//int i = 1;
int fe = a[0];
Console.WriteLine(fe);
// while (int j=1; j <= 9)
// {
//     if (a[i] > fe)
//     {
//         Console.WriteLine (a[i]);
//         fe = a[i];
//     }
//     j++;
// }