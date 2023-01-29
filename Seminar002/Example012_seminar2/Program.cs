// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно
Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int num2 = int.Parse(Console.ReadLine());
if (num % num2 == 0)
{
    Console.WriteLine($"{num}, {num2} -> Кратно");
}
else
{
    Console.WriteLine($"{num}, {num2} -> Не кратно, остаток {num % num2}");
}