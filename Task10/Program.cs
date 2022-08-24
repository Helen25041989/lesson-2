String numberStr;
Console.WriteLine("Введите трехзначное число: ");
numberStr = Console.ReadLine();
char[] chars = numberStr.ToCharArray();
Console.WriteLine("Вторая цифра числа = " + chars[1]);