// Задайте массив дробных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3,01 7,23 22,79 2,38 78,45] -> 76,07

Console.Clear();
double[] mass = new double[8];

void FillArray(double[] array, int a, int b)
{
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = Math.Round(new Random().NextDouble() * (b - a) + a, 2);
    }
}

void PrintArray(double[] array)
{
    Console.WriteLine($"[{string.Join(", ", mass)}]");
}

double MaxElemArray(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        max = array[i];
    }
    return max;
}

double MinElemArray(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        min = array[i];
    }
    return min;
}


FillArray(mass, 0, 10);
PrintArray(mass);
Console.WriteLine(MaxElemArray(mass) - MinElemArray(mass));