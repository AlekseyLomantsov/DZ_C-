﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, 
// заполненный псевдослучайными числами и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]




int[] ArrayBin(int size)
{
    int[] array = new int[size];
    int index = 0;
    var rnd = new Random();

    while (index < array.Length)
    {
        array[index] = rnd.Next(0,99);
        index++;
    }
    return array;
}

void PrintArrey(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }

}
int[] resArray = ArrayBin(8);
PrintArrey(resArray);