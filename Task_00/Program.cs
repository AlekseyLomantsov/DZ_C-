Console.Write("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine()); //<-это более универсальный(конвертирования)
//int num = int.Parse(Console.ReadLine());
int square = num * num;
Console.WriteLine($"Квадрат числа {num} = {square}");

