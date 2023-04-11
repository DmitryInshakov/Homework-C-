// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

int SumNumbers(int m, int n)
{
    if (m == n) return m;
    else if (m < n) return n + SumNumbers(m,n-1); 
    else return n + SumNumbers(m,n+1); // if (m > n)
}

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M = {firstNumber}, N = {secondNumber} -> {SumNumbers(firstNumber,secondNumber)}");

