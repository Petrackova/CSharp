//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Сумма элементов главной диагонали: 1+9+2 = 12
// https://metanit.com/sharp/tutorial/2.16.php

var arr = Generator2dArray(3,4);
Print2dArray(arr);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма элементов по диагонали:= {SummArray(arr)}");

int[,] Generator2dArray( int a, int b)
{
    int[,] result = new int [a,b];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j< result.GetLength(1); j++)
        {
            result[i,j] = new Random().Next(0,100);
        }
    }
    return result;
}

void Print2dArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j< arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i,j]} ");
        }
        System.Console.WriteLine(" ");
    }
}

int SummArray(int[,] arr) 
{
    int s = 0;
    // int lenght = arr.GetLength(0) < arr.GetLength(1) ? arr.GetLength(0) : arr.GetLength(1);
    //for (int i = 0; i < arr.GetLength(0); i++)
    //{
        // s = s + arr[i,i];
    //}
    // return s;
    //}

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j< arr.GetLength(1); j++)
        { 
            if (i ==j)
            {
               s = s + arr[i,j];
            }
        }
    }
    return s;
}
