/* **Задача 33:**Задайте массив.Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.
4; массив[6, 7, 19, 345, 3]->нет
3; массив[6, 7, 19, 345, 3]->да*/
Console.Clear();

string Read(string s)
{
    (int posLeft, int posTop) = Console.GetCursorPosition();
    string textFromConsole = Console.ReadLine();
    posLeft = posLeft + textFromConsole.Length;
    Console.SetCursorPosition(posLeft, posTop);
    Console.Write($"{s}");
    return textFromConsole;
}

int[] GetArray(int size)
{
    Console.Write($"Введите {size} чисел для позиций в массиве через клавишу Enter: ");
    int[] Array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Array[i] = int.Parse(Read(" "));
    }
    Console.WriteLine(";");
    return Array;
}

void NumberCheckInArray(int[] Array, int num)
{
    Console.WriteLine(";");
    foreach (int item in Array)
    {
        if (num == item)
        {
            Console.WriteLine($"{num}; массив [{String.Join(", ", Array)}] -> да");
            return;
        }
    }
    Console.WriteLine($"{num}; массив [{String.Join(", ", Array)}] -> нет");
}
Console.Write("Введите длину массива: ");
int size = int.Parse(Read(""));
Console.WriteLine(";");
int[] Array = GetArray(size);
Console.Write("Введите проверяемое число: ");
NumberCheckInArray(Array, int.Parse(Read("")));



// Console.Clear();
// Console.Write("Введите элементы массива через пробел: ");
// string elements = Console.ReadLine();
// int[] baseArray = GetArrayFromString(elements);
// Console.Write(String.Join(", ", baseArray));
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine());
// if (FindElement(baseArray, n))
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }


// int[] GetArrayFromString(string stringArray)
// {
//     string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
//     int[] res = new int[nums.Length];

//     for (int i = 0; i < nums.Length; i++)
//     {
//         res[i] = int.Parse(nums[i]);
//     }
//     return res;
// }

// bool FindElement(int[] array, int el)//[1,2,3,4] 5
// {
//     foreach (var item in array)//
//     {
//         if (el == item) // 5 == 4
//             return true; 
//     }
//     return false;
// }