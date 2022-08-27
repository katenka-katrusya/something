// Задайте двумерный массив размером m x n, заполненный случайными целыми числами

int[,] GetArray(int m, int n, int minValue, int maxValue) 
{
    int[,] res = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            res[i, j] = new Random().Next(minValue, maxValue + 1);
    
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


Console.Write("m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, n, 0, 100);
PrintArray(myArray);

