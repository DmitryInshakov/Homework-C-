// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Construction (int basis, int degrees)
{
    if (degrees == 0) return 1;
    else return Construction(basis,degrees- 1) * basis;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int n = Convert.ToInt32(Console.ReadLine());
if (a==0 && n == 0)
{
    Console.WriteLine("Выражение не имеет смысла");
}
else 
{   
    if (n > 0)
    {
        Console.WriteLine(Construction(a,n));
    }
}
