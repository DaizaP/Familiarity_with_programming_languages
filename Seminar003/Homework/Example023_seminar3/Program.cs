// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();
Console.Write("Введите число, обозначающую длинну массива: ");
int ArrayLength = int.Parse(Console.ReadLine());
int i = 1;
int m = ArrayLength;
Console.Write($"{ArrayLength} -> ");
if (ArrayLength < 0)
{
    i = ArrayLength;
    m = -1;
}
int[] square = new int[Math.Abs(ArrayLength)];
for (int j = 0; i <= m; i++, j++)
{
    square[j] = Convert.ToInt32(Math.Pow(i, 3));
    Console.Write($"{square[j]}, ");
}
