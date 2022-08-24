// Напишите программу, кот. принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины
// Каждая сторона треугольника меньше суммы двух других сторон

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

bool Triangle(int num1, int num2, int num3)
{
    return num1 + num2 > c && num2 + num3 > num1 && num1 + num3 > num2;
}

if (Triangle(a, b, c))
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}