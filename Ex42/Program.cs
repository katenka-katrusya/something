// Задача 42. Напишите программу, кот. будет преобразовывать десятичное число в двоичное

Console.Write("Введите десятичное число: ");
int num = int.Parse(Console.ReadLine());

int GetBinary(int number)
{
    string result = "";
    
    while (number > 0)
    {
        result += Convert.ToString(number % 2);
        number /= 2;
    }
    result.ToCharArray().Reverse();
    
    return int.Parse(result);
}

Console.Write($"{GetBinary(num)}");