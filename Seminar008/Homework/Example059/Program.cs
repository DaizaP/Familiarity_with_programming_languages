// 59
// Из двумерного массива целых чисел удалить строку и столбец,
// на пересечении которых расположен первый найденный наименьший элемент.
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
            if (inArray[i,j] == 0){Write($"X ");} // X = null .Для вида
            else{Write($"{inArray[i, j]} ");}
        }
        WriteLine();
    }
}
int FindMinValue(int[,] inArray)
{
    int minValue = inArray[0, 0];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] < minValue)
            {
                minValue = inArray[i, j];
            }
        }
    }
    return minValue;
}
int[,] DeleteLinesAndColumns(int[,] inArray, int minValue)
{
    bool fistMinValue = false;
    int[,] result = inArray;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (result[i, j] == minValue)
            {
                // WriteLine($"{result[i, j]}: i = {i}, j = {j}"); // Проверка
                for (int f = 0; f < inArray.GetLength(0); f++)
                {
                    result[i, f] = 0;
                }
                for (int g = 0; g < inArray.GetLength(1); g++)
                {
                    result[g, j] = 0;
                }
                fistMinValue = true;
                break;
            }
            if (fistMinValue) { break; }
        }
        if (fistMinValue) { break; }
    }
    return result;
}
Write($"Введите кол-во строк и столбцов для двумерного массива через Enter: ");
int lines = int.Parse(Read(" "));
int columns = int.Parse(ReadLine());
int[,] array = GetArray(lines, columns, 1, 9);
PrintArray(array);
WriteLine("- - - -");
PrintArray(DeleteLinesAndColumns(array, FindMinValue(array)));