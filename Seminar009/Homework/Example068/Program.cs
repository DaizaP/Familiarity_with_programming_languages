// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
using System;
using static System.Console;

Clear();

int A(int m, int n)
{
    if (m == 0) { return n + 1; }
    else if (m != 0 && n == 0) { return A(m - 1, 1); }
    else { return A(m - 1, A(m, n - 1)); }
}
Write("Введите значение m: ");
int m = int.Parse(ReadLine());
Write("Введите значение n: ");
int n = int.Parse(ReadLine());
Write($"m = {m}, n = {n} -> A(n, m) = {A(m, n)}");

// https://ru.wikipedia.org/wiki/%D0%A4%D1%83%D0%BD%D0%BA%D1%86%D0%B8%D1%8F_%D0%90%D0%BA%D0%BA%D0%B5%D1%80%D0%BC%D0%B0%D0%BD%D0%B0


