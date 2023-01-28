// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.

Console.Clear();
Console.Write("Введите трехзначное число:");
string s = Console.ReadLine();
int number1 = int.Parse(s);
int number = number1 % 10;
if (number1 < 100 || number1 > 999) // можно еше с циклом с просьбой ввести правильное число, если не входит в диапазон
{
    Console.WriteLine($"Число {number1} не является трехзначным");
}
else
{
    Console.WriteLine(number);
}

// S.Length != 3  (проверка длинны строки, а не числа)
