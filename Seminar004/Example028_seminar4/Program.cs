// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4  -> 24
// 5  -> 120

int multiplication(int num)
{
    int multi = -1;
    if(num < 0 )
    for (int i = -2; i >= num; i--)
    {
        multi *= i;
    }
    return multi;
    for (int i = 2; i <= Math.Abs(num); i++)
    {
        multi *= i;
    }
    return multi;
}

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"{num} -> {(multiplication(num))}");
