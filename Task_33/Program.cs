// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}

bool SearchElem(int[] array, int elem) 
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == elem) return true;
    }
    return false;
}

void PrintRes(bool result, int element)
{
    string res = result ? $"Да, цифра {element} есть в этом массиве": $"Нет, цифры {element} нет в этом массиве";
    Console.WriteLine(res);
}

int[] result = CreteArreyRndInt(5, -6, 9);
PrintArray(result);
bool resSearchElem = SearchElem(result, 4);
PrintRes(resSearchElem, 4);


