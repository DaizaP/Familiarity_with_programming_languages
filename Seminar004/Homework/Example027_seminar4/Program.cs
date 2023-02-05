// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
//Без преобразования в строку. Работать только с числами через метод.
int sum(int num)
{
    num = Math.Abs(num);
    int tmp = 0;
    int count = num;
    int result = 0;
    for (int rotd = 10, div = 1; count > 0; rotd *= 10, div *= 10)
    {
        tmp = (num % rotd) / div;
        result = result + tmp;
        count /= 10;
    }
    return result;
}

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.Write($"{n} -> {sum(n)}");