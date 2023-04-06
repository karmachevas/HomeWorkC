bool isExist (int number, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (number == array[i])
        return true;
    }
    return false;
}
void InputMatrix (int[,,] matrix, int[] array)
{
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                int x = 0;
                while (isExist(x, array))
                {
                    x = new Random().Next(10,100);
                }
                array[k] = x;
                matrix[i,j,z] = x;
                k++;
            }
        }
    }
}
void PrintMatrix (int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                Console.WriteLine($"{matrix[i,j,z]}({i}, {j}, {z})");
            }
        }
    }
}
int [,,] matrix = new int [2, 2, 2];
int [] array = new int [9];
Console.Clear();
InputMatrix(matrix, array);
PrintMatrix(matrix); 