// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int [] CreateMassif (int sizeMassif, int minrnd, int maxrnd)
{
    int [] massif = new int [sizeMassif];
    Random rnd = new Random(); 
    for (int i = 0; i < sizeMassif; i++)
    {
        massif[i] = rnd.Next (minrnd,maxrnd + 1);
    }
    return massif;
}

int SumOddPosition (int [] arrayNumbers)
{
    int sum = 0;
    for (int i = 0; i < arrayNumbers.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += arrayNumbers[i];
        }
    }
    return sum;
}

void PrintArray (int [] mas)
{
    Console.Write("[");
    for (int i = 0; i < mas.Length - 1; i++)
    {
        Console.Write($"{mas[i]}, ");
    }
    Console.Write($"{mas[mas.Length-1]}");
    Console.Write($"] -> {SumOddPosition(mas)}");
}

Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size < 0 || size == 0)
{
    Console.WriteLine("Вы ввели неверное число (размер массива от 1 и более)");
}
else
{
    Console.Write("Введите начальное значение для диапазона случайного числа: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите конечное значение для диапазона случайного числа: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int [] array = CreateMassif(size,min,max);
    PrintArray(array);
}

