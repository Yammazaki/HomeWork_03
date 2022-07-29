// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2 

int[] array = new int[10];

void PrintArray(int[] arr )
{   
    int length = arr.Length;
    for( int j  = 0; j < length; j++)
    {
        arr[j] = new Random().Next(100,1000);
        Console.WriteLine(arr[j]);
    }
}

int LookingFor (int[] ab)
{
    int sum = 0;
    for( int i = 0; i < ab.Length; i++)
    {
        if(ab[i] % 2 ==0)
        {
            Console.WriteLine($" Количество четных чисел рано {sum = sum + 1} ");
        }
       
    }
    return sum;
} 

PrintArray(array);
Console.WriteLine(LookingFor(array));