// Задайте двумерный массив размера m x n, каждый элемент в массиве находится по формуле: Amn = m + n. Выведите полученный массив на экран. 
// m=3, n=4    0123
//             1234
//             2345

int[,] GetArray(int m, int n) 
{
    int[,] res = new int[m, n];

    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i, j] = i + j;
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

Console.Write("m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, n);
PrintArray(myArray);
