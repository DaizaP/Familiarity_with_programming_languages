using System;
using static System.Console;

Clear();

int[,] PascalTriangle(int lines)
{
    int columns = lines * 3;
    int j = columns / 2;
    int[,] result = new int[lines, columns];
    result[0, j] = 1;
    result[1, j - 1] = 1;
    result[1, j + 1] = 1;
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
            if (inArray[i, j] != 0 && inArray[i, j + 1] == 0 && inArray[i, j + 2] == 0) { Write($""); }
            if (inArray[i, j] == 0 && inArray[i, j - 1] != 0 && inArray[i, j + 1] != 0) { Write($"     "); }
            else { Write($""); }
        }
        WriteLine();
    }
}

Write("Введите нужное количество строк треугольника Паскаля: ");
int lines = int.Parse(ReadLine());
PrintArray(PascalTriangle(lines));


// ALARM: В закоментированном ниже коде ошибка(с 15 строчки результать идет со знаком после запятой. Нужно поменять float на int, или результат не печатать сразу, а сначала округлить)
// Write("Введите нужное количество строк треугольника Паскаля: ");
// int rows = int.Parse(ReadLine());
// PrintTriangle(rows);

// //Функция вывода треугольника
// void PrintTriangle(int n)
// {
//     //Цикл для перебора строк треугольника
//     for (int i = 0; i < n; i++)
//     {
//         // создаём после каждой строки n-i отступов от левой стороны консоли, чем ниже строка, тем меньше отступ
//         for (int c = 0; c <= (n - i); c++) {
//             Write("  ");
//         }
//         for (int c = 0; c <= i; c++)
//         {
//             float result = factorial(i) / (factorial(c) * factorial(i - c)); // добавил округление
//             Write("   "); // создаём пробелы между элементами треугольника
//             // Write(factorial(i) / (factorial(c) * factorial(i - c))); //формула вычисления элементов треугольника
// Write("{0,5:F0}", result); // Добавил округление
//         }
//         WriteLine(); // после каждой строки с числами отступаем две пустые строчки
//     }
// }
// //Функция для подсчета факториала
// float factorial(int n)
// {
//     float x = 1;
//     for (int i = 1; i <= n; i++)
//     {
//         x *= i;
//     }
//     return x;
// }