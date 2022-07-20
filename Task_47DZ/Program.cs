// Задача 47. Задайте двумерный массив размером m×n,
//  заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double valueFloatRnd = new Random().NextDouble() * (max - min) + min;


double[,] CreteMatrixRndInt(int row, int col, int min, int max)
{
    double[,] array = new double[row, col];
    Random valueFloatRnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = valueFloatRnd.NextDouble() * (max - min) + min;
        }
    }
    return array;
}

void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j]:F2}, ");
            else Console.Write($"{array[i, j]:F2}  ]");   // не понимаю как вывод сделать короче
        }
        Console.WriteLine();
    }
}

int row = 3;
int col = 4;
int min = 1;
int max = 20;

double[,] arrayResult = CreteMatrixRndInt(row, col, min, max);
PrintMatrix(arrayResult);

