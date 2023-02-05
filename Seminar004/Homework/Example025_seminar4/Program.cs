// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Через методы
// Без MAth.Pow() в первой задаче

string Read()// Очень хотелось все в одной строчке написать, но не нашел аналога "Console.ReadLine()", только без переноса строки. Написал свой. Вроде работает. По сути, вместо переноса строки ставит пробел.
{
    (int posLeft, int posTop) = Console.GetCursorPosition();
    string textFromConsole = Console.ReadLine();
    posLeft = posLeft + textFromConsole.Length + 1;
    Console.SetCursorPosition(posLeft, posTop);
    return textFromConsole;
}

int exp(int num1, int num2)
{
    int multiply = 1;
    for (int i = 1; i <= Math.Abs(num2); i++)
    {
        multiply *= num1;
    }
    return multiply;
}
Console.Clear();
Console.Write("Введите число A и B: ");
int A = int.Parse(Read());
int B = int.Parse(Console.ReadLine());
Console.Write($"{A}, {B} -> {exp(A, B)}");
