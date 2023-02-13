// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Очень хотелось все в одной строчке написать, но не нашел аналога "Console.ReadLine()", только без переноса строки. Написал свой. Вроде работает. В скобках метода принимает строку для знаков препинания и другого текста.
string Read(string s)
{
    (int posLeft, int posTop) = Console.GetCursorPosition();
    string textFromConsole = Console.ReadLine();
    posLeft = posLeft + textFromConsole.Length;
    Console.SetCursorPosition(posLeft, posTop);
    Console.Write($"{s}");
    return textFromConsole;
}
void CustomRandomArray(int ArrayLength, int min, int max)
{
    Console.Write("[ ");
    int[] Array = new int[ArrayLength];
    for (int i = 0; i < ArrayLength; i++)
    {
        Array[i] = new Random().Next(min, max + 1);
        Console.Write($"{Array[i]}, ");
    }
    Console.Write("]");
}
Console.Clear();
Console.Write("Введите параметры массива (длина массива, минимальное значение, максимальное значение): ");
CustomRandomArray(int.Parse(Read(", ")), int.Parse(Read(", ")), int.Parse(Console.ReadLine()));


// int[] GetRandomArray(int size,int minValue,int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue,maxValue+1);
//     }

//     return result;
// }