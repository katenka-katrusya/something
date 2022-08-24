// Задача 44. Не испульзуя рекурсию, выведите первые N чисел Фибоначчи: 0 и 1. Если N=5 -> 0 1 1 2 3; N=3 -> 0 1 1

/*Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

void Fibonacci(int n)
{
    int[] num = new int[n];
    num[0] = 0;
    num[1] = 1;

    for (int i = 2; i < n; i++)
    {
        num[i] = num[i - 1] + num[i - 2];
    }
    var str = String.Join(" ", num);
    Console.WriteLine($"Первые {n} чисел Фибоначчи: {str}");
}

Fibonacci(N);*/


// Задача 45. Напишите программу, кот. будет создавать копию заданного массива с помощью поэлементного копирования

int[] GetArray(int size, int minValue, int maxValue) 
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;                                      
}

int[] GetCopy(int[] array)
{
    int[] result = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[i];
    }
    return result;
}

int[] myArray = GetArray(5, 1, 10);
Console.WriteLine(String.Join(" ", myArray));
Console.WriteLine(String.Join(" ", GetCopy(myArray)));