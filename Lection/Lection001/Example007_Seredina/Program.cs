int XA = 40; 
int YA = 1;
int XB = 1; 
int YB = 30;
int XC = 80; 
int YC = 30;

Console.SetCursorPosition(XA, YA);
Console.WriteLine("+");
Console.SetCursorPosition(XB, YB);
Console.WriteLine("+");
Console.SetCursorPosition(XC, YC);
Console.WriteLine("+");

int x = XA, y = XB;
int count = 0;
while (count < 10000)
{
    int What = new Random().Next(0, 3);
    if (What == 0)
    {
        x = (x + XA) / 2;
        y = (y + YA) / 2;
    }

    if (What == 1)
    {
        x = (x + XB) / 2;
        y = (y + YB) / 2;
    }

    if (What == 2)
    {
        x = (x + XC) / 2;
        y = (y + YC) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}