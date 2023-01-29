// двумерные массивы
/*string[,] table = new string[2, 5];
table[1, 2] = "слово";
for ( int rows = 0; rows < 2; rows++)
{
    for ( int coluns = 0; coluns < 5; coluns++)
    {
        System.Console.Write($"-{table[rows, coluns]}- ");
    }
}
*/

void PrintArray(int [,] matrix)
{
for ( int i = 0; i < matrix.GetLength(0); i++)
{
    for ( int j = 0; j < matrix.GetLength(1); j++)
    {
        System.Console.Write($"{matrix[i, j]} ");
    }
    System.Console.WriteLine();
}
}
void FillArray(int [,] matrix)
{
    for ( int i = 0; i < matrix.GetLength(0); i++)
    {
        for ( int j = 0; j < matrix.GetLength(1); j++)
        {
        matrix[i,j] = new Random().Next(1,10);
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
System.Console.WriteLine();
PrintArray(matrix);