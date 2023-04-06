Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

int sum = 0;
for (int i = m; i <= n; i++)
{
    sum += i;
}

Console.WriteLine($"Результат: {sum}");