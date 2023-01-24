// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int A ( int arg1)
{
    int result = 0;
    for (int i = 0; i <= arg1; i++)
    {
        result = result + i;
    }
    return result;
}
int number1 = new Random().Next(1,10);
System.Console.WriteLine(number1);
System.Console.WriteLine(A(number1));
