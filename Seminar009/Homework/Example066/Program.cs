// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
using System;
using static System.Console;

Clear();

int PrintNumbers(int n, int m)
{
    if (n == m)
    {
        return m;
    }
    int s = PrintNumbers(n - 1, m) + n;
    return s;
}
Write("Введите минимальное значение m: ");
int m = int.Parse(ReadLine());
Write("Введите максимальное значение n: ");
int n = int.Parse(ReadLine());
Write(PrintNumbers(n, m));