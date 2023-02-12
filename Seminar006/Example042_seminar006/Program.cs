// **Задача 42:**Напишите программу,
//  которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
Console.Clear();
void binarization()
{
    Console.Write("Введите число, которое будем переводить в двоичное: ");
    int num = int.Parse(Console.ReadLine());
    int i = 0;
    string result = "";
    int tmp = num;

    while (tmp > 0)
    {
        result = tmp % 2 + result;
        tmp /= 2;
        i++;
    }
    Console.Write($"{num} -> {String.Join("", result)}");
}
binarization();