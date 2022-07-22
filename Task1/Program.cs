int numberA = new Random().Next(1, 10);
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int max = numberA;
if (numberB > numberA) 
{
    Console.WriteLine("max = numberB");
}
else 
{
    Console.WriteLine("max = numberA");
}
