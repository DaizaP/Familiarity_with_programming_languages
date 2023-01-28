// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
// Накидал пару вариантов заполнения массива.
Console.Clear();

//_________Вариант1(самый простой)_______________

Console.Write("a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("b = ");
int b = int.Parse(Console.ReadLine());
Console.Write("c = ");
int c = int.Parse(Console.ReadLine());
int max = a;
 if(a > max ) max = a;
if(b > max ) max = b;
if(c > max ) max = c;
Console.Write($"max = {max}");

//_________Вариант2___________

/*int[] array = new int[3];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите число: ");
    array[i] = int.Parse(Console.ReadLine()); //ручное заполнение
    // array[i] = i++; //автоматическое последовательное заполнение(неподходит по услувиям задачи)
    // array[i] = new Random().Next(1, 1001); // заполнение массива случайными числами(неподходит по условиям задачи)
}
Console.WriteLine($"{array[0]}, {array[1]}, {array[2]}");
int max = array.Max(); // Подсмотрел в интернете
Console.WriteLine($"Число {max} больше!");*/

//______________Вариант3____________

/*int[] array = new int[3];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите число: ");
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine($"{array[0]}, {array[1]}, {array[2]}");
int max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}
Console.WriteLine($"Число {max} больше!");*/