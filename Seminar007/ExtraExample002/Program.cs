/* **Доп
Игра «Жизнь» была придумана английским математиком Джоном Конвейем в 1970 году.
Впервые описание этой игры опубликовано в октябрьском выпуске (1970) журнала Scientic American,
в рубрике «Математические игры» Мартина Гарднера.

Место действия этой игры – «вселенная» – это размеченная на клетки поверхность.
Каждая клетка на этой поверхности может находиться в двух состояниях: быть живой или быть мертвой.
Клетка имеет восемь соседей. Распределение живых клеток в начале игры называется первым поколением.
Каждое следующее поколение рассчитывается на основе предыдущего по таким правилам:

1)пустая(мертвая) клетка с ровно тремя живыми клетками-соседями оживает;
2)если у живой клетки есть две или три живые соседки, то эта клетка продолжает жить;
в противном случае (если соседок меньше двух или больше трех)
клетка умирает(от «одиночества» или от «перенаселенности»).
В этой задаче рассматривается игра «Жизнь» на торе.
Представим себе прямоугольник размером n строк на m столбцов.
Для того, чтобы превратить его в тор мысленно «склеим» его верхнюю сторону с нижней, а левую с правой.

Таким образом, у каждой клетки, даже если она раньше находилась на границе прямоугольника,
теперь есть ровно восемь соседей.

Ваша задача состоит в том, чтобы найти конфигурацию клеток, которая будет через k поколений от заданного.
+ - живая клетка
. - мёртвая

n m k(4 ≤ n, m ≤ 100; 0 ≤ k ≤ 100).
Входные данные:
5 строки, 5 столбцы, 1 поколения
++...
..++.
.+...
..+..
...+.
Ответ:
.+.++
+.+..
.+.+.
..+..
.++..

Входные данные:
5 5 5
++...
..++.
.+...
..+..
...+.
Ответ:
.+++.
.+...
.+...
..+.
.....
Входные данные:
4 7 5
.+.+.+.
+.+.+.+
.+.+.+.
+.+.+.+
Ответ:
.......
.......
.......
....... */

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

int[,] GetRandomArray(int lines, int columns)
{
    Random rnd = new Random();
    int[,] result = new int[lines, columns];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = rnd.Next(0, 2);
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
            if (inArray[i, j] == 1) { Write("o "); }
            else { Write("_ "); }
        }
        WriteLine();
    }
}
// [условие] ? [действие при true]:[действие при false]
int ThorX(int[,] inArray, int lines)
{
    lines = (lines < 0 ? lines += inArray.GetLength(0) : lines);
    lines = (lines < inArray.GetLength(0) ? lines : lines - inArray.GetLength(0));
    return lines;
}
int ThorY(int[,] inArray, int columns)
{
    columns = (columns < 0 ? columns += inArray.GetLength(1) : columns);
    columns = (columns < inArray.GetLength(1) ? columns : columns - inArray.GetLength(1));
    return columns;
}

int NeighborCount(int lines, int columns, int[,] inArray)
{
    int neigbors = 0;

    if (inArray[ThorX(inArray, lines - 1), ThorY(inArray, columns)] == 1) { neigbors++; }
    if (inArray[ThorX(inArray, lines + 1), ThorY(inArray, columns)] == 1) { neigbors++; }
    if (inArray[ThorX(inArray, lines), ThorY(inArray, columns - 1)] == 1) { neigbors++; }
    if (inArray[ThorX(inArray, lines), ThorY(inArray, columns + 1)] == 1) { neigbors++; }
    if (inArray[ThorX(inArray, lines - 1), ThorY(inArray, columns - 1)] == 1) { neigbors++; }
    if (inArray[ThorX(inArray, lines - 1), ThorY(inArray, columns + 1)] == 1) { neigbors++; }
    if (inArray[ThorX(inArray, lines + 1), ThorY(inArray, columns - 1)] == 1) { neigbors++; }
    if (inArray[ThorX(inArray, lines + 1), ThorY(inArray, columns + 1)] == 1) { neigbors++; }


    return neigbors;
}
void LifeOrDeath(int[,] inArray, int age)
{
    int cycle = 1;
    int[,] result = new int[inArray.GetLength(0), inArray.GetLength(1)];
    while (cycle != age + 1)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                int alive = NeighborCount(i, j, inArray);
                if (inArray[i, j] == 1 && (alive == 2 || alive == 3)) { result[i, j] = 1; }
                if (inArray[i, j] == 1 && (alive < 2 || alive > 3)) { result[i, j] = 0; }
                if (inArray[i, j] == 0 && alive == 3) { result[i, j] = 1; }
            }
        }
        WriteLine($"Поколение {cycle}.");
        PrintArray(result); //Ручная проверка и вывод каждого поколения
        inArray = result;
        cycle++;
    }
}

Write($"Введите кол-во строк и столбцов для массива и кол-во поколений через Enter: ");
int lines = int.Parse(Read(" "));
int columns = int.Parse(Read(" "));
int age = int.Parse(ReadLine());
int[,] array = GetRandomArray(lines, columns);
PrintArray(array);
LifeOrDeath(array, age);