// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] array = new int [5, 5];

for (int i =0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        array[i,  j] = new Random().Next(10); 
    }
}
void PrintArray(int[,] array)
{
    for (int i =0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
}

int Find (int[,] array)
{
    int find = int.Parse(Console.ReadLine());
    for (int i = 0; i < 5; i++)
    {
        for( int j = 0; j < 5; j++)
        {
            if(array[i,j] == find)
        {
            Console.WriteLine($"{array[i,j]} ");
            break;
        }
        }
        if(find > 0)
            {
                Console.WriteLine($"{find} -> число {find} существует в этом массиве");
            }
        else
            {
                Console.WriteLine($"{find} -> такого числа в массиве нет");
            }
 
    }
    return find;
}
PrintArray(array); 
Console.WriteLine(Find(array));