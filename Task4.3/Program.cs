/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

void FillArray (int [] cool)
{
    int b = cool.Length;
    int i1 = 0;
    while(i1 < b)
    {
        cool[i1] = new Random().Next(1, 10);
        i1++;
    }
}
void PrintArray (int[] col)
{
    int n = col.Length;
    int i = 0;
    while (i < n)
    {
        Console.Write($"{col[i]}, ");
        i++;
    }
}
int[] array = new int [8];
FillArray(array);
PrintArray(array);