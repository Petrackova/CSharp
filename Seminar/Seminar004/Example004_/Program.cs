// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

//PrintArr(Arr(8));


int[] ar = Arr(10);
PrintArr(ar);

int[] Arr(int lenght)
{
    int [] result = new int [lenght];

    for ( int i = 0; i < lenght; i++) 
    {
        result[i] = new Random().Next(0,2);
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
