// Напишите программу, которая на вход принимает число (N) и выдает таблицу квадратов чисел от 1 до N. Напр. 5 -> 1,4,9,16,25

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.Write(Math.Pow(i, 2) + ", ");
}