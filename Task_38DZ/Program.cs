// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


// double[] CreteArreyRndInt(int size)              Не разобрался
// {
//     double[] array = new double[size];
//     Random rnd = new Random{0.0};

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.NextDouble();
//     }
//     return array;
// }

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}

double MaxArr(double[] array)
{
    double max= array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>max)
        {
        max= array[i];
        }
    }
   
    return max;
}

double MinArr(double[] array)
{
    double min= array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]<min)
        {
        min= array[i];
        }
    }
   
    return min;
}

void PrintResArr(double max, double min)
{
    double res = max - min;
    Console.WriteLine($"Разница между максимальным и минимальным = {res}");
}



double[] newArr = /*CreteArreyRndInt(5);*/{3.5, 7.1, 22.9, 2.3, 78.5};
PrintArray(newArr);
double maxArray = MaxArr(newArr);
double minArray = MinArr(newArr);
PrintResArr(maxArray,minArray);

