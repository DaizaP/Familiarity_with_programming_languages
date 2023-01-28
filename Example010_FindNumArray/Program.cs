Console.Clear();

int[] array = new int[100];
for (int i = 0; i <= 99; i++)
{
    //array[i] = Convert.ToInt32(Console.ReadLine()); //ручное заполнение
    array[i] = i - 134; //автоматическое последовательное заполнение
    //array[i] = new Random().Next(1, 1001); // заполнение массива случайными числами
    Console.Write($"{array[i]}, ");
}
Console.WriteLine(" ");
int n = array.Length;
Console.WriteLine("Ведите искомое число");
int find = int.Parse(Console.ReadLine());
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine($"Мы нашли число {find}, его номер в массиве {index}");
    }
    index++;
}
Console.WriteLine($"Числа {find} нет в массиве.");