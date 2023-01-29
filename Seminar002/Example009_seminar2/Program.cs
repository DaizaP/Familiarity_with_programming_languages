// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа. 9 задача

// 78 -> 8
// 12-> 2
// 85 -> 8
Console.Clear();
int num = new Random().Next(10, 100);
Console.WriteLine($"Число {num}");
int num1 = num / 10;
int num2 = num % 10;
if (num1 > num2)
{
    Console.WriteLine($"Цифра {num1} больше цифры {num2}");
}
else
{
    Console.WriteLine($"Цифра {num2} больше цифры {num1}");
}