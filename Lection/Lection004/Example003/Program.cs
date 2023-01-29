// See https://aka.ms/new-console-template for more information
double Fact ( int a)
{
    if ( a == 1)
    {
        return 1;
    }
    else
    {
        return a * Fact(a-1);
    }
}
for ( int i = 1; i < 40; i++)
{
System.Console.WriteLine($"{i}! = {Fact(i)}");
}