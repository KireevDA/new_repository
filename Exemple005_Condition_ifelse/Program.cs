Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "наташа")
{
    Console.WriteLine("Ура, это же ты, Наташа!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}