// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();
Console.Write("Введите числа через пробел: ");
string elements = Console.ReadLine();
int[] baseArray = GetArrayFromString(elements);
Console.Write($"[{String.Join(", ", baseArray)}] -> ");
Console.Write(CountPosNum(baseArray));

int CountPosNum(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]> 0)
    {
        count++;
    }
}
return count;
}
int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}
