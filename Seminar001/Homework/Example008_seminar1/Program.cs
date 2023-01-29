﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Clear();

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int num2 = num % 2;
Console.Write($"{num} -> ");
if (num > 0)
{
    for (int i = 2; i <= num; i = i + 2)
    {
        Console.Write($"{i}, ");
    }
}
else
{
    for (int i = 0; i > num; i = i - 2) // т.к. в промежуке от 1 до любого отрицатиельного числа, есть число "0", которое является четным, то начинается отчет в отрицательнцю сторону с него
    {
        Console.Write($"{i}, ");
    }
}