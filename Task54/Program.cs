// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void InputMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 21);
        }
    }
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void OperationMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp = 0;       
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            int index = 0;
            while (index < matrix.GetLength(1) - 1) 
            {
                if (matrix[i, index] < matrix[i, index + 1])
                {
                    temp = matrix[i, index];
                    matrix[i, index] = matrix[i, index + 1];
                    matrix[i, index + 1] = temp;
                }
                index++;
            }
        }
        
    }
}

int [,] matrix = new int [4, 9];

Console.Clear();
InputMatrix(matrix);
PrintMatrix(matrix);
OperationMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);