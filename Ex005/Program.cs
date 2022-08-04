Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "катя")
{
    Console.WriteLine("Да здавствует Катя!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}