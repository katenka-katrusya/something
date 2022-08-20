// Задайте одномерный массив из 123 случайных чисел. Найдите кол-во элементов массива, знач. кот. лежат в отрезке [10,99]

int[] GetArray(int size, int minValue, int maxValue) 
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;                                      
}

int Check(int[] mas)
{
    int count = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if ((mas[i] >= 10) && (mas[i] < 100))
        {
            count++;
        }
    }
    return count;
}

int[] array = GetArray(123, 0, 200);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine($"{Check(array)}");