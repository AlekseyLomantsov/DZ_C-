// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.


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

void ChangeRow(int[,] array)
{
    int idx1 = 0;
    int idx2 = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int row = array[idx1, i];
        array[idx1, i] = array[idx2, i];
        array[idx2, i] = row;
    }
}

int row = 5;
int col = 4;
int min = 1;
int max = 10;

int[,] array = CreteMatrixRndInt(row, col, min, max);
PrintMatrix(array);
ChangeRow(array);
Console.WriteLine();
PrintMatrix(array);