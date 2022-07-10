﻿// Задача 31: 
// 1.Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// 2.Найдите сумму отрицательных и положительных элементов массива.
// 3. Вывод данных.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.

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
    int sumNeg = 0;
    int sumPos = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sumNeg += array[i];
        }
        else
        {
            sumPos += array[i];
        }
    }
    return new[] { sumNeg, sumPos };
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

void PrintSumNegPosElem(int[] sum)
{
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел = {sum[1]}");
Console.WriteLine($"Сумма отрицательных чисел = {sum[0]}");
}

int[] resArray = CreteArreyRndInt(12, -9, 9);
PrintArray(resArray);
int[] sumNegPosElem = GetSumNegPosElem(resArray);
PrintSumNegPosElem(sumNegPosElem);

// Console.WriteLine();
// Console.WriteLine($"Сумма положительных чисел = {sumNegPosElem[1]}");
// Console.WriteLine($"Сумма отрицательных чисел = {sumNegPosElem[0]}");
