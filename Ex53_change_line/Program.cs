// Задача 53. Задайте двумерный массив. Поменяйте местами первую и последнюю строку массива

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

void ChangeRows(int[,] mas)
{
    int temp = 0;

    for (int i = 0; i < mas.GetLength(1); i++)
    {
        temp = mas[0, i];
        mas[0, i] = mas[mas.GetLength(0) - 1, i];
        mas[mas.GetLength(0) - 1, i] = temp;
    }
}

Console.Write("Количество строк = ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов = ");
int columns = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(rows, columns, 0, 9);

PrintArray(myArray);
Console.WriteLine();
ChangeRows(myArray);
PrintArray(myArray);
*/


// Задача 55. Задайте двумерный массив. Напишите программу, кот. заменяет строки и столбцы. 
// Если это невозможно, программа должна вывести сообщение для пользователя.

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

int[,] ChangeRowsColumns(int[,] mas)
{
    int[,] temp = new int[mas.GetLength(0), mas.GetLength(1)];

    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            temp[i, j] = mas[j, i];
        }
    }    
    return temp;
}

Console.Write("Количество строк = ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов = ");
int columns = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(rows, columns, 0, 9);

PrintArray(myArray);
Console.WriteLine();
if (myArray.GetLength(0) == myArray.GetLength(1))
{
    PrintArray(ChangeRowsColumns(myArray));
}
else
    Console.Write("Количество столбцов не совпадает с количеством строк");
