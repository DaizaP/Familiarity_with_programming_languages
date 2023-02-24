// Задача 5. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
//  1  2  3  4
// 12 13 14  5
// 11 16 15  6
// 10  9  8  7
using System;
using static System.Console;
Clear();
int[,] GetArray(int lines, int columns)
{
    int i = 0, j = 0;
    int element = 1;
    int cycle = 1;

    int[,] result = new int[lines, columns];
    while (element != (lines * columns) + 1)
    {
        for (i = i + (cycle - 1), j = j; j < result.GetLength(1); j++)
        {
            if (result[i, j] == 0) { result[i, j] = element; element++; }
        }
        for (i = i, j = j - (cycle); i < result.GetLength(0); i++)
        {
            if (result[i, j] == 0) { result[i, j] = element; element++; }
        }
        for (i = i - (cycle), j = j; j >= 0; j--)
        {
            if (result[i, j] == 0) { result[i, j] = element; element++; }
        }
        for (i = i, j = j + (cycle); i >= 0; i--)
        {
            if (result[i, j] == 0) { result[i, j] = element; element++; }
        }
        cycle++;
    }
    return result;

}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] >= -1 && inArray[i, j] < 10) { Write($"   {inArray[i, j]}"); }// Для красоты
            else if (inArray[i, j] >= 10 && inArray[i, j] < 100) { Write($"  {inArray[i, j]}"); }
            else { Write($" {inArray[i, j]}"); }
        }
        WriteLine();
    }
}
int[,] array = GetArray(20, 20);
PrintArray(array);
