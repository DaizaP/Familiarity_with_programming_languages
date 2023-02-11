/* **Задача 32:**Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}
int[] Array = GetRandomArray(12, -9, 10);
int[] SwitchMinus(int[] Array)
{
 for (int i = 0; i < Array.Length; i++)
 {
        Array[i] *= -1;
 }
 return Array;
}

Console.Clear();
Console.Write($"[{String.Join(", ", Array)}] -> ");
Console.WriteLine($"[{String.Join(", ", SwitchMinus(Array))}]");