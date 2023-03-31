Console.Clear();
int M = 5;
int[] arr = new int [M];
int count = 0;
Console.WriteLine($"Необходимо ввести {M} чисел");
for (int i = 0; i < M; i++)
{
    Console.WriteLine($"Введите {i+1}-ое число: ");
    arr[i] = int.Parse(Console.ReadLine()!);
    if (arr[i] > 0)
        count++;
}
Console.WriteLine($"[{string.Join(", ", arr)}]");
Console.WriteLine(count);