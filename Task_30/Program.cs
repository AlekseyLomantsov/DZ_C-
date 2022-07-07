// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// int[] array = new int[8];
// int len = array.Length;
// int index = 0;
// var rnd = new Random();

// while(index< array.Length)
// {
// array[index] = rnd.Next(0, 2);
// index++;
// }

// for (int i = 0; i < len; i++)
// {
//     if(i == 0)Console.Write("[");
//     if (i < len - 1) Console.Write(array[i] + ",");
//     else Console.Write(array[i] + "]");
// }

int[] ArrayBin(int size)
{
    int[] array = new int[size];
    int index = 0;
    var rnd = new Random();

    while (index < array.Length)
    {
        array[index] = rnd.Next(0, 2);
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
int[] resArray = ArrayBin(15);
PrintArrey(resArray);

