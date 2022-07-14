// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите колличество цифр: ");
int size = Convert.ToInt32(Console.ReadLine());
// string[] input = Console.ReadLine().Split(',').ToArray();

int[] Array(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Вводите цифры по 1: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}


int ArrMoreZero(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }

    }
    return count;
}

void Print(int num)
{
    Console.WriteLine($"Чисел больше нуля введено {num}");
}
int[] array = Array(size);/*{0, 7, 8, -2, -2};*/
int result = ArrMoreZero(array);
Print(result);
