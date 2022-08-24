String numberStr;
Console.WriteLine("Введите число: ");
numberStr = Console.ReadLine();
int daysNumber = int.Parse(numberStr);

int[] weekdays = { 1, 2, 3, 4, 5 };
int[] dayOff = { 6, 7 };

if (dayOff.Contains(daysNumber))
{
    Console.WriteLine("да");
}
if (weekdays.Contains(daysNumber))
{
    Console.WriteLine("нет");
}