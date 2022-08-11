// Проверяет на вход два числа и проверяет, является ли одно число квадратом другого. Напр., 5, 25 -> да; -4, 16 -> да; 8, 9 -> нет; 25, 5 -> да

Console.WriteLine("Введите первое число: ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numB = int.Parse(Console.ReadLine());
int sqr1 = numA * numA;
int sqr2 = numB * numB;
if ((sqr1 == numB) || (sqr2 == numA)) 
{
    Console.WriteLine("Да");
}
else {
    Console.WriteLine("Нет");
}
