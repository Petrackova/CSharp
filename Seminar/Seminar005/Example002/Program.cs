//Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
int[] ar = Arr(10);
PrintArr(ar);
Console.WriteLine("");
PrintArr(Plus(ar));


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
int[] Plus(int[] arr)
{
    for ( int i = 0; i < arr.Length; i++) 
    {
    if (arr[i] <= 0)
    {
        arr[i]= Math.Abs(arr[i]);
    }
    else
    {
    arr[i]= -arr[i];
    }
    }
    return arr;
}
