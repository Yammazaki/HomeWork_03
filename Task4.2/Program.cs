/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

  int Sum(int N)
  {
    
    int count = Convert.ToString(N).Length;
    int sum = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
      sum = N - N % 10;
      result = result + (N - sum);
      N = N / 10;
    }
   return result;
  }

int sumNumber = Sum(N);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);
