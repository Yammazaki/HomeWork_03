/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Введите пятизначное число: ");
string a = Console.ReadLine();

void LookingFor (string a)
{
if (a[0] == a[4] && a[1] == a[3])
{
    Console.WriteLine($"Ваше число: {a} - палиндром.");
}
else
    Console.WriteLine($" Увы, Ваше число: {a} - не палиндром.");
}
if (a!.Length == 5)
{
    LookingFor(a);
}
else
Console.WriteLine($"Ваше число не подходит");