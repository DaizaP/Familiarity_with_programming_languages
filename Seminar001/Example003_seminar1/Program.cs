Console.Clear();
Console.Write("Введите день недели:");
int day = int.Parse(Console.ReadLine());
if(day == 1)
{
    Console.Write("Понедельник");
}
else if(day == 2)
{
    Console.Write("Вторник");
}
else if(day == 3)
{
    Console.Write("Среда");
}
else if(day == 4)
{
    Console.Write("Четверг");
}
else if(day == 5)
{
    Console.Write("Пятница");
}
else if(day == 6)
{
    Console.Write("Суббота");
}
else if(day == 7)
{
    Console.Write("Воскресенье");
}
else
{
    Console.Write("Это не день недели");
}
// return 
//if(day == 1)
//{
//    Console.Write("Понедельник");
//}
//    return;