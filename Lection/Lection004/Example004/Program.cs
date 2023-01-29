// See https://aka.ms/new-console-template for more information
double Fib ( int i)
{
    if ( i ==1 || i ==2) 
    {
        return i;
    }
    else
    {
       return Fib(i-1)+Fib(i-2);
    }
}
for (int i = 1; i < 50; i++)
{
System.Console.WriteLine(Fib(i));
}