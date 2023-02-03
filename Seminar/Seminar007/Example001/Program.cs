//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//m = 3, n = 4.
//1 4 8 19
//5 -2 33 -2
//77 3 8 1
Print2dArray(Generator2dArray(3,4));

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