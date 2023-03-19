// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1000 || number < 100)
{
    Console.WriteLine("Вы ввели не трёхзначное число, повторите попытку");
}
int rang_two = number/10 % 10;
Console.WriteLine (rang_two);




