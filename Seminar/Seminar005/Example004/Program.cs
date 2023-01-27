// Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
int[] ar = Arr(123);
PrintArr(ar);
Console.WriteLine(FindNum(ar));

int[] Arr(int lenght)
{
    int [] result = new int [lenght];

    for ( int i = 0; i < lenght; i++) 
    {
        result[i] = new Random().Next(0,1000);
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

int FindNum (int[] arr)
{
    int a = 0;
    for ( int i = 0; i < arr.Length; i++) 
    {
        if ((arr[i] > 10) && (arr[i] < 99))
        {
            a++;
        }
    }
    return a;
}
