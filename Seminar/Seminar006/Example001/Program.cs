// Напишите программу, которая перевернет одномерный массив ( последний элемент будет на первом месте, а первый на последнем и тд)
int[] ar = Arr(10);

int[] Arr(int lenght)
{
    int [] result = new int [lenght];

    for ( int i = 0; i < lenght; i++) 
    {
        result[i] = new Random().Next(-9,10);
    }
    return result;
}

void PrintArray(int[] arr)
{
    foreach(int item in arr)
    {
        System.Console.Write(item + " ");
    }
}
void swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

void Sel(int [] arr)
{
    int n = arr.Length;
    for ( int i = 0; i < n/2; i++)
    {
     swap(arr,i,n-i-1);
    }
}

PrintArray(ar);
Sel(ar);
System.Console.WriteLine();
PrintArray(ar);