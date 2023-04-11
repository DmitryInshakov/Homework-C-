//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


void NumberCounter (int num)
{
    if (num > 1) 
    {
      Console.Write($"{num}, ");  
      NumberCounter(num-1);
    } 
}

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    Console.WriteLine("Вы ввели не натуральное число");
}
else
{
    Console.Write($"{number} -> ");
    NumberCounter(number);
    Console.Write(number/number); // Для вывода единицы, иначе через метод появляется лишняя запятая. Записано так, чтобы не писать магических чисел.
}


