Console.Clear();
int[] mass = new int[8];

void FillArray(int[] array, int a, int b)
{
    int lenght = array.Length;
    for (int index = 0; index < lenght; index++)
    {
        array[index] = new Random().Next(a, b + 1);
    }
}

void PrintArray(int[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        if (index == 0)
            Console.Write($"[{array[index]}");
        else if (index == array.Length - 1)
            Console.Write($", {array[index]}]");
        else Console.Write($", {array[index]}");
        index++;
    }
}

FillArray(mass, 1, 100);
PrintArray(mass);