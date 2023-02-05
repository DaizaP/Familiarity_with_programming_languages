// Массив Длинной N заполнен монетами, которые рандомно лежат орлом к верху (1) и решкой(0). 
// Какое минимальное кол-во действий понадобится, чтобы перевернуть все монеты на одну сторону?

void EagleTails(int ArrayLength)
{
    int Tails0 = 0;
    int Eagle1 = 0;
    int[] ArrayCoins = new int[Math.Abs(ArrayLength)];
    for (int i = 0; i < ArrayLength; i++)
    {
        ArrayCoins[i] = new Random().Next(0, 2);
        Console.Write($"{ArrayCoins[i]}, ");
        if (ArrayCoins[i] == 0)
        {
            Tails0++;
        }
        else if (ArrayCoins[i] == 1)
        {
            Eagle1++;
        }
    }
    Console.WriteLine();
    if (Tails0 > Eagle1)
    {
        Console.WriteLine($"Кол-во переворотов: {Eagle1}");
    }
    else
    {
        Console.WriteLine($"Кол-во переворотов: {Tails0}");
    }
}
Console.Clear();
Console.WriteLine("Введите кол-во моненток");
EagleTails(int.Parse(Console.ReadLine()));