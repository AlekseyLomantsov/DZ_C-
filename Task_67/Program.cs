// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int NaturalNamber(int num, int sum)
{
    sum += num % 10;
    if (num / 10 == 0) return sum;
    else return NaturalNamber(num / 10, sum);

}

int NaturalNamberVar2(int n)
{
    if (n > 0) return n % 10 + NaturalNamberVar2(n / 10);
    return 0;

}


int sum = NaturalNamber(number, 0);
Console.WriteLine(sum);
int sum2 = NaturalNamberVar2(number);
Console.WriteLine(sum2);

