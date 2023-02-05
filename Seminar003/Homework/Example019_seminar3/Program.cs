// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.Write("Введите пятизначное число: ");
// Это слишком громоздко, но я добавлю большое решение с конвертацией в строку и заполнением массива значениями из строки(для закрепления материала, так сказать), ниже напишу короткий и более быстрый вариант, через деление с остатком
int num = int.Parse(Console.ReadLine());
string s = Convert.ToString(Math.Abs(num));
Console.Write($"{s} -> ");
string[] Array = new string[5];
int i = 0;
while (i < s.Length)
{
    Array[i] = Convert.ToString(s[i]);
    i++;
}
if (Array[0] == Array[4]&&Array[1] == Array[3])
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}
// int num = int.Parse(Console.ReadLine());
// Console.Write($"{num} -> ");
// if ((num > 9999 && num < 100000) && ((num % 100000) / 10000 == (num % 10)) && ((num % 10000) / 1000 == (num % 100) / 10))
// {
//     Console.Write("Да");
// }
// else
// {
//     Console.Write("Нет");
// }