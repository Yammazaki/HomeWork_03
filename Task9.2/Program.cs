// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int N = 0;
int M = 0;
int.TryParse(Console.ReadLine(), out N);
int.TryParse(Console.ReadLine(), out M);
int sum = 0; 

for(int i = N; i <= M; i++)
{
    sum = sum + i;
}
Console.WriteLine($"{sum} ");