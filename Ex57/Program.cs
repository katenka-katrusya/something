// Составить частотный словарь элементов двумерного массива. Частотный словарь содержитинформацию о том, 
// сколько раз встречается элемент входных данных

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] res = new int[rows, columns];

    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

int[] GetRowArray(int[,] array)
{
    int[] newArray = new int[array.GetLength(0) * array.GetLength(1)];
    int index = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[index] = array[i, j];
            index++;
        }
    }
    return newArray;
}

void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i + 1; j < inArray.Length; j++)
        {
            if (inArray[i] > inArray[j])
            {
                int k = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = k;
            }
        }
    }
}

void FraqArray(int[] array)
{
    int count = 1;

    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] == array[i + 1])
        {
            count++;
        }
        else
        {
            Console.WriteLine($"{array[i]} встречается {count} раз");
            count = 1;
        }
    }
    Console.WriteLine($"{array[array.Length - 1]} встречается {count} раз");
}

Console.Write("Количество строк = ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов = ");
int columns = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(rows, columns, 0, 9);

PrintArray(myArray);
int[] newArray = GetRowArray(myArray);
SortArray(newArray);
FraqArray(newArray);