// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int S (int arg1)
{
    int result = 0;
        while (arg1>0)
        {
        arg1 = arg1 / 10;
        result = result + 1;
        }
        
    return result;
}


int a1 = new Random().Next(1,100000000);
Console.WriteLine(a1);
Console.WriteLine(S(a1));