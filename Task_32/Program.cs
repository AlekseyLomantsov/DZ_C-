// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] CreteArreyRndInt(int size, int begin, int end)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(begin, end + 1);
    }
    return array;
}

int[] GetSumNegPosElem(int[] array)
{
    int[] sumNeg = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
            sumNeg[i] = array[i] * -1;  
    }
    return sumNeg;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}
Console.Write("Введите размер массива: ");
int insize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] resArray = CreteArreyRndInt(insize, min, max);
PrintArray(resArray);
int[] SumNegPosElem = GetSumNegPosElem(resArray);
Console.Write(" -> ");
PrintArray(SumNegPosElem);
