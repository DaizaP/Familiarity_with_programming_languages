// Задача 34: Задайте массив заполненный
// случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();
string Read(string s)
{
    (int posLeft, int posTop) = Console.GetCursorPosition();
    string textFromConsole = Console.ReadLine();
    posLeft = posLeft + textFromConsole.Length;
    Console.SetCursorPosition(posLeft, posTop);
    Console.Write($"{s}");
    return textFromConsole;
}

int[] GetRandomArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100, 999 + 1);
    }
    return result;
}

int SumEvenNum(int[] array)
{
    int SumEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            SumEven++;
    }
    return SumEven;
}
Console.Write("Введите длину массива: ");
int[] array = GetRandomArray(int.Parse(Read("")));
Console.WriteLine(";");
Console.WriteLine($"[{String.Join(", ", array)}] -> {SumEvenNum(array)};");