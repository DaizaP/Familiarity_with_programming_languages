// Задача 2: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49
using System;
using static System.Console;

Clear();

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

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] >= 1 && inArray[i, j] < 10) { Write($" {inArray[i, j]} "); }// Для красоты
            else{Write($"{inArray[i, j]} ");}
        }
        WriteLine();
    }
}

int[,] ArrayProduct(int[,] inArray, int[,] inArray2)
{
    int[,] result = new int[inArray.GetLength(0), inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[i, j] = inArray[i, j] * inArray2[i, j];
        }
    }
    return result;
}

int[,] array = GetArray(5, 5, 1, 9);
WriteLine("Первый массив");
PrintArray(array);
WriteLine("Второй массив: ");
int[,] array2 = GetArray(5, 5, 1, 9);
PrintArray(array2);
WriteLine("Произведение массивов: ");
PrintArray(ArrayProduct(array,array2));