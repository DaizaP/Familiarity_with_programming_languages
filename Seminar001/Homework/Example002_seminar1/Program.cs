// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Clear();

// ________Вариант1________

Console.WriteLine("Ведите число a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите число b");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);
}
// От себя добавил пару вариантов исполнения

//____________Вариант2___________

/* Console.WriteLine("Ведите число a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите число b");
int b = int.Parse(Console.ReadLine());
if (a == b)
{
    Console.WriteLine("Эти числа равны!");
}
else
{
    if (a > b)
    {
        if (a >= b * 2)
        {
            Console.WriteLine($"Число {a} больше, как минимум в два раза!");
        }
        else
        {
            Console.WriteLine($"Число {a} больше");
        }
    }
    else
    {
        if (b >= a * 2)
        {
            Console.WriteLine($"Число {b} больше, как минимум в два раза!");
        }
        else
        {
            Console.WriteLine($"Число {b} больше");
        }
    }
} */

// ____________Вариант3(Метод)___________

/* void Comparrison(int a, int b)
{
    if (a == b)
    {
        Console.WriteLine("Эти числа равны!");
    }
    else
    {
        if (a > b)
        {
            if (a >= b * 2)
            {
                Console.WriteLine($"Число {a} больше, как минимум в два раза!");
            }
            else
            {
                Console.WriteLine($"Число {a} больше");
            }
        }
        else
        {
            if (b >= a * 2)
            {
                Console.WriteLine($"Число {b} больше, как минимум в два раза!");
            }
            else
            {
                Console.WriteLine($"Число {b} больше");
            }
        }
    }
}

Console.WriteLine("Ведите сначала число a, потом число b");
Comparrison(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())); */