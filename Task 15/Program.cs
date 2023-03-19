// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
bool CheckWeekend (int day)
{
    if (day > 5)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool CheckForDays(int day)
{
    if (day > 0 && day <= 7)
    {
        return true;
    }
    Console.WriteLine ("Такого дня недели не существует");
    return false;
}

Console.WriteLine("Введите день недели(цифру)");
int day = Convert.ToInt32(Console.ReadLine());
if (CheckForDays(day)==true)
{
    Console.WriteLine(CheckWeekend(day));
}
