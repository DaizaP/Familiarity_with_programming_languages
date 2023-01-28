Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "аня")
{
    Console.Write("Ура! Это же " );
    Console.WriteLine(username);
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}