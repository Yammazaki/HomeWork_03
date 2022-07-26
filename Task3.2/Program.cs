/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.WriteLine ("Введите координаты точек");
int x1 = Coord("x", "A");
int y1 = Coord("y", "A");
int z1 = Coord("z", "A");
int x2 = Coord("x", "B");
int y2 = Coord("y", "B");
int z2 = Coord("z", "B");

int Coord(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}
int Sum = ((x2-x1)*(x2-x1)) + ((y2-y1)*(y2-y1)) + ((z2-z1)*(z2-z1));
Console.WriteLine(MathF.Sqrt(Sum));

