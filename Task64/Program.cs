string f(int n)
{
    if (n == 1)
        return $"{1}";
    else 
        return $"{n} " + f(n - 1);
}

Console.Clear();
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write(f(n));