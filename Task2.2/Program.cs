int n = 0;
Console.Write("Введите число: ");
n = int.Parse(Console.ReadLine());

if (n>99)
{
    Console.WriteLine(n.ToString()[2]);
}
else 
{
    Console.WriteLine("третьей цифры нет");
}