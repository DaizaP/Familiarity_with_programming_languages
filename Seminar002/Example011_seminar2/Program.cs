// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Задача 11

// 456 -> 46
// 782 -> 72
// 918 -> 98
Console.Clear();
int num = new Random().Next(100, 1000);
Console.WriteLine($"Число {num}");
int num1 = num / 100;
int num2 = num % 10;
//int num3 = (num % 100) / 10;
Console.WriteLine($"{num1}{num2}");

// Console.Clear();
// int num = new Random().Next(100, 1000);
// int result = (num / 100) * 10 + num % 10;
// Console.WriteLine($"{num} -> {result}");
// Console.WriteLine($"{num} -> {num/100}{num%10}");