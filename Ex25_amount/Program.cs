// Напишите программу, кот. принимает на вход число и выдаёт количество цифр в числе. Напр., 456 -> 3; 78 -> 2

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int DigitCount(int a) // объявление функции
{
    int count = 0;
    while (a != 0)
    {
        count++;
        a /= 10; //num = num /10
    }
    return count;
}

Console.WriteLine(DigitCount(num));
