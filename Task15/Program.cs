// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
int n = 0;
while (n < 1 || n > 7)
{
    Console.Write("Введите номер дня недели: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 6 || n == 7)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");