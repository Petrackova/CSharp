int [] Array = {1432, 77, 3345, 4, 565, 3, 77, 8234};
int n = Array.Length;
int find =77;
int index = 0;
while (index< n)
{
    if (Array[index] == find)
    {
    Console.WriteLine(index);
    break;
    }
    index++;
}

