// Напишите программу , которая будет создавать копию заданного массива с помощью поэлементарного копирования
int[] ar = Arr(10);
PrintArr(ar);
System.Console.WriteLine(" ");
int [] arr = Array(ar);
PrintArr(arr);


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

int[] Array ( int[]arr)
{
    int [] result =new int [arr.Length] ;
   for ( int i = 0; i < arr.Length; i++) 
    {
        result[i] = ar[i];
    }
    return result;
}