// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
//  Первые два числа Фибоначчи: 0 и 1.
// Если N = 5-> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// <aside>
// ❗ Числа Фибоначчи — числовая ****последовательность,
//  каждый элемент которой равен сумме двух предыдущих.
//f(n) = f(n-1) + f(n-2)

void Fibonacci(int n)
{
    int num2 = 1;
    int num1 = 0;
    int tmp = 0;
    Console.Write($"Если N = {n} -> {num1} {num2} ");
    for (int i = 2; i < n; i++)
    {
        int f = num1 + num2;
        tmp = num1;
        num1 = num2;
        num2 = f;
        Console.Write($"{f} ");
    }

}
Fibonacci(int.Parse(Console.ReadLine()));