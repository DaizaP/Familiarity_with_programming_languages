// Задача 35:Задайте одномерный массив из 123 случайных чисел [0: 1000].
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2]-> 0
// [10, 11, 12, 13, 14]-> 5
Console.Clear();

int[] array = GetRandomArray123Length();
AnswerArray(array);
Console.Write($"{FindElementFrom10To99InArray123(array)};");















int[] GetRandomArray123Length()
{
    int[] result = new int[123];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(0, 1000 + 1);
    }
    return result;
}
int FindElementFrom10To99InArray123(int[] array)
{
    int Element = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0 && array[i] <= 99)
            Element++;
    }
    return Element;
}
void AnswerArray(int[] array)// Захотелось в таком виде вывести
{
    Console.Write("Вывести полностью массив? (Y/N): ");
    string choice = Console.ReadLine();
    string choice1 = choice.ToLower();
    switch (choice1)
    {
        case "y":
            Console.Write($"[{String.Join(", ", array)}] -> ");
            break;
        case "n":
            if (5 >= array.Length)// При выполнении кода все работает корректно, если менять длинну массива. Спросить у преподавателя завтра, почему значение true конструкции if, которая находится в switch case, превращается в false
            {
            Console.WriteLine($"Длина массива <= 5. Массив будет выведен полностью;");
            goto case "y";
            }
            else
            {
            Console.Write($"[{array[0]}, {array[1]}, ..., {array[^3]}, {array[^2]}, {array[^1]}] -> ");
            break; 
            }
        default:
            Console.WriteLine("Некорректное значение. Вывод массива пропущен.");
            break;
    }
}