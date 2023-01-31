Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int tempNumber = number;
int divisor1 = 10;
int divisor2 = 1;
int index = 0;
int thirdDigital = 0;


while (tempNumber != 0)
{
    tempNumber = tempNumber - tempNumber % divisor1;
    index++;
    divisor1 *= 10;
}


if (index < 3)
{
    Console.WriteLine("Третьей цифры нет!");
}

else

{
    while (index > 3)
    {
        divisor2 *= 10;
        index--;
    }
    
    thirdDigital = (number / divisor2) % 10;
    
    if (thirdDigital < 0)
    {
        Console.WriteLine($"Третья цифра - {thirdDigital - 2 * thirdDigital}");
    }
    else
    {
        Console.WriteLine($"Третья цифра - {thirdDigital}");
    }    
}


