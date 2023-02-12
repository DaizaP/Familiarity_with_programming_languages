// **Задача 40:**Напишите программу, 
// которая принимает на вход три числа и проверяет, может ли 
// существовать треугольник с сторонами такой длины.

// ❗ **Теорема о неравенстве треугольника:
// **каждая сторона треугольника меньше суммы двух других сторон.
Console.Clear();

string Read(string s)
{
    (int posLeft, int posTop) = Console.GetCursorPosition();
    string textFromConsole = Console.ReadLine();
    posLeft = posLeft + textFromConsole.Length;
    Console.SetCursorPosition(posLeft, posTop);
    Console.Write($"{s}");
    return textFromConsole;
}

void Triangle()
{
    Console.Write($"Введите числа для сторон треугольника через клавишу Enter: ");
    int a = int.Parse(Read(" "));
    int b = int.Parse(Read(" "));
    int c = int.Parse(Read(" "));
    if (a + b < c || a + c < b || b + c < a)
    {
        Console.Write("Такой треугольник не может существовать");
    }
    else
    {
        Console.Write("Такой треугольник может существовать");
    }
}
Triangle();