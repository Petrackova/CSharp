//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
int[] ar = Arr(10);
Console.WriteLine(a);
PrintArr(ar);
Console.WriteLine(FindNum(ar,a));


int[] Arr(int lenght)
{
    int [] result = new int [lenght];

    for ( int i = 0; i < lenght; i++) 
    {
        result[i] = new Random().Next(0,10);
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

bool FindNum (int[] arr, int num)
{
    for ( int i = 0; i < arr.Length; i++) 
    {
        if (arr[i] == num)
        {
            return true;
        }
    }
    return false;
}
