// // Задача 62. Заполните спирально массив 4 на 4.
// // Например, на выходе получается вот такой массив:

// // 01 02 03 04
// // 12 13 14 05
// // 11 16 15 06
// // 10 09 08 07

int[,] CreteMatrix(int row, int col)
{
    int[,] array = new int[row, col];

    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j] + 1;
            array[i, j] = sum;
            // Console.Write(sum);
        }
    }
    return array;
}

void PrintMatrixSpiral(int[,] array,int row,int col)
{
    // частично подсмотрел в интернете. Тяжело пока такое сообразить.
 int iMove = 0, iSide = 0, jMove = 0, jSide = 0;
  int stopline = 1;
    int i = 0;
    int j = 0;
    
    while (stopline <= row * col)
    {
        array[i, j] = stopline;
        if (i == iMove && j < col - jSide - 1)
            ++j;
        else if (j == col - jSide - 1 && i < row - iSide - 1)
            ++i;
        else if (i == row - iSide - 1 && j > jMove)
            --j;
        else
            --i;

        if ((i == iMove + 1) && (j == jMove) && (jMove != col - jSide - 1))
        {
            ++iMove;
            ++iSide;
            ++jMove;
            ++jSide;
        }
        ++stopline;
    }
    {
    for (int l = 0; l < array.GetLength(0); l++)
    {
        Console.Write("[ ");
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[l, n], 3}");
        }
        Console.Write("] ");
        Console.WriteLine("");
    }
}
}

int row = 4;
int col = 4;

int[,] matrix = CreteMatrix(row, col);

PrintMatrixSpiral(matrix,row,col);



