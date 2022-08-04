// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int m = 0;
int n = 0;
int.TryParse(Console.ReadLine(), out m);
int.TryParse(Console.ReadLine(), out n);

int[,] array = new int[m, n];

for (int i =0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,  j] = new Random().Next(10); 
        Console.Write($"{array[i, j]} " );
    }
    Console.WriteLine();
}
for(int k = 0; k < n; k++)
{
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < m; j++)
        {
            int min = 0;
            min = array[j,i];
            if(array[j,i] <= array[j,i + 1])
            {
                array[j,i] = array[j,i + 1];
                array[j,i + 1] = min;
            }
        }
    }
}
Console.WriteLine();
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.Write($"\n");
} 