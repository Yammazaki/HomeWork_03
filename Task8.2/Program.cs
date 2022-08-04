// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
int SumLine1(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < n; j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}
int minSumLine = 0;
int sumLine = SumLine1(array, 0);
for (int i = 1; i < m; i++)
{
  int tempSumLine = SumLine1(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}
Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");