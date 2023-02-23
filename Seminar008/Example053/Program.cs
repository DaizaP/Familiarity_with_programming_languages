// **Задача 53:** Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2


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

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

void SwapExtremeLinesArray(int[,] inArray)
{
    int length = inArray.GetLength(0) < inArray.GetLength(1) ? inArray.GetLength(0) : inArray.GetLength(1);
    for (int i = 0, j = 0; j < length; j++)
    {
        int tmp = inArray[i, j];
        inArray[i, j] = inArray[length - 1, j];
        inArray[length - 1, j] = tmp;
    }
    PrintArray(inArray);
}

Write($"Введите кол-во строк и столбцов для массива через Enter: ");
int lines = int.Parse(Read(" "));
int columns = int.Parse(ReadLine());
int[,] array = GetArray(lines, columns, 2, 9);
PrintArray(array);
WriteLine("- - - -");
SwapExtremeLinesArray(array);