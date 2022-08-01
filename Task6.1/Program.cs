// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел М: ");
int size = int.Parse(Console.ReadLine());
int sum = 0;

for(int i = 0; i < size; i++)
{
    Console.Write("Введите число: ");
    int num = int.Parse(Console.ReadLine());
    if(num > 0)
    {
        sum ++;
    }
}
Console.WriteLine($"Количество положительных чисел равно {sum} ");