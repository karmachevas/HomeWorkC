Console.Clear();
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int b = Convert.ToInt32(Console.ReadLine());
while (b < 1) 
{
    Console.Write("Вы ошиблись\nВведите натуральное число B: ");
    b = Convert.ToInt32(Console.ReadLine());
}
int result = 1;
for (int i = 0; i < b; i++)
{
    result = result * a;
}
Console.WriteLine(result);