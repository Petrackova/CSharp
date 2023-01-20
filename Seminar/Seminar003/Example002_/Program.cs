//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21
Random rnd = new Random();
Console.WriteLine("Введите координаты точки A");
int XA = rnd.Next(1,11);
int YA = rnd.Next(1,11);
Console.WriteLine($"Кородинаты точки A: {XA} {YA}");
Console.WriteLine("Введите координаты точки B");
int XB = rnd.Next(1,11);
int YB = rnd.Next(1,11);
Console.WriteLine($"Кородинаты точки B: {XB} {YB}");
double x = Math.Pow((XB - XA), 2);
double y = Math.Pow((YB - YA), 2);
double AB = Math.Sqrt(x + y);
Console.WriteLine($"Расстояние между точками: {AB}");
