Console.Clear();
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int n = 1;
while (n <= x) 
{
    Console.Write($"{n*n*n} ");
    n++;
}