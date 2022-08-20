// Напишите программу, кот. принимает на вход число N и выдает произведение чисел от 1 до N. 4 -> 24; 5 -> 120

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int factorial(int N)
{
    int a = 1; // Сумму инициализируем 0, а произведение 1

    for (int i = 2; i <= N; i++) // i ьщжет начинаться и с 1, но тогда лишний шаг 1*1
    {
        a *= i;
    }
    return a;
}

Console.WriteLine(factorial(num));