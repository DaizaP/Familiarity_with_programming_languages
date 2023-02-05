// **Задача 18:**

// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)
Console.Clear();
Console.WriteLine("Для выхода из программы наберите 'quit'");
Console.WriteLine("Введите номер четверти плоскости: ");
string number = Console.ReadLine();
number = number.ToLowerInvariant();
Console.WriteLine($"Вы ввели: {number}"); // проверка успешного преобразования строки. Необязательна

// while (number != "quit")
// {
//     if (number == "1" || number == "i")
//     {
//         Console.WriteLine("Диапазон возможных координат: X > 0; Y > 0");
//     }
//     else if (number == "2" || number == "ii")
//     {
//         Console.WriteLine("Диапазон возможных координат: X < 0; Y > 0");
//     }
//     else if (number == "3" || number == "iii")
//     {
//         Console.WriteLine("Диапазон возможных координат: X < 0; Y < 0");
//     }
//     else if (number == "4" || number == "iv")
//     {
//         Console.WriteLine("Диапазон возможных координат: X > 0; Y < 0");
//     }
//     else
//     {
//         Console.WriteLine("Это не номер четверти! Введите повторно НОМЕР четверти плоскости: ");
//     }
//     number = Console.ReadLine();
//     number = number.ToLowerInvariant();
//     Console.WriteLine($"Вы ввели: {number}"); //проверка преобразования строки
// }
while (number != "quit")
{
    switch (number)
    {
        case "1":
            Console.WriteLine("Диапазон возможных координат: X > 0; Y > 0");
            break;
        case "2":
            Console.WriteLine("Диапазон возможных координат: X < 0; Y > 0");
            break;
        case "3":
            Console.WriteLine("Диапазон возможных координат: X < 0; Y < 0");
            break;
        case "4":
            Console.WriteLine("Диапазон возможных координат: X > 0; Y < 0");
            break;
        case "i":
            Console.WriteLine("Диапазон возможных координат: X > 0; Y > 0");
            break;
        case "ii":
            Console.WriteLine("Диапазон возможных координат: X < 0; Y > 0");
            break;
        case "iii":
            Console.WriteLine("Диапазон возможных координат: X < 0; Y < 0");
            break;
        case "iv":
            Console.WriteLine("Диапазон возможных координат: X > 0; Y < 0");
            break;
        default:
            Console.WriteLine("Это не номер четверти! Введите повторно НОМЕР четверти плоскости: ");
            break;
    }
    number = Console.ReadLine();
    number = number.ToLowerInvariant();
    Console.WriteLine($"Вы ввели: {number}");
}