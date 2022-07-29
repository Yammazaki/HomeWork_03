// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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

int LookingFor ( int[] ab)
{
    int result = 0;
    int size = ab.Length;
    int min = ab[0];
    int max = ab[0];
    for( int j = 0; j < size; j++)
    {
        if(min > ab[j]) min = ab[j];
        if(max < ab[j]) max = ab[j];
        result = max - min;
    }
    return result;
}


PrintArray(array);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна {LookingFor(array)}");