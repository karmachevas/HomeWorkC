Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(n);
int result = 0;
for (int i = 0; i < str.Length; i++)
{
    result = result + Convert.ToInt32(str[i].ToString());
}
Console.WriteLine(result);