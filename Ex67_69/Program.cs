// Задача 67. Напишите программу, которая на вход будет принимать число и возвращать сумму его цифр
// 453 -> 12

/*int SumNumber(int num)
{
    return num <= 0 ? 0 : num % 10 + SumNumber(num / 10);
}

Console.Write("Число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Сумма цифр: " + SumNumber(num)); */

/* код программы итеративный способ:
int SumNumber(int num)
{
    int SumNumber = 0;
    while (num > 0)
    {
        SumNumber = SumNumber + num % 10;
        num /= 10;
    }
    return SumNumber;
}*/

// Задача 69. Напишите программу, которая на вход принимает два числа А и В, и возводит число А в целую степень В с помощью рекурсии
// А=3; В=5 -> 243

int RowRec(int a, int n)
{
    //return n == 0 ? 1 : a * RowRec(a, n - 1);          // 1 вариант решения
    if (n == 0) return 1;
    else if (n % 2 == 0) return RowRec(a * a, n / 2);    // 2 вариант (быстрее считает)
    else return a * RowRec(a, n - 1);
}

Console.Write("Основание степени (А): ");
int A = int.Parse(Console.ReadLine());
Console.Write("Показатель степени (В): ");
int B = int.Parse(Console.ReadLine());

if (A == 0 || B < 0)
{
    Console.WriteLine("Введенные значения не соответствуют условию");
}
else
{
    Console.WriteLine(RowRec(A, B));
}