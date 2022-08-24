String numberStr;
Console.WriteLine("Введите число: ");
numberStr = Console.ReadLine();
char[] chars = numberStr.ToCharArray();
if (chars.Length < 3)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine(chars[2]);
}