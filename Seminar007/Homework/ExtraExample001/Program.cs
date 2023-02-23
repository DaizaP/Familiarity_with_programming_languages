// *Доп1
// На днях Иван у себя в прихожей выложил кафель,
// состоящий из квадратных черных и белых плиток.
// Прихожая Ивана имеет квадратную форму 4х4, вмещающую 16 плиток.
// Теперь Иван переживает, что узор из плиток, который у него получился,
// может быть не симпатичным. С точки зрения дизайна симпатичным узором считается тот,
// который не содержит в себе квадрата 2х2, состоящего из плиток одного цвета.
// Входные данные:
// BWBW
// BBWB
// WWBB
// BWWW
// Ответ:
// Yes

// Входные данные:
// BBWB
// BBWB
// WWBW
// BBWB
// Ответ:
// No
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

char[,] GetRandomArrayTiles()
{
    string symbol = "BW";
    Random rnd = new Random();
    char[,] result = new char[4, 4];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = symbol[rnd.Next(0, symbol.Length)];
        }
    }
    return result;
}

void PrintArray(char[,] inArray)
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
void ValidTiles(char[,] inArray)
{
    bool valid = true;
    for (int i = 1; i < inArray.GetLength(0) - 1; i++)
    {
        for (int j = 1; j < inArray.GetLength(1) - 1; j++)
        {
            if ((inArray[i, j] == inArray[i - 1, j] && inArray[i, j] == inArray[i, j - 1] && inArray[i, j] == inArray[i - 1, j - 1]) ||
                (inArray[i, j] == inArray[i - 1, j] && inArray[i, j] == inArray[i, j + 1] && inArray[i, j] == inArray[i - 1, j + 1]) ||
                (inArray[i, j] == inArray[i + 1, j] && inArray[i, j] == inArray[i, j - 1] && inArray[i, j] == inArray[i + 1, j - 1]) ||
                (inArray[i, j] == inArray[i + 1, j] && inArray[i, j] == inArray[i, j + 1] && inArray[i, j] == inArray[i + 1, j + 1]))
            {
                // Write($"[{i + 1}, {j + 1}]"); // Для ручной проверки правильности выполнения
                valid = false;
                break;
            }
        }
    }
    Write("Ответ: ");
    Write(valid);
}
char[,] array = GetRandomArrayTiles();
PrintArray(array);
ValidTiles(array);