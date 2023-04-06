
void InputMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 4);
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

int[,] OperationMatrix (int[,] matrixA, int[,] matrixB) // е
{
    int [,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            int summ = 0;
            for (int z = 0; z < matrixA.GetLength(1); z++)
            {
                summ += matrixA[i, z] * matrixB[z, j];
            }
            matrixC[i, j] = summ;
        }
    }
    return matrixC;
}
Console.Write("Введите размеры матрицы A: ");
int[] sizeA = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray();
int [,] matrixA = new int [sizeA[0], sizeA[1]];
Console.Write("Введите размеры матрицы B: ");
int[] sizeB = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray();
int [,] matrixB = new int [sizeB[0], sizeB[1]];
Console.Clear();
InputMatrix(matrixA);
InputMatrix(matrixB);
Console.WriteLine("Матрица А");
PrintMatrix(matrixA);
Console.WriteLine("Матрица B");
PrintMatrix(matrixB); 
OperationMatrix(matrixA, matrixB);

if (matrixA.GetLength(1) == matrixB.GetLength(0))
{
    Console.WriteLine("Матрица C");
    PrintMatrix(OperationMatrix(matrixA, matrixB));
}
else
    Console.WriteLine("Умножение данных матриц невозможно");