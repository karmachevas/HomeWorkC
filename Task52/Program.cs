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

string WorkMatrix(int[,] matrix)
{
    string str = "Среднее арифметическое каждого столбца: ";
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int summ = 0;
        double x = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            summ = summ + matrix[j, i];
            x = Convert.ToDouble(summ) / 2;
        }
        str = str + Convert.ToString(x) + "; ";
    }
    return str;
}

Console.Clear();
int[,] matrix = new int[2, 3];
InputMatrix(matrix);
OutputMatrix(matrix);
Console.WriteLine(WorkMatrix(matrix));