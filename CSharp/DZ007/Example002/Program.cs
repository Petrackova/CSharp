/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
System.Console.Write("Значение m:= ");
int b1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Значение n:= ");
int k1 = Convert.ToInt32(Console.ReadLine());
int[,] ar = FindArr(b1,k1);

System.Console.Write("Значение N:= ");
int N = Convert.ToInt32(Console.ReadLine());
PrintArr(ar);
System.Console.WriteLine(Indexof(ar,N));

int[,] FindArr(int lenghti, int lenghtj)
{
    int [,] result = new int [lenghti,lenghtj];
    for ( int i = 0; i < lenghti; i++) 
    {
        for ( int j = 0; j < lenghtj; j++) 
    {
        result[i,j] = new Random().Next(1,10);
    }
}
return result;
}

void PrintArr(int [,] arr)
{
for ( int i = 0; i < arr.GetLength(0); i++)
{
    for ( int j = 0; j < arr.GetLength(1); j++)
    {
        System.Console.Write($"{arr[i, j]} ");
    }
    System.Console.WriteLine();
}
}

int Indexof(int[,] arr, int find)
{
    for ( int i = 0; i < arr.GetLength(0); i++) 
    {
        for ( int j = 0; j < arr.GetLength(1); j++) 
        {
            if(arr[i,j]==find)
            {
                return find;
            }
        }
    }
    System.Console.Write("Такого числа нет");
    return 0;
}
