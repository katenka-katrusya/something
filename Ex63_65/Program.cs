// Задача 63. Задайте значение N. Наишите программу, которая выведет все натуральные числа в промежутке от 1 до N
// N = 5 -> "1, 2, 3, 4, 5"

/*string PrintN(int start, int end)
{
    if (start == end) return start.ToString();
    else
    {
        return start + ", " + PrintN(start + 1, end);
    }
}

Console.Write("N = ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(PrintN(1, num)); */

// Задача 65. Задайте значения M и N. Наишите программу, которая выведет все натуральные числа в промежутке от M до N
// M=4, N=8 -> "4, 5, 6, 7, 8"

string PrintN(int M, int N)
{
    if (M == N) return M.ToString();
    else
    {
        return M + ", " + PrintN(M + 1, N);
    }
}

Console.Write("M = ");
int numM = int.Parse(Console.ReadLine());
Console.Write("N = ");
int numN = int.Parse(Console.ReadLine());
Console.WriteLine(PrintN(numM, numN)); 