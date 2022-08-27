// Задача 49. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты

/* int[,] GetArray(int rows, int columns, int minValue, int maxValue) 
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

int[,] CorrectArray(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                mas[i, j] *= mas[i, j];
            }
        }
    }
    return mas;
}

Console.Write("Количество строк = ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов = ");
int columns = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(rows, columns, 0, 9);
PrintArray(myArray);
Console.WriteLine();
int[,] newArray = CorrectArray(myArray);
PrintArray(newArray); */





// Задача 51. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с i (0,0); (1;1) и тд.)
// 1472
// 5923
// 8424     Сумма по диагонали 1+9+2 = 12

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

int SumDiagonalArray(int[,] mas)
{
    int sum = 0;
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += mas[i, j];
            }
        }
    }
    return sum;
}

Console.Write("Количество строк = ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов = ");
int columns = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(rows, columns, 0, 9);
PrintArray(myArray);
Console.WriteLine();
int resultSum = SumDiagonalArray(myArray);
Console.WriteLine($"Сумма элементов по диагонали: {resultSum}");
