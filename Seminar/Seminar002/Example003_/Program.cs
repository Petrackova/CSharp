//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит отстаток от деления
Console.WriteLine("Введите числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1%number2 == 0)
{
    Console.WriteLine("Кратно");
    }
else 
{
    Console.WriteLine("Не кратно " + number1%number2);
}
