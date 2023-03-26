// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int SumAllNumber (int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num /= 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    Console.WriteLine($"{number} -> {SumAllNumber(number)}");
}
else
{
    Console.WriteLine("Введите положительное число");
}

