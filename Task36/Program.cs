// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}

void PrintSummElemNotEvenPosArray(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            summ = summ + array[i];
        }
    }
    Console.WriteLine(summ);
}

FillArray(mass, -10, 10);
PrintArray(mass);
PrintSummElemNotEvenPosArray(mass);