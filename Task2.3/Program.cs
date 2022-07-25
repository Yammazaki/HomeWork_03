int number = 0;
Console.Write("Введите номер недели: ");
string userEnter = Console.ReadLine();
number = int.Parse(userEnter);

if (number > 5)
{
    Console.Write("Yes");
}
else 
    Console.Write("No");