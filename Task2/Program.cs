// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
//Console.Write($"Вы ввели: {n}");

Console.Clear();
Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());

if (n > m)
    Console.Write($"max = {n}, min = {m}");
else if (n < m)
    Console.Write($"max = {m}, min = {n}");
else Console.Write($"Числа равны");