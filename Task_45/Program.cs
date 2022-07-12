// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

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

int[] CopyArray(int[] array)
{
int[] copy = new int[array.Length];
for(int i = 0; i<copy.Length; i++)
{
    copy[i]= array[i];
}
return copy;
}

int[] mass= CreteArreyRndInt(6,1,10);
PrintArray(mass);
int[] res =CopyArray(mass);
PrintArray(res);
