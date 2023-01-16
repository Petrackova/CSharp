// Является ли число квадратом числа
Console.WriteLine("Введите числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = number2*number2;
// int a = int.Parse(Console.Readline());
if (number3==number1)
{
    Console.WriteLine("Да! Всё верно число является квадратом");
    }
else 
{
    Console.WriteLine("Увы! Число не является квадратом ");
}
// System.Console.WriteLine();