//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
int[] ar = Arr(10);
PrintArr(ar);
Console.WriteLine("");
int[] newArr = Find(ar);
PrintArr(newArr);

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

int[] Find(int[] arr)
{
    int newSize = arr.Length / 2;

    if ( arr.Length % 2 == 1)
    {
        newSize++;
    }

    int [] result = new int[newSize];
    
    for ( int i = 0; i < arr.Length /2; i++)
    {
        result[i] = arr[i]* arr[arr.Length - 1 - i];
    }

    if ( arr.Length % 2 == 1)
    {
        result[newSize-1] = arr[arr.Length/2];
    }
    return result;
}