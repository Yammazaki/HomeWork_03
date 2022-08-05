// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

int N = 0;
int M = 0;
int.TryParse(Console.ReadLine(), out N);
int.TryParse(Console.ReadLine(), out M);

string PrintNumbers(int start, int end)
{   
     if (start == end)
        return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}


Console.Write(PrintNumbers(N, M));