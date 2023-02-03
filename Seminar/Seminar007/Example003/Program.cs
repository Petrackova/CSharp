//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.


var arr = Generator2dArray(3,4);
Print2dArray(arr);
PowArray(arr);
System.Console.WriteLine();
Print2dArray(arr);

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

void PowArray(int[,] arr) 
{
   for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j< arr.GetLength(1); j++)
        { 
            if ((i % 2 == 0) && (j % 2 == 0))
            {
                arr[i,j] = (int)Math.Pow(arr[i,j],2);
            }
        }
    }
}