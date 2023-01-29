// 16// Напишите программу, которая принимает на вход два числа и проверяет,
//  является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.Clear();
Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 * num1  == num2 || num2 * num2 == num1 )
{
    Console.WriteLine($"Да");
}
else
{
    Console.WriteLine($"Нет");
}

/*if (number2 == number * number)
{
    Console.WriteLine($"Да");
}
else if ((number == number2 * number2))
{
    Console.WriteLine($"Да");
}
else
{
    Console.WriteLine($"Нет");
}*/

/*Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
if (a * a == b)
{
    Console.WriteLine("b квадрат a");
    return;
}
if (b * b == a)
{
    Console.WriteLine("a квадрат b");
}
else
{
    Console.WriteLine("не является");
}*/