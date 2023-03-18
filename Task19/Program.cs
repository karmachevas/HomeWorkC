Console.Clear();
Console.Write("Введите пятизначное число: ");
string str = (Console.ReadLine()!);
while (str.Length < 5 || str.Length > 5)
{
    Console.Write("Вы ошиблсь\nВведите пятизначное число: ");
    str = (Console.ReadLine()!);
}
if (Convert.ToInt32(str[0].ToString()) == Convert.ToInt32(str[4].ToString()) && Convert.ToInt32(str[1].ToString()) == Convert.ToInt32(str[3].ToString()))
    Console.Write("Да");
else 
    Console.Write("Нет");