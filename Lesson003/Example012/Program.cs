Console.Clear();
void method1()
{
    Console.Write("Автор....");
}
// 
void method2(string msg)
{
    Console.Write(msg);
}
//
void method3(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.Write(msg);
        i++;
    }
}
method1();
method2("Word");
method3(count: 3, msg: "|");
// 
int method4()
{
    return DateTime.Now.Minute;
}
int Minute = method4();
Console.Write(Minute);
//
string method5(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = method5(10, "|/");
Console.WriteLine(res);

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j < 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine("");
// }
int[] arr = { 1, 5, 8, 0, 3, 7, 9, 0, 4, 2, 3 };

void SelectionSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minPosition])
            {
                minPosition = j;
            }
        }
        int temporary = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = temporary;
    }
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
void ExtentedSelectionSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minPosition])
            {
                minPosition = j;
            }
        }
        int temporary = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = temporary;
    }
    Array.Reverse(arr);
}
ExtentedSelectionSort(arr);
PrintArray(arr);