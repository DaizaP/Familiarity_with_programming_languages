// 20 Напишите программу,
// которая принимает на вход координаты двух точек и находит
// расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09
//double s = Math.Sqrt(...);

Console.Clear();
Console.WriteLine("Введите значение X для точки A: ");
int NumXA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение Y для точки A: ");
int NumYA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение X для точки B: ");
int NumXB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение Y для точки B: ");
int NumYB = int.Parse(Console.ReadLine());
double distance = Math.Round(Math.Sqrt(Math.Pow(NumXA - NumXB, 2) + Math.Pow(NumYA - NumYB, 2)), 0); // Math.Round() знаки после запятой в значении
Console.WriteLine($"Дистанция между точками A и B: {distance}");
Console.WriteLine($"Дистанция между точками A и B: {distance:f0}"); // :f2 знаки после запятой при выводе ответа
 