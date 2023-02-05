// Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо, если K – положительное и влево, если отрицательное.
Console.Clear();
string[] Allline = File.ReadAllLines("INPUT.txt");
Console.WriteLine($"{Allline[1]}, {Allline[2]}, {Allline[3]},   {Allline[5]}, {Allline[6]}, {Allline[7]}, ");
int N = int.Parse(Allline[1]);
string Line2 = new string(Allline[2]);
Console.Write("Введите номер строки, которая отвечает за сдвиг массива (3 или 7): ");
int K = int.Parse(Allline[int.Parse(Console.ReadLine())]);
string[] Array = new string[Line2.Length];
for (int i = 0; i < Line2.Length; i++)
{
    Array[i] = Convert.ToString(Line2[i]);
}
if (K > 0)
{
    for (int i = 0; i < K; i++)
    {
        string aLast = Array[N - 1];
        for (int j = N - 1; j > 0; j--)
        {
            Array[j] = Array[j - 1];
        }
        Array[0] = aLast;
    }
    Console.Write("Новый массив: ");
}
else
{
    K = Math.Abs(K);
    for (int i = 0; i < K; i++)
    {
        string aLast = Array[0];
        for (int j = 0; j < N-1; j++)
        {
            Array[j] = Array[j + 1];
        }
        Array[N-1] = aLast;
    }
    Console.Write("Новый массив: ");
}
Console.WriteLine($"{Array[0]} {Array[1]} {Array[2]} {Array[3]} {Array[4]} ");
string path = ("OUTPUT.txt");
string[] createText = {$"{Array[0]} {Array[1]} {Array[2]} {Array[3]} {Array[4]} "};
File.WriteAllLines(path, createText);
Console.Write("Значение нового массива записано в файл OUTPUT.txt");
/*Int64 i;
try
{
    StreamWriter sw = new StreamWriter("C:\\Users\\Дмитрий\\Desktop\\Обучение\\Знакомство с языками программирования\\Seminar003\\Homework\\Extra_Homework_Example\\OUTPUT.txt", true, System.Text.Encoding.ASCII);
    for (i = 0; i < 9; i++)
    {
        sw.Write($"{i}");
    }
    sw.Close();
}
catch (Exception e)
{
    Console.WriteLine("Exception: " + e.Message);
}
finally
{
    Console.WriteLine("Executing finally block.");
}*/