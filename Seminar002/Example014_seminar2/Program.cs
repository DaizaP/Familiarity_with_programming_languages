//7 и 23 число одновременно кратно
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num % 7 == 0 || num % 23 == 0) // || - условие "или" && = Условия "и"
{
    Console.WriteLine("yes");
}
else
    Console.WriteLine("no");


// if (num % 7 == 0)
// {
//     if(num % num21 == 0)
//     {
//         Console.WriteLine($"{num} -> Кратно");
//     }
//     else
//     {
//         Console.WriteLine($"{num} -> Не кратно, остаток {num % 7} и {num % 23}");
//     }
// }
// else
// {
//     Console.WriteLine($"{num} -> Не кратно, остаток {num % 7} и {num % 23}");
// }