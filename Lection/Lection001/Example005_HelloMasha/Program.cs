Console.WriteLine("Введите Имя пользователя");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
Console.WriteLine("Привет! Это же МАША!");
}
else {
Console.Write("Привет,");
Console.WriteLine(username);
}