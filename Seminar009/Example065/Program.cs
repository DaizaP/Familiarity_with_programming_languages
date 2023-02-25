// **Задача 65:**Задайте значения M и N.
//  Напишите программу, которая выведет все
//   натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"
using System;
using static System.Console;

Clear();

string PrintNumbers(int n, int m)
{
    if (n == m)
    {
        return $"{m}";
    }
    string s = PrintNumbers(n - 1, m) + " " + n.ToString();
    return s;
}
Write("Введите минимальное значение m: ");
int m = int.Parse(ReadLine());
Write("Введите максимальное значение n: ");
int n = int.Parse(ReadLine());
Write(PrintNumbers(n, m));