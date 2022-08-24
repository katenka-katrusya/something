// Напишите программу, кот. перевернёт одномерный массив [1 2 3 4 5] -> [5 4 3 2 1]

int[] GetArray(int size, int minValue, int maxValue) 
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;                                      
}

// int[] ReversArray(int[] array)
// {
//     int[] result = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         result[i] = array[array.Length - 1 - i];
//         Console.WriteLine($"{array.Length - 1 - i}: {array[array.Length - 1 - i]}");
//         Console.WriteLine($"{i}: {result [i]}");
//         Console.WriteLine("---------");
//     } 
//     return result;
// }

int[] ReversArray2(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;
}

int[] myArray = GetArray(5, 0, 10);
Console.WriteLine(String.Join(" ", myArray));
Console.WriteLine(String.Join(" ", ReversArray2(myArray)));
// Console.WriteLine(String.Join(" ", ReversArray(myArray)));