// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


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

int[] FromMatrixToArray(int[,] array)
{
    int[] result = new int[array.GetLength(0) * array.GetLength(1)];
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[count] = array[i, j];
            count++;
        }
    }
    return result;
}

void PrintArray(int[] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[,] Dictionary(int[] array)
{
    int amountOfColumns = array.Distinct().ToArray().Length;
    int[,] result = new int[2,amountOfColumns];
    int currentElem =array[0];
    int counter =1;
    for (int i = 0; i < result.Length; i++)
    {
        result[0,i] = array.Distinct().ToArray()[i];

        if (currentElem== array[i])
        { 
            counter++;
            currentElem=array[i];
        }
        else 
        {
            currentElem = array[i];
        }
    }
   
return result;
}

int rowRndArr = 5;
int colRndArr = 4;
int minRndArr = 1;
int maxRndArr = 10;

int[,] arrayRnd = CreteMatrixRndInt(rowRndArr, colRndArr, minRndArr, maxRndArr);
PrintMatrix(arrayRnd);
int[] result = FromMatrixToArray(arrayRnd);
Array.Sort(result);
Console.WriteLine();
PrintArray(result);