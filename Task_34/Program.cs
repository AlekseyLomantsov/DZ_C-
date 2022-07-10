// Задача 34: Задайте массив заполненный случайными положительными
//  трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] CreteArreyRndInt(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(99, 1000);
    }
    return array;
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

int SearchElem(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (0 == array[i] % 2) count++;
    }
    return count;
}

void PrintRes(int res)
{
    Console.WriteLine($"Четных чисел в массиве {res}");
}

int[] newArr = CreteArreyRndInt(5);//{345, 897, 568, 234};
PrintArray(newArr);
int result = SearchElem(newArr);
PrintRes(result);