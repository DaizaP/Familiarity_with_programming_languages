// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся
//  на главной диагонали (с индексами (0,0); (1; 1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
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
int SumElementDiagonal(int[,] inArray)
{
    int length = inArray.GetLength(0) < inArray.GetLength(1) ? inArray.GetLength(0) : inArray.GetLength(1);
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        Write($"{inArray[i, i]}, ");
        sum += inArray[i, i];
    }
    return sum;
}

Write($"Введите кол-во строк и столбцов для массива через Enter: ");
int lines = int.Parse(Read(" "));
int columns = int.Parse(ReadLine());
int[,] array = GetArray(lines, columns, 1, 9);
PrintArray(array);
WriteLine("- - - -");
Write(SumElementDiagonal(array));
