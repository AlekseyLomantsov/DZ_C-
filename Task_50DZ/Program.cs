// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет

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

void PrintResInput(int[,] array, int row, int col)
{
    if (array[row, col] == array.GetLength(0))
    {
        if (array[row, col] == array.GetLength(1))
        {
            Console.WriteLine($"значение на данных координатах: {array[row, col]}");
        }
    }
}

Console.WriteLine("Введите искомую строку: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомый столбец: ");
int col = Convert.ToInt32(Console.ReadLine());

int rowRndArr = 5;
int colRndArr = 4;
int minRndArr = 1;
int maxRndArr = 10;
int[,] rndArray = CreteMatrixRndInt(rowRndArr, colRndArr, minRndArr, maxRndArr);
PrintMatrix(rndArray);
if (rndArray[row, col] == rndArray[rowRndArr, colRndArr])
{
PrintResInput(rndArray, row, col);
}
else
{
    Console.WriteLine("Такого значения нет");
}