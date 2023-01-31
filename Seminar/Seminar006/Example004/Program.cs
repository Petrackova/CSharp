// Фибаначи 0 1 1 2 3 5 8 

Print(9);

void Print(int a)
{
    int firstNum = 0;
    int secondNum = 1;
    if ( a == 1)
    {
    System.Console.WriteLine(firstNum);
    return;
    }
    System.Console.WriteLine(firstNum);
    System.Console.WriteLine(secondNum);
     for ( int i = 3; i<=a; i++)
     {
         int s = firstNum + secondNum;
             System.Console.WriteLine(s);
         firstNum = secondNum;
         secondNum = s;
     }
}