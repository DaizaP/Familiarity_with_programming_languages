// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1(коэфицент) * x + b1(константа), y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
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
bool Valid(double k1, double b1, double k2, double b2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
        {
            Console.Write("Заданные прямые совпадают!");
            return false;
        }
        else
        {
            Console.Write("Заданные прямые паралельны!");
            return false;
        }
    }
    return true;
}
void Intersection()
{

    Console.Write($"Введите числа для прямой b1 и k1 через клавишу Enter: ");
    double b1 = int.Parse(Read(" "));
    double k1 = int.Parse(Console.ReadLine());
    Console.Write($"Введите числа для прямой b2 и k2 через клавишу Enter: ");
    double b2 = int.Parse(Read(" "));
    double k2 = int.Parse(Console.ReadLine());
    if (Valid(k1, b1, k2, b2))
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k2*(b2-b1)/(k1-k2)+ b2;
        Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ");
        Console.Write("{0,6:F1}", x);
        Console.Write("{0,6:F1}", y);
    }
}
Intersection();