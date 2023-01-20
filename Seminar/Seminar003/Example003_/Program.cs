// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
int N = new Random().Next(1,11);
Console.WriteLine(N);
Console.WriteLine("Таблица квадратов");
for (int i = 0; i <= N; i++)
{
    double sqrt = Math.Pow((i), 2);
    Console.WriteLine($"{i} ^2 = {sqrt}");
}
