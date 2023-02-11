// Задача 36: Задайте одномерный массив,
// заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях (отсчет 0).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
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
        result[i] = new Random().Next(-100, 100 + 1);
    }
    return result;
}

int SumNum(int[] array)
{
    int SumEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            SumEven += array[i];
    }
    return SumEven;
}
Console.Write("Введите длину массива: ");
int[] array = GetRandomArray(int.Parse(Read("")));
Console.WriteLine(";");
Console.WriteLine($"[{String.Join(", ", array)}] -> {SumNum(array)};");