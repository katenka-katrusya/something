// Напишите программу, которая по заданному номеру четверти показывает диапозон возможных координат точек в этой четверти (x и y)

Console.Write("Введите номер четверти плоскости координат: ");
int quarter = int.Parse(Console.ReadLine());
switch (quarter)
{
    case 1: Console.WriteLine("x > 0 и y > 0"); break;
    case 2: Console.WriteLine("x < 0 и y > 0"); break;
    case 3: Console.WriteLine("x < 0 и y < 0"); break;
    case 4: Console.WriteLine("x > 0 и y < 0"); break;
    default: Console.WriteLine("Неправильный номер"); break;
}
/* Console.Write("Введите номер четверти плоскости координат: "); // Лучше решать методом switch case
int num = int.Parse(Console.ReadLine());
if (num == 1)
{
    Console.WriteLine("x > 0 и y > 0");
}

if (num == 2)
{
    Console.WriteLine("x < 0 и y > 0");
}

if (num == 3)
{
    Console.WriteLine("x < 0 и y < 0");
}

if (num == 4)
{
    Console.WriteLine("x > 0 и y < 0");
} */