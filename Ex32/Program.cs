// Замена элементов массива: положительные элементы замените на соответсвующие отрицательные, и наоборот [-4,-8,8,2] -> [4,8,-8,-2]

int[] GetArray(int size, int minValue, int maxValue) // Создание массива
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;                                      // Конец создания массива
}

int[] convert(int[] mas)                    // Шапка функции
{
    for (int i = 0; i < mas.Length; i++)    // Тело функции
    {
        mas[i] *= -1;
    }
    return mas;
}

int[] array = GetArray(5, -10, 11);

Console.WriteLine(string.Join(" ", array));
Console.WriteLine(string.Join(" ", convert(array)));