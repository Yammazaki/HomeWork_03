// Напишите программу, которая заполнит спирально массив 4 на 4.

int m = 0;
int n = 0;
int.TryParse(Console.ReadLine(), out m);
int.TryParse(Console.ReadLine(), out n);

int[,] array = new int[m, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= m * n)
{
  array[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < n - 1)
    j++;
  else if (i < j && i + j >= m - 1)
    i++;
  else if (i >= j && i + j > n - 1)
    j--;
  else
    i--;
}

WriteArray(array);

void WriteArray (int[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
