// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
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
            result[i, j] = new Random().NextDouble() * (2 * minValue) + maxValue;
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
void CheckElementArray(double[,] array, int lines, int columns)
{
    if ((lines - 1 > array.GetLength(0) || columns - 1 > array.GetLength(1))||
        (lines < 0 || columns < 0)) WriteLine("В массиве нет такого элемента");
    else Write("{0,5:F1}", array[lines - 1, columns - 1]);
}

double[,] array = GetRandomDoubleArray(5, 5, -10, 10);
PrintDoubleArray(array);
Write($"Введите номер строки и столбца для поиска значения в массиве через Enter: ");
int lines = int.Parse(Read(" "));
int columns = int.Parse(ReadLine());
CheckElementArray(array, lines, columns);