// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Кол-во цифр в числе {num}: {stringLength(num)}");

int stringLength(int s)
{
    int count = 0;
    while (Math.Abs(s) > 0)
    {
        count++;
        s /= 10;
    }
    return count;
}