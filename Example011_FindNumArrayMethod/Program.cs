Console.Clear();

void RandomNumberArray(int [] value_RandomNumberArray)
{
   int length = value_RandomNumberArray.Length;
   int index = 0;
   while (index < length)
   {
        value_RandomNumberArray[index] = new Random().Next(1, 11);
        index++;
   }
}
void PrintArray(int[] value_PrintArray)
{
    int count = value_PrintArray.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{value_PrintArray[position]}, ");
        position++;
    }
    Console.WriteLine();
}
int Indexof(int[] value_RandomNumberArray, int find)
{
    int count = value_RandomNumberArray.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (value_RandomNumberArray[index] == find)
        {
            position = index;
            Console.WriteLine($"Мы нашли число {find}, его номер в массиве {position}");
            break;
        }
        index++;
    }
return position;
}

int[] array = new int[10];
RandomNumberArray(array);
PrintArray(array);
Console.WriteLine("Введите искомое число:");
int pos = Indexof(array, int.Parse(Console.ReadLine()));
// Задай вопрос почему -1 не выводится, не могу понять почему