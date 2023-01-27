//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] ar = Arr(10);
Console.WriteLine("Массив:");
PrintArr(ar);
Console.WriteLine();
Console.WriteLine($"Сумма нечетных чисел в массиве:= {SummNumber(ar)}");


int[] Arr(int lenght)
{
    int [] result = new int [lenght];

    for ( int i = 0; i < lenght; i++) 
    {
        result[i] = new Random().Next(100,1000);
    }
    return result;
}

int SummNumber (int[] arr)
{
    int summ = 0;
    for ( int i = 0; i < arr.Length; i++)
    {
        if ( (i % 2) != 0)
        {
            summ = arr[i]+summ;
        }
    }
    return summ;
}


void PrintArr(int[] arr)
{
    foreach(int item in arr)
    {
        Console.Write(item + " ");
    }
}