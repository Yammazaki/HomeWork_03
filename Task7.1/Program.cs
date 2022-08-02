//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


int m = 0;
int n = 0;
int.TryParse(Console.ReadLine(), out m);
int.TryParse(Console.ReadLine(), out n);

double[,] array = new double[m, n];

for (int i =0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,  j] = new Random().NextDouble(); 
    
    }
}
void PrintArray(double[,] array)
{
    for (int i =0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write("{0,6:F2}", array[i, j]); // ($"{array[i, j]} ");
    }
    Console.WriteLine();
}
}
PrintArray(array); 