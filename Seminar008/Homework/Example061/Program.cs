// 61
// Показать треугольник Паскаля. *Сделать вывод в виде равнобедренного треугольника.
using System;
using static System.Console;

Clear();

int[,] PascalTriangle(int lines)
{
    int columns = lines * 4;
    int j = columns / 2;
    int[,] result = new int[lines, columns];
    result[0, j] = 1;
    if(lines >1){result[1, j - 1] = 1; result[1, j + 1] = 1;}
    for (int i = 2; i < lines; i++)
    {
        if (i % 2 == 0)
        {
            for (int m = 0; m < result.GetLength(0); m += 2) // -2 +2
            {
                result[i, j - m] = result[i - 1, j - m - 1] + result[i - 1, j - m + 1];
                result[i, j + m] = result[i - 1, j - m - 1] + result[i - 1, j - m + 1];
            }
        }
        else
        {
            for (int m = 1; m < result.GetLength(0); m += 2) // -2 +2
            {
                result[i, j - m] = result[i - 1, j - m - 1] + result[i - 1, j - m + 1];
                result[i, j + m] = result[i - 1, j - m - 1] + result[i - 1, j - m + 1];
            }
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 1; j < inArray.GetLength(1) - 1; j++)
        {
            // Просто красиво делаю :)
            if (inArray[i, j] == 0 && inArray[i, j - 1] == 0 && inArray[i, j + 1] != 0)
            {
                int c = inArray.GetLength(0) - i;
                while (c > 0)
                {
                    Write($"     ");
                    c--;
                }
            }
            if (inArray[i, j] >= 1 && inArray[i, j] < 10) { Write($"  {inArray[i, j]}  "); }
            if (inArray[i, j] >= 10 && inArray[i, j] < 100) { Write($"  {inArray[i, j]} "); }
            if (inArray[i, j] >= 100 && inArray[i, j] < 1000) { Write($" {inArray[i, j]} "); }
            if (inArray[i, j] >= 1000 && inArray[i, j] < 10000) { Write($" {inArray[i, j]}"); }
            if (inArray[i, j] >= 10000) { Write($"{inArray[i, j]}"); }
            if (inArray[i, j] != 0&& inArray.GetLength(0)>1&& inArray[i, j + 1] == 0 && inArray[i, j + 2] == 0) { Write($""); }
            if (inArray[i, j] == 0 && inArray[i, j - 1] != 0 && inArray[i, j + 1] != 0) { Write($"     "); }
            if (inArray[i, j] == 0 && inArray[i, j - 1] >= 100000 && inArray[i, j + 1] >= 100000) //Подровнять 21 строку
            {
                (int posLeft, int posTop) = Console.GetCursorPosition();
                posLeft = posLeft - 1;
                Console.SetCursorPosition(posLeft, posTop);
            }
            else { Write($""); }
        }
        WriteLine();
    }
}

Write("Введите нужное количество строк треугольника Паскаля: ");
int lines = int.Parse(ReadLine());
PrintArray(PascalTriangle(lines));

