// Задача 1: Задайте двумерный массив.
// Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
// Я если честно не понял условия задания. В условии по убыванию, в примере по возрастанию. Сделал оба, на всякий случай.
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
int[,] CopyArray(int[,] inArray)
{
    int[,] result = new int[inArray.GetLength(0), inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[i, j] = inArray[i, j];
        }
    }
    return result;
}
int[,] BubbleSort(int[,] inArray, int lines)
{
    int temp;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = i + 1; j < inArray.GetLength(0); j++)
        {
            if (inArray[lines, i] > inArray[lines, j])
            {
                temp = inArray[lines, i];
                inArray[lines, i] = inArray[lines, j];
                inArray[lines, j] = temp;
            }
        }
    }
    return inArray;
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
int[,] SortArray(int[,] inArray)
{
    int[,] result = CopyArray(inArray); // Чтобы можно было продолжать работать с первоначальным массивом
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        BubbleSort(result, i);
    }
    return result;
}
int[,] BubbleDescendingSort(int[,] inArray, int lines)
{
    int temp;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = i +1; j < inArray.GetLength(0); j++)
        {
            if (inArray[lines, i] < inArray[lines, j])
            {
                temp = inArray[lines, i];
                inArray[lines, i] = inArray[lines, j];
                inArray[lines, j] = temp;
            }
        }
    }
    return inArray;
}
int[,] SortDescendingArray(int[,] inArray)
{
    int[,] result = CopyArray(inArray); // Чтобы можно было продолжать работать с первоначальным массивом
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        BubbleDescendingSort(result, i);
    }
    return result;
}
Write($"Введите кол-во строк и столбцов для двумерного массива через Enter: ");
int lines = int.Parse(Read(" "));
int columns = int.Parse(ReadLine());
int[,] array = GetArray(lines, columns, 1, 9);
PrintArray(array);
WriteLine("- - - -");
WriteLine("Сортировка по возрастанию: ");
PrintArray(SortArray(array));
WriteLine("- - - -");
WriteLine("Сортировка по убыванию: ");
PrintArray(SortDescendingArray(array));