// Задача 60. Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет
// построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] CreteMatrixRndInt(int row, int col, int depth, int min, int max)
/*Работает, но если ставить max=20, иногда выходят одинаковые*/
{
    int[,,] array = new int[row, col, depth];
    Random rnd = new Random();
    int[] temp = new int[row * col * depth];

    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = rnd.Next(min, max + 1);
        for (int j = 0; j < i; j++)
        {
            while (temp[i] == temp[j])
            {
                temp[j] = rnd.Next(min, max + 1);
            }
        }
    }
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = temp[count];
                count++;
            }
        }
    }
    return array;
}

void PrintMatrix(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(2); n++)
            {

                Console.Write($"{array[i, j, n],4} ({i},{j},{n}),");
            }
            Console.WriteLine();
        }
    }
}

int row = 2;
int col = 2;
int depth = 2;
int min = 10;
int max = 99;


int[,,] matrixRnd = CreteMatrixRndInt(row, col, depth, min, max);
PrintMatrix(matrixRnd);
