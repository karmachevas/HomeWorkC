void PrintTab(int n)
{
    for (int i = 0; i < n; i++)
        {
            Console.Write(" \t");
        }
}


int factorial(int n)
{
    int i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}

void InputMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < (matrix.GetLength(1) - (matrix.GetLength(1) - (i + 1))); j++)
        {
            matrix[i, j] = factorial(i) / (factorial(j) * factorial(i - j));
        }
    }
}
void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int t = 0; t < matrix.GetLength(0) - (i + 1); t++)
        {   
            PrintTab(1);
        }

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == 0)
            {
                Console.Write($" ");
            }
            else
            Console.Write($"{matrix[i, j]}\t \t");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [N, N];
Console.Clear();
InputMatrix(matrix);
PrintMatrix(matrix); 
