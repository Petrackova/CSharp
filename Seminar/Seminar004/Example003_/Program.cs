// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int A ( int arg1)
{
    int result = 1;
    for (int i = 1; i <= arg1; i++)
    {
        result = result * i;
    }
    return result;
}
int number1 = new Random().Next(1,10);
System.Console.WriteLine(number1);
System.Console.WriteLine(A(number1));

