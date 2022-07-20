// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



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
void PrintSredArifCol(int[,] array, int row)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sumMatrixCol = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumMatrixCol += array[i, j];
        }
        sumMatrixCol = sumMatrixCol / row;
        Console.Write($"{sumMatrixCol}; ");
    }
}

int row = 5;
int col = 4;
int min = 1;
int max = 10;

int[,] rndArray = CreteMatrixRndInt(row, col, min, max);
PrintMatrix(rndArray);
PrintSredArifCol(rndArray, row);

