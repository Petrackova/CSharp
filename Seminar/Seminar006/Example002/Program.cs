// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольниу с сторонами такой длины.( Теорема о неравенстве треугольника)
int a1 = new Random().Next(1,100);
int b1 = new Random().Next(1,100);
int c1 = new Random().Next(1,100);
Console.WriteLine($"Длина стороны а1:= {a1}");
Console.WriteLine($"Длина стороны b1:= {b1}");
Console.WriteLine($"Длина стороны c1:= {c1}");
Console.WriteLine($"{FindSumm(a1,b1,c1)}");
  
bool FindSumm (int a1, int b1, int c1)
{
return ((a1< (b1+c1))&&( b1<(a1+c1))&&( c1<(b1+a1)));
}
