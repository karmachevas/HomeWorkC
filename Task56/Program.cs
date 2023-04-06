
void InputMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
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

void OperationMatrix (int[,] matrix, int[] array)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        int k = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[k] = sum;
        k++;
    }
    int minSum = array[0];
    int indexMinSum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minSum)
        {
            minSum = array[i];
            indexMinSum = i;
        }
    }
    Console.WriteLine($"{indexMinSum+1} строка");
}
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray();
int [,] matrix = new int [size[0], size[1]];
int[] array = new int[size[1]];
Console.Clear();
InputMatrix(matrix);
PrintMatrix(matrix); 
OperationMatrix(matrix, array);