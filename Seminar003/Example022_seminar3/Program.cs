// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
void TableOfSquares(int ArrayLength)
{
    int i = 1;
    int m = ArrayLength;
    Console.Write($"{ArrayLength} -> ");
    if(ArrayLength < 0)
    {
        i = ArrayLength;
        m = -1;
    }
    int[] square = new int[Math.Abs(ArrayLength)];
    for (int j = 0; i <= m; i++, j++)
    {
        square[j] = Convert.ToInt32(Math.Pow(i, 2));
        Console.Write($"{square[j]}, ");
    }
}
Console.Clear();
Console.Write("Введите число, обозначающую длинну массива: ");
TableOfSquares(int.Parse(Console.ReadLine()));