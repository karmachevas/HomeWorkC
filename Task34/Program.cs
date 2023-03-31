// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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

void PrintQuantityEvenNumderArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] % 2 == 0)
        count++; 
    }
    Console.WriteLine(count);
}

FillArray(mass, 100, 999);
PrintArray(mass);
PrintQuantityEvenNumderArray(mass);