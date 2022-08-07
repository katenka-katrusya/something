Console.Write("Введите первое число: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numB = int.Parse(Console.ReadLine());
int sqr = numB * numB;
if (numA == sqr)
Console.Write($"{numB} является квадратом числа {numA}");
else
Console.Write($"{numB} не является квадратом числа {numA}");
