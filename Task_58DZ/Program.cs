// Задача 58: Задайте две матрицы. Напишите программу,
//  которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// C=  (1 2)*(5 6) = (1*5+2*7  1*6+2*8)  = (19 22)
//     (​3 4​)*(​7 8​) = (3*5+4*7  3*7+4*8)  = (43 50)


int[,] CreteMatrixRndInt(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3},");
            else Console.Write($"{array[i, j],3}  ]");
        }
        Console.WriteLine();
    }
}

int[,] ProductMatrix(int[,] arrayFirst, int[,] arraySecond, int row, int col)
{
    int[,] resultMatrix = new int[row, col];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int produkt = 0;

            for (int n = 0; n < arrayFirst.GetLength(0); n++)
            {
                produkt = produkt + arrayFirst[i, n] * arraySecond[n, j];
            }
            resultMatrix[i,j] = produkt;
        }
    }
    return resultMatrix;
}


int row = 2;
int col = 2;
int min = 1;
int max = 5;

int[,] arrayFirst = CreteMatrixRndInt(row, col, min, max);
PrintMatrix(arrayFirst);
Console.WriteLine();
int[,] arraySecond = CreteMatrixRndInt(row, col, min, max);
PrintMatrix(arraySecond);
Console.WriteLine();
int[,] resultMatrix = ProductMatrix(arrayFirst, arraySecond, row, col);
Console.WriteLine("Произведение матриц:");
PrintMatrix(resultMatrix);
