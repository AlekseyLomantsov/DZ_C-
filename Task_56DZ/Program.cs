// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int MinLineSum(int[,] array, int i)
{
    int sumElem1 = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumElem1 += array[i, j];
    }
    return sumElem1;
}




int row = 5;
int col = 4;
int min = 1;
int max = 5;

int[,] arrayRnd = CreteMatrixRndInt(row, col, min, max);
PrintMatrix(arrayRnd);
Console.WriteLine();
int result = MinLineSum(arrayRnd, 0);
int countLine = 0;
for (int i = 0; i < arrayRnd.GetLength(0); i++)
{
    int sum1line = MinLineSum(arrayRnd, i);
    // Console.WriteLine(sum1line); Оставлю для проверки
    if (sum1line < result)
    {
        result = sum1line;
        countLine = i;
    }
}
Console.WriteLine($"В строке {countLine + 1} минимальное значение {result}");


