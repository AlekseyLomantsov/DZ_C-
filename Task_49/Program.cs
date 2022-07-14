// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
//  квадраты.

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
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j], 3}  ,");
            else Console.Write($"{array[i, j], 3}  ]");
        }
        Console.WriteLine();
    }
}

int[,] matrixResult(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i+=2)
    {
        for (int j = 0; j < array.GetLength(1); j+=2)
        {
            
                array[i, j] *= array[i, j];
            
        }
    }
    return array;
}

int[,] rndArray =CreteMatrixRndInt(3,4,1,10);
PrintMatrix(rndArray);
Console.WriteLine();
int[,] result =matrixResult(rndArray);
PrintMatrix(result);