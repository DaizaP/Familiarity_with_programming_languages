// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();

double[] GetRandomArray()
{
    Console.Write("[");
    double[] result = new double[5];

    for (int i = 0; i < 5; i++)
    {
        result[i] = new Random().NextDouble() * 100;
        Console.Write("{0,6:F2}", result[i]);
    }
    Console.Write("] -> ");
    return result;
}

double MaxValue(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
        foreach (var item in array)
        {
            if (item > max)
            {
                max = item;
            }
        }
        return max;
}

double MinValue(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
        foreach (var item in array)
        {
            if (item < min)
            {
                min = item;
            }
        }
        return min;
}

double[] array = GetRandomArray();
Console.Write("{0,6:F2}", MaxValue(array) - MinValue(array));
