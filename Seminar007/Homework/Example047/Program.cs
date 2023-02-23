// double m = new Random().NextDouble()*(5) + 2;
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using System;
using static System.Console;

Clear();

string Read(string s)
{
    (int posLeft, int posTop) = Console.GetCursorPosition();
    string textFromConsole = Console.ReadLine();
    posLeft = posLeft + textFromConsole.Length;
    Console.SetCursorPosition(posLeft, posTop);
    Console.Write($"{s}");
    return textFromConsole;
}

double[,] GetRandomDoubleArray(int lines, int columns, int minValue, int maxValue)
{
    
    double[,] result = new double[lines, columns];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().NextDouble() * (2*minValue)+ maxValue;
        }
    }
    return result;
}

void PrintDoubleArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Write("[");
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write("{0,5:F1}", inArray[i, j]);
        }
        WriteLine("]");
    }
}
Write($"Введите кол-во строк и столбцов для массива через Enter: ");
int lines = int.Parse(Read(" "));
int columns = int.Parse(ReadLine());
double[,] array = GetRandomDoubleArray(lines, columns, -10, 10);
PrintDoubleArray(array);