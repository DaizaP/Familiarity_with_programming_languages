// Задача 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы
// каждого элемента.
// массив размером 2 x 2 x 2
// int[,,]
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)
using System;
using static System.Console;

Clear();

int[,,] GetArray(int x, int y, int z, int minValue, int maxValue)
{
    int cycle = 1;
    int[,,] result = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int n = 0; n < z; n++)
            {
                int temp = new Random().Next(minValue, maxValue + cycle);
                if(CheckElementArray(result,temp)==false)
                {
                    while (CheckElementArray(result,temp)==false)
                    {
                    temp = new Random().Next(minValue, maxValue + cycle);
                    cycle++;
                    }
                }
                result[i,j,n]=temp;
            }
        }
    }
    return result;
}

bool CheckElementArray(int[,,] inArray, int element)
{
    bool result = true;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int n = 0; n < inArray.GetLength(2); n++)
            {
                if (inArray[i, j, n] == element) { result = false; break; }
            }
            if (result == false) { break; }
        }
        if (result == false) { break; }
    }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int n = 0; n < inArray.GetLength(2); n++)
            {
                Write($"{inArray[i, j, n]}({i},{j},{n}) ");
            }
        }
        WriteLine();
    }
}
int[,,] array = GetArray(2, 2, 2, 1, 9);
PrintArray(array);