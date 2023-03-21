// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

bool CheckNaturalNumber(int number_natural)
{
    if (number_natural > 0)
    {
        return true;
    }
    else
    {
        Console.WriteLine("Вы ввели число меньше единицы");
        return false;
    }
}

int TableCubes(int initial_number)
{
    Console.Write($"{initial_number} -> 1"); /* Число один в кубе всегда единица, делаем данную запись для возможности вывода полученных данных в цикле в строчку 
    (если так не сделать,то в конце последнего числа всегда будет запятая)*/
    for (int i = 2; i <= initial_number; i++)
    {
        Console.Write(", {0}",Math.Pow(i,3));
    }
    return 0;
}

Console.Write ("Введите число: ");
int quantity = Convert.ToInt32(Console.ReadLine());
if (CheckNaturalNumber(quantity) == true)
{
    TableCubes(quantity);
}

