/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 

Console.WriteLine("Введите число А");
int A  = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int B  = int.Parse(Console.ReadLine());

int c = Convert.ToInt32(Math.Pow(A, B));

Console.Write($"Если {A} возвести в {B} степень то получится = {c}"); */


 Console.Write("Введите число: ");
  int A = int.Parse(Console.ReadLine());
  Console.Write("Введите степень: ");
  int B = int.Parse(Console.ReadLine());
  int sum=1;
  for(int i = 0; i < B; i++) 
  {
   sum*=A;
  }
  Console.WriteLine("{0} ^ {1} = {2}", A, B, sum);
  return 0;