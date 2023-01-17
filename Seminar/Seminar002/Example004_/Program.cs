//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
Console.WriteLine("Введите числ0");
int number1 = Convert.ToInt32(Console.ReadLine());
if ((number1%7==0)&(number1%23==0))
{
    Console.WriteLine("Кратно");
    }
else 
{
    Console.WriteLine("Не кратно ");
}
