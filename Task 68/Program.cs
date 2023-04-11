// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AkkermanFunction (int m, int n)
{
    if(m == 0) return n + 1;
    else if (n == 0 && m != 0) return AkkermanFunction(m-1,1);
    else return AkkermanFunction(m - 1, AkkermanFunction(m, n-1));
}

Console.Write("Введите число M: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
if (numberOne < 0 || numberTwo < 0)
{
    Console.WriteLine("Вы ввели отрицательные числа! (Используйте только положительные числа)");
}
else
{
    Console.Write($"m = {numberOne}, n = {numberTwo} -> A(m,n) = {AkkermanFunction (numberOne, numberTwo)}");
}