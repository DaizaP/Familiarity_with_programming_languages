//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
Console.Clear();

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}
int[] Array = GetRandomArray(12, -9, 10);
Console.WriteLine($"[{String.Join(", ", Array)}]");
int SumNegative = 0;
int SumPositive = 0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i] > 0)
    {
        SumPositive += Array[i];
    }
    else
    {
        SumNegative += Array[i];
    }
}

Console.WriteLine($"Сумма отрицательных чисел: {SumNegative}. Сумма положительных чисел: {SumPositive}");



// Console.Clear();

// int[] GetRandomArray(int size,int minValue,int maxValue){  
//       int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//         result[i] = new Random().Next(minValue,maxValue+1);
//     return result;
//     }
// int [] A = GetRandomArray(12, -9, 10);
// Console.WriteLine($"[{String.Join(", ", A)}]");
// int neg=0, pos=0;
// for (int i=0; i<12; i++) {
//     if (A[i]<0) 
//         neg+=1;
//     else if (A[i]>0) 
//         pos+=1;
//     }
// Console.WriteLine($"+: {pos}");
// Console.WriteLine($"-: {neg}");