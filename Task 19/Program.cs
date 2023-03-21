// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool CheckFiveDigit (int digit_number)
{
    if (digit_number > 9999 && digit_number <= 99999)
    {
        return true;
    }
    else
    {
        Console.WriteLine("Вы ввели не пятизначное число");
        return false;
    }
}

int Upheaval(int calculate_number)
{
    int reverse_number = 0;
    while (calculate_number > 0) /* Работает так как тип данных integer, можно также было написать через перевода числа в строку и значения его длины
    (пример: len_calculate_number = calculate_number.ToString().Length) и в условии цикла смотреть длину числа меняя его каждую итерацию на единицу*/
    {
        reverse_number = reverse_number * 10 + calculate_number % 10;
        calculate_number /= 10;
    }
    return reverse_number;
}

bool CheckPolindrom (int check_number)
{
    if (check_number == Upheaval(check_number))
    {
        return true;
    }
    return false;
}

int number = Convert.ToInt32(Console.ReadLine());
if (CheckFiveDigit(number)== true)
{
    Console.WriteLine(CheckPolindrom(number));
}


