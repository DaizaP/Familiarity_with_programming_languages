// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.WriteLine("Введите значение X для точки A: ");
int NumXA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение Y для точки A: ");
int NumYA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение Z для точки A: ");
int NumZA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение X для точки B: ");
int NumXB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение Y для точки B: ");
int NumYB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение Z для точки A: ");
int NumZB = int.Parse(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow(NumXA - NumXB, 2) + Math.Pow(NumYA - NumYB, 2) + Math.Pow(NumZA - NumZB, 2)); // Math.Round() знаки после запятой в значении
Console.WriteLine($"Дистанция между точками A и B: {distance:f2}"); // :f2 знаки после запятой при выводе ответа