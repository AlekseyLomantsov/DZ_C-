// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

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
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j], 3},");
            else Console.Write($"{array[i, j], 3}  ]");
        }
        Console.WriteLine();
    }
}

int ResultMatrix(int[,] array)
{
    int sumMatrixDiag = 0;
    int index = array.GetLength(0)>array.GetLength(1) ? 1 : 0;
    for (int i = 0; i < array.GetLength(index); i++)
    {
        sumMatrixDiag += array[i,i];
    }
    return sumMatrixDiag;
}


int[,] rndArray =CreteMatrixRndInt(5,4,1,10);
PrintMatrix(rndArray);
int result = ResultMatrix(rndArray);

Console.WriteLine($"Сумма элементов, находящихся на главной диагонали = {result}");