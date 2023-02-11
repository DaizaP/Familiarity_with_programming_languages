// Задача 37:Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6]-> 36 21
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
        result[i] = new Random().Next(-10, 10 + 1);
    }
    return result;
}

int ProductNum(int[] array)
{
    int Product = 0;
    for (int i = 0, b = array.Length-1; i < array.Length / 2; i++, b--)
    {
        Product = array[i] * array[b];
        Console.Write($"{Product} ");
    }
return Product;
}
Console.Write("Введите длину массива: ");
int[] array = GetRandomArray(int.Parse(Read("")));
Console.WriteLine(";");
Console.Write($"[{String.Join(", ", array)}] -> ");
ProductNum(array);
Console.Write($";");