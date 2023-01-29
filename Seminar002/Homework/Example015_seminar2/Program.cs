// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// Я тут решил попрактиковаться и всяких условий добавил. 
Console.Clear();
Console.WriteLine("Проверка цифры дня недели на выходной. Чтобы выйти из программы, наберите '-1'");
Console.Write("Введите день недели: ");
int day = int.Parse(Console.ReadLine());
while (day != -1)
{
    if (day != 6 && day != 7)
    {
        if (day > 7 || day < 1)
        {
            Console.WriteLine($"{day} -> Нет.");
            Console.WriteLine("P.S. В мире только 7 дней недели.");
            Console.Write("Введите правильный номер дня недели: ");
            day = int.Parse(Console.ReadLine());
        }
        else
        {
            Console.WriteLine($"{day} -> Нет");
            Console.Write("Введите день недели: ");
            day = int.Parse(Console.ReadLine());
        }
    }
    else
    {
        Console.WriteLine($"{day} -> Да");
        Console.WriteLine("Если хотите завершить программу, наберите '-1': ");
        day = int.Parse(Console.ReadLine());
    }
}
Console.Write("Вы завершили программу");

// -------------Стандартный вариант.
/* 
Console.Clear();
Console.Write("Введите день недели: ");
int day = int.Parse(Console.ReadLine());
while (day != 6 && day != 7)
{
    Console.WriteLine($"{day} -> Нет");
    Console.Write("Введите день недели: ");
    day = int.Parse(Console.ReadLine());
}
Console.Write($"{day} -> Да"); */