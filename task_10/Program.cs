Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((99 < number && number < 1000) || (-99 > number && number > -1000))
{
    int secondDigital = ((number - number % 10) % 100) / 10;
    if (secondDigital < 0)
    {
        Console.WriteLine($"Вторая цифра - {secondDigital - 2 * secondDigital}");
    }
    else
    {
        Console.WriteLine($"Вторая цифра - {secondDigital}");
    }

}

else
{
    Console.WriteLine("Неверный ввод!");
}