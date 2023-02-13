// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1(коэфицент) * x + b1(константа), y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();

// void Intersection()
// {

//     Console.Write($"Введите числа для прямой b1 и k1 через клавишу Enter: ");
//     double b1 = int.Parse(Read(" "));
//     double k1 = int.Parse(Console.ReadLine());
//     Console.Write($"Введите числа для прямой b2 и k2 через клавишу Enter: ");
//     double b2 = int.Parse(Read(" "));
//     double k2 = int.Parse(Console.ReadLine());
//     if (Valid(k1, b1, k2, b2))
//     {
//         double x = (b2 - b1) / (k1 - k2);
//         double y = k2*(b2-b1)/(k1-k2)+ b2;
//         Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ");
//         Console.Write("{0,6:F1}", x);
//         Console.Write("{0,6:F1}", y);
//     }
// }
// Intersection();

string Read(string s)
{
    (int posLeft, int posTop) = Console.GetCursorPosition();
    string textFromConsole = Console.ReadLine();
    posLeft = posLeft + textFromConsole.Length;
    Console.SetCursorPosition(posLeft, posTop);
    Console.Write($"{s}");
    return textFromConsole;
}
bool Valid(double[,] arr)
{
    if (arr[0,1] == arr[0,2])
    {
        if (arr[1,1] == arr[1,2])
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
const int k = 0;
const int b = 1;
const int x = 0;
const int y = 1;

double[,] arr = new double[2,3];
    Console.Write($"Введите числа для прямой b1 и k1 через клавишу Enter: ");
    arr[b,1] = int.Parse(Read(" "));
    arr[k,1] = int.Parse(Console.ReadLine());
    Console.Write($"Введите числа для прямой b2 и k2 через клавишу Enter: ");
    arr[b,2] = int.Parse(Read(" "));
    arr[k,2] = int.Parse(Console.ReadLine());
    if (Valid(arr))
    {
        arr[x,0] = (arr[b,2] - arr[b,1]) / (arr[k,1] - arr[k,2]);
        arr[y,0] = arr[k,2]*(arr[b,2]-arr[b,1])/(arr[k,1]-arr[k,2])+ arr[b,2];
        Console.Write($"b1 = {arr[b,1]}, k1 = {arr[k,1]}, b2 = {arr[b,2]}, k2 = {arr[k,2]} -> ");
        Console.Write("{0,6:F1}", arr[x,0]);
        Console.Write("{0,6:F1}", arr[y,0]);
    }
}
Intersection();
