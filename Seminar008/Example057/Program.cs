// /* **Задача 57:**Составить частотный словарь элементов 
// двумерного массива. Частотный словарь содержит информацию о том,
//  сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3, 4, 6, 1, 2, 1, 6
// 1, 1, 1, 2, 2, 3, 4, 6, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза*\
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
int[,] SortArray(int[,] inArray)
{
    int i = 0, j = 0;
    int temp;
    bool sorted = false;
    while (!sorted)
    {
        sorted = true;
        i = 0; j = 0;

        for (int inext = 0; inext < inArray.GetLength(0); inext++)
        {
            for (int jnext = 0; jnext < inArray.GetLength(1); jnext++)
            {
                if (inArray[i, j] > inArray[inext, jnext])
                {
                    temp = inArray[i, j];
                    inArray[i, j] = inArray[inext, jnext];
                    inArray[inext, jnext] = temp;
                    sorted = false;
                }
                i = inext;
                j = jnext;
            }
        }
    }
    return inArray;
}
int[] CollectionDoubleArray(int[,] inArray)
{
    int uniqueCountNext = 0;
    int uniqueCount = 0;
    int count = 0;
    int check = 0;
    int element = 0;
    int[] result = new int[inArray.GetLength(0) * inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            element = inArray[i, j];
            while (count != 1)
            {
                for (int z = 0; z < inArray.GetLength(0); z++)
                {
                    for (int x = 0; x < inArray.GetLength(1); x++)
                    {
                        if (element == inArray[z, x])
                        {
                            count = 1;
                            if (count == 1) { break; }
                        }
                        if (count == 1) { break; }
                    }
                    if (count == 1) { break; }
                }
                if (count == 1) { break; }
            }
            if (count == 1)
            {
                for (int m = 0; m < result.Length; m++)
                {
                    if (element == result[m])
                    {
                        check++;
                    }
                }
                if (check != 1)
                {
                    result[uniqueCountNext] = element;
                    uniqueCount = uniqueCountNext;
                    uniqueCountNext++;
                }
                count = 0;
                check = 0;
            }
        }
    }
    Array.Resize(ref result, Math.Abs(uniqueCountNext));
    return result;
}
void CountUniqueElement(int[] Collection, int[,] inArray)
{
    int count = 0;
    for (int i = 0; i < Collection.Length; i++)
    {
        for (int z = 0; z < inArray.GetLength(0); z++)
        {
            for (int x = 0; x < inArray.GetLength(1); x++)
            {
                if (Collection[i] == inArray[z, x])
                {
                    count++;
                }
            }
        }
        WriteLine($"{Collection[i]} встречается {count} раз");
        count = 0;
    }
}

Write($"Введите кол-во строк и столбцов для двумерного массива через Enter: ");
int lines = int.Parse(Read(" "));
int columns = int.Parse(ReadLine());
int[,] array = GetArray(lines, columns, 1, 9);
PrintArray(array);
WriteLine("- - - -");
// PrintArray(SortArray(array)); Проверка сортировки массива
CountUniqueElement(CollectionDoubleArray(SortArray(array)), array);


// using System;
// using static System.Console;

// Clear();

// Write("Введите количество строк массива: ");
// int rows = int.Parse(ReadLine());
// Write("Введите количество столбцов массива: ");
// int columns = int.Parse(ReadLine());
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// WriteLine();
// int[] rowAr = GetRowArray(array);
// SortArray(rowAr);
// WriteLine(String.Join(" ", rowAr));
// PrintData(rowAr);

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }

//     }
//     return result;
// }

// int[] GetRowArray(int[,] inArray)
// {
//     int[] result = new int[inArray.GetLength(0) * inArray.GetLength(1)];
//     int index = 0;
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             result[index] = inArray[i, j];
//             index++;
//         }
//     }
//     return result;
// }

// void SortArray(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         for (int j = i + 1; j < inArray.Length; j++)
//         {
//             if (inArray[i] > inArray[j])
//             {
//                 int k = inArray[i];
//                 inArray[i] = inArray[j];
//                 inArray[j] = k;
//             }
//         }
//     }
// }


// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i, j]} ");
//         }
//         WriteLine();
//     }
// }

// void PrintData(int[] inArray)
// {
//     int el = inArray[0];
//     int count = 1;
//     for (int i = 1; i < inArray.Length; i++)
//     {
//         if (inArray[i] != el)
//         {
//             WriteLine($"{el} встречается {count}");
//             el = inArray[i];
//             count = 1;
//         }
//         else
//         {
//             count++;
//         }
//     }
//     WriteLine($"{el} встречается {count}");
// }