/* Напишите программу, которая на вход будет принимать X и Y, при этом x или y != 0, и напишите в какой четветри плоскости находится точка*/




Console.Clear();
Console.WriteLine("Введите X: ");
int X = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y: ");
int Y = int.Parse(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine("I");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("II");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("III");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("IV");
}
else if (X == 0 || Y == 0)
{
    Console.WriteLine("Точка лежит на оси!");
}