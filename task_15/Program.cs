int[] arrayWeekend = { 6, 7 };

Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
int temp = 0;

if (day > 0 && day < 8)
{
    int index = 0;
    while (index < 2)
    {
        if (arrayWeekend[index] == day)
        {
            Console.WriteLine("Это выходной.");
            temp++;
            break;
        }
        index++;
    }
    if (temp == 0)
    {
        Console.WriteLine("Это рабочий день.");
    }
}

else
{
    Console.WriteLine("Неверный ввод!");
}