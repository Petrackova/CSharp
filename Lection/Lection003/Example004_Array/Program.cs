// Упорядочить массив
int [] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int [] array)
{
    int count = array.Length;
    for ( int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void Sel(int [] array)
{
    for ( int i = 0; i < array.Length - 1; i++)
    {
        int min = i;

        for ( int j = i+1; j < array.Length; j++)
        {
            if (array[j] < array[min])
            {
                min = j; 
            }
        }
        int temp = array[i];
        array[i] = array[min];
        array[min] = temp;
    }
}

PrintArray(arr);
Sel(arr);
System.Console.WriteLine();
PrintArray(arr);
