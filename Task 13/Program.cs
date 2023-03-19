// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int FindThirdRang (int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool CheckThirdDigit (int number)
{
    if (number < 100)
    {
        Console.WriteLine("третьей цифры нет");
        return false;
    }
    return true;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (CheckThirdDigit(number))
{
    Console.WriteLine(FindThirdRang(number));
}