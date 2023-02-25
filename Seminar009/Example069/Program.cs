// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
// 45 -> 9
using System;
using static System.Console;

Clear();
string Read()
{
    (int posLeft, int posTop) = Console.GetCursorPosition();
    string textFromConsole = Console.ReadLine();
    posLeft = posLeft + textFromConsole.Length + 1;
    Console.SetCursorPosition(posLeft, posTop);
    return textFromConsole;
}


int Exp(int num1, int num2)
{
    int multiply = 1;
    for (int i = 1; i <= Math.Abs(num2); i++)
    {
        multiply *= num1;
    }
    return multiply;
}

int ExpNumbers(int number, int rank)
{
    if (rank == 0){ return 1;}
    return (number* ExpNumbers(number, rank-1));
}
Console.Clear();
Console.Write("Введите число A и B: ");
int A = int.Parse(Read());
int B = int.Parse(Console.ReadLine());
Console.WriteLine($"{A}, {B} -> {Exp(A, B)}");
Write(ExpNumbers(A,B));