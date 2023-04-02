void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 11);
    }
}

void OutputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}



Console.Clear();
int[,] matrix = new int[4, 7];
Console.Write("Введите позицию в массиве: ");
int[] position = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
InputMatrix(matrix);
OutputMatrix(matrix);
if (position[0] + 1 > matrix.GetLength(0) || position[1] + 1 > matrix.GetLength(1))
    Console.WriteLine("Такой позиции нет");
else
    Console.WriteLine(matrix[position[0], position[1]]);