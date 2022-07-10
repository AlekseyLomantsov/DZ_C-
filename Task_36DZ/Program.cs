// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов,
//  стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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

int SearchElem(int[] array)
{
        int sum=0;
   
    for (int i = 0; i < array.Length; i++)
    {
        if (1 == i  % 2) 
        {
            sum+=  array[i];
        }
    }
    return sum;
}

void PrintRes(int res)
{
    Console.WriteLine($"Сумма не четных чисел = {res}");
}

int[] newArr = CreteArreyRndInt(5, 1, 10);//{-4, -6, 89, 6};
PrintArray(newArr);
int result = SearchElem(newArr);
PrintRes(result);