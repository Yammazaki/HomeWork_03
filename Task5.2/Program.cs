// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива: ");
int[] array = new  int [int.Parse(Console.ReadLine())];
Console.WriteLine();

void PrintArray(int[] arr )
{   
    int length = arr.Length;
    for( int i  = 0; i < length; i++)
    {
        arr[i] = new Random().Next(10,100);
        Console.WriteLine(arr[i]);
    }
}
int Result ( int[] arr)
{
    int size = arr.Length;
    int sum = 0;
    for( int j = 1; j < size; j = j + 2)
    {
        Console.Write($"{arr[j]} " );
        sum = sum + arr[j];
    }
    return sum;
}

PrintArray(array);
Console.WriteLine();
Console.WriteLine(Result(array));