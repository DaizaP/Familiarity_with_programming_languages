// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
using System;
using static System.Console;

Clear();

int SumNumbers(int num)
{
    int sum = 0;
    if (num == 0)
    {
        return sum;
    }
    sum = num % 10 + SumNumbers(num / 10);
    return sum;
}
// int Sum(int num)
// {
//     num = Math.Abs(num);
//     int result = 0;
// while(num>0){
// result +=num%10;
// num /=10;
// }
//     return result;
// }

Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Write(SumNumbers(num));
// Write(Sum(num));