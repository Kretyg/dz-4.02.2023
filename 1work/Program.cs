// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива

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
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1) - j - 1; k++)
            {
                if (matr[i, k] < matr[i, k + 1])
                {
                    int t = matr[i, k];
                    matr[i, k] = matr[i, k + 1];
                    matr[i, k + 1] = t;
                }
            }
        }
    }
}

int[,] matrix = new int[5, 5];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Ordering(matrix);
PrintArray(matrix);
