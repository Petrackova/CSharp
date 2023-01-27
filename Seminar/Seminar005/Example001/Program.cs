//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
int[] ar = Arr(13);
PrintArr(ar);
Console.WriteLine();
Console.WriteLine(SummPlus(ar));
Console.WriteLine(SummMinus(ar));

int[] Arr(int lenght)
{
    int [] result = new int [lenght];

    for ( int i = 0; i < lenght; i++) 
    {
        result[i] = new Random().Next(-9,10);
    }
    return result;
}

void PrintArr(int[] arr)
{
    foreach(int item in arr)
    {
        System.Console.Write(item + " ");
    }
}
int SummPlus(int[] arr)
{
    int a = 0;
    for ( int i = 0; i < arr.Length; i++) 
    {
    if (arr[i] >= 0)
    {
        a = a + arr[i];
    }
    }
    return a;
}

int SummMinus(int[] arr)
{
    int a = 0;
    for ( int i = 0; i < arr.Length; i++) 
    {
    if (arr[i] <= 0)
    {
        a = a + arr[i];
    }
    }
    return a;
}
