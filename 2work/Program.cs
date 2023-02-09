
//Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить,
//что это невозможно (в случае, если матрица не квадратная)

 int[,] array = new int[5, 5];

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Ordering(int[,] matr)
{
    if (matr.GetLength(0) == matr.GetLength(1))
    {
        int[,] nums = new int[matr.GetLength(0), matr.GetLength(1)];
        for (int m = 0; m < matr.GetLength(0); m++)
        {
            for (int n = 0; n < matr.GetLength(1); n++)
            {
                nums[m, n] = matr[m, n];
            }
        }
        for (int m = 0; m < matr.GetLength(0); m++)
        {
            for (int n = 0; n < matr.GetLength(1); n++)
            {
                matr[m, n] = nums[n, m];
            }
        }
    }
    else
    {
        Console.WriteLine("Матрица не квадратная");
    }
}
int[,] matrix = new int[5, 5];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Ordering(matrix);
PrintArray(matrix);