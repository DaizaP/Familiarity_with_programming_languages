//Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
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

double[] Reference(double[] array)
{
    double[] result = new double[array.Length];

    for (int i = 0, j = result.Length-1; i <array.Length; i++,j--)
    {
        result[j] = array[i];
    }
return result;
}
double[] array = GetRandomArray();
double[] revarray = Reference(array);
Console.Write("[");
for (int i = 0; i < revarray.Length; i++)
{
    Console.Write("{0,6:F2}", revarray[i]);
}
Console.Write("]");