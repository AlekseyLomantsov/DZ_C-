// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

int[,] ChangeRow(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    int[,] swappArray = new int[row, col];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            swappArray[i, j] = array[j, i];
        }
    }
    return swappArray;
}


int row = 5;
int col = 6;
if (row == col)
{

    int min = 1;
    int max = 10;

    int[,] array = CreteMatrixRndInt(row, col, min, max);
    PrintMatrix(array);
    int[,] result = ChangeRow(array);
    Console.WriteLine();
    PrintMatrix(result);
}
else
{
    Console.WriteLine("Задайте одинаковое кол-во столбцов и сторок");

}