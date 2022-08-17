// Напишите программу, кот. принимает на вход число (А) и выдает сумму чисел от 1 до А. Напр., 7 -> 28 

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int GetSumNums(int num)
{
    int sum = 0;

    for (int i = 1; i <= num; i++)
    {
        sum += i; // sum = sum + i
    }
    return sum;
}
Console.WriteLine(GetSumNums(num));